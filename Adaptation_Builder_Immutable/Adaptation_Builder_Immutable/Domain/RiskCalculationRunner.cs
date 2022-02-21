using System.Collections.Generic;
using Adaptation_Builder_Immutable.Enums;
using Adaptation_Builder_Immutable.Interfaces;

namespace Adaptation_Builder_Immutable.Domain
{
    public class RiskCalculationRunner
    {
        private readonly IList<IEconomicEntity> _economicEntities = new List<IEconomicEntity>();
        private IRiskDataDao RiskDataDao { get; set; }
        private IMarketDao MarketDataDao { get; set; }
        private IEnumerable<IEligibilityInformation> EligibilityInformation { get; set; }
        private Dictionary<CreditRatings, CreditQualitySteps> CreditQualities { get; set; }
        private Dictionary<CreditQualitySteps, double> RiskWeigts { get; set; }
        private void CreateEconomicEntities(IEnumerable<IBasicEntityObject> objectsToAdaptFrom)
        {
            foreach (var basicObect in objectsToAdaptFrom)
            {
                _economicEntities.Add(
                    new SimpleAdaptor(RiskWeigts, CreditQualities, EligibilityInformation).AdaptFrom(basicObect));
            }
        }

        public RiskCalculationRunner(IRiskDataDao riskDataDao, IMarketDao marketDataDao)
        {
            RiskDataDao = riskDataDao;
            MarketDataDao = marketDataDao;
        }

        public void Run(IEnumerable<IBasicEntityObject> objectsToAdaptFrom)
        {
            RiskWeigts = RiskDataDao.GetRiskweights();
            CreditQualities = RiskDataDao.GetCreditQualities();
            EligibilityInformation = RiskDataDao.GetEligibilityInformation();

            CreateEconomicEntities(objectsToAdaptFrom);

            /* Calculation will be added here*/
        }
    }

    public interface IMarketDao
    {
    }

    public interface IRiskDataDao
    {
        Dictionary<CreditQualitySteps, double> GetRiskweights();

        Dictionary<CreditRatings, CreditQualitySteps> GetCreditQualities();

        IEnumerable<IEligibilityInformation> GetEligibilityInformation();
    }
}
