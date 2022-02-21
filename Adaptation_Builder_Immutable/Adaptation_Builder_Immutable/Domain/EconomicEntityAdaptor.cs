using System;
using System.Collections.Generic;
using System.Linq;
using Adaptation_Builder_Immutable.Enums;
using Adaptation_Builder_Immutable.Interfaces;

namespace Adaptation_Builder_Immutable.Domain
{
    public abstract class EconomicEntityAdaptor : IEconomicEntityAdaptor
    {
        private readonly Dictionary<CreditQualitySteps, double> _riskWeights;
        private readonly Dictionary<CreditRatings, CreditQualitySteps> _creditQuality;
        private readonly IEnumerable<IEligibilityInformation> _eligibilityInformation;

        public EconomicEntityAdaptor(Dictionary<CreditQualitySteps,double> riskWeights, 
            Dictionary<CreditRatings,CreditQualitySteps> creditQuality,
            IEnumerable<IEligibilityInformation> eligibilityInformation)
        {
            _riskWeights = riskWeights;
            _creditQuality = creditQuality;
            _eligibilityInformation = eligibilityInformation;
        }

        public IEconomicEntity AdaptFrom(IBasicEntityObject objectInstance)
        {
            var economicEntityBuilder = new EconomicEntityBuilder();

            economicEntityBuilder.SetCounterpartyId(objectInstance.CounterpartyId);
            economicEntityBuilder.SetCounterpartyName(objectInstance.CounterpartyName);
            economicEntityBuilder.SetNettingPool(objectInstance.NettingGroupName);
            economicEntityBuilder.SetRemainingMaturity(objectInstance.RemainingMaturity);
            economicEntityBuilder.SetEffectiveMaturity(objectInstance.EffectiveMaturity);
            economicEntityBuilder.SetEAD(objectInstance.ExposureAtDefault);

            CreditQualitySteps creditQualityStep;
            CreditRatings creditRating;
            if (_creditQuality.ContainsKey(objectInstance.CreditRating))
            {
                creditQualityStep = _creditQuality[objectInstance.CreditRating];
                creditRating = objectInstance.CreditRating;
            }
            else
            {
                creditQualityStep = CreditQualitySteps.Undefined;
                creditRating = CreditRatings.Undefined;
            }

            economicEntityBuilder.SetCreditRatings(creditRating, creditQualityStep);

            var isEligible = _eligibilityInformation.Any(x => x.CounterpartyName == objectInstance.CounterpartyName);
            economicEntityBuilder.SetIsEligible(isEligible);

            CreditQualitySteps finalCreditQualityStep;
            double weight;
            if (creditQualityStep != CreditQualitySteps.Undefined)
            {//Special rule to upgrade CR Step 5 to Setp 6
                finalCreditQualityStep = creditQualityStep < CreditQualitySteps.CreditQualityStep5
                    ? creditQualityStep
                    : CreditQualitySteps.CreditQualityStep6;
            }
            else
            {
                finalCreditQualityStep = CreditQualitySteps.CreditQualityStep6;
            }


            if (_riskWeights.ContainsKey(finalCreditQualityStep))
                weight = _riskWeights[finalCreditQualityStep];
            else
                throw new Exception($"Missing credit quality steps and risk weights for credit quality step : {finalCreditQualityStep}");

            economicEntityBuilder.SetRiskWeight(finalCreditQualityStep, weight);

            return economicEntityBuilder.BuildDeal();
        }
    }
}
