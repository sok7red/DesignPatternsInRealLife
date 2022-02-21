using System.Linq;
using Adaptation_Builder_Immutable.Domain;
using MoreLinq;
using NUnit.Framework;
using SpecflowTests.Context;
using SpecflowTests.TestModel;
using SpecflowTests.ValidationModel;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecflowTests.Steps
{
    [Binding]
    public sealed class EconomicEntityAdaptationStepDefinitions
    {

        private readonly BasicEntityModelContext _nonImmTradesContext;
        private readonly EligibleCounterpartiesContext _eligibleCounterpartyContext;
        private readonly CreditInformationContext _creditInformationContext;
        private readonly EconomicEntityContext _economicEntityContext;

        public EconomicEntityAdaptationStepDefinitions(BasicEntityModelContext nonImmTradesContext,
            EligibleCounterpartiesContext eligibleCounterpartyContext,
            CreditInformationContext creditInformationContext,
            EconomicEntityContext economicEntityContext)
        {
            _nonImmTradesContext = nonImmTradesContext;
            _eligibleCounterpartyContext = eligibleCounterpartyContext;
            _creditInformationContext = creditInformationContext;
            _economicEntityContext = economicEntityContext;
        }

        [Given(@"an object of data to be adapted")]
        public void GivenAListOfDataToBeAdapted(Table table)
        {
            var nonImmDealRows = table.CreateSet<BasicEntityValidationModel>();
            nonImmDealRows.ForEach(_nonImmTradesContext.AddNonImaEntities);
        }

        [Given(@"a list of eligible counterparties for the Adaptation")]
        public void GivenAListOfEligibleCounterparties(Table table)
        {
            var eligibleCounterparties = table.CreateSet<EconomicEntityEligibilityInformation>();
            eligibleCounterparties.ForEach(_eligibleCounterpartyContext.AddEECounterpartyModel);
        }

        [Given(@"I am provided with the required Credit Quality information")]
        public void GivenCreditQualityInformation(Table table)
        {
            var creditInformation = table.CreateSet<CreditInformationModel>();
            creditInformation.ForEach(_creditInformationContext.MakeCreditObject);
        }

        [When(@"I create the Economic Entity object")]
        public void AdaptatEE()
        {
            var adaptor = new SimpleAdaptor(_creditInformationContext.RiskWeight,
                _creditInformationContext.Ratings, _eligibleCounterpartyContext.GetEligibleCounterpartyInformation());

            _nonImmTradesContext.GetNonImaEntities().ForEach(x => _economicEntityContext.AddDeal(adaptor.AdaptFrom(x)));
        }

        [Then(@"I should be able to validate the CreditQualityInformation for each trade")]
        public void ThenIShouldBeAbleToDetermineTheCreditQualityInfoForATrade(Table table)
        {
            var expectedCreditQualityValidationModels = table.CreateSet<BasicEntityValidationModel>();

            int positionIndex = 0;

            expectedCreditQualityValidationModels.ForEach(x =>
            {
                Assert.IsTrue(_economicEntityContext.EEntity.Any(), $"No expected entities found for CounterpartyId {x.CounterpartyId}");

                Assert.AreEqual(_economicEntityContext.EEntity.Count(), expectedCreditQualityValidationModels.Count(), $"Incorrect number of Expected deals defined in the specflow test, " +
                    $"specified '{expectedCreditQualityValidationModels.Count()}' instead of '{_economicEntityContext.EEntity.Count()}'");

                var actualEntity = _economicEntityContext.EEntity.ToArray()[positionIndex];

                Assert.AreEqual(actualEntity.CreditRatings.TheCreditQuality.CreditRating, x.CreditRating, $"CreditRating error : Actual Entity with '{actualEntity.CounterpartyId}' has CreditQualityInformation " +
                    $"to '{actualEntity.CreditRatings.TheCreditQuality.CreditRating}' when the expected value was '{x.CreditRating}'");

                positionIndex++;
            });
        }
    }
}
