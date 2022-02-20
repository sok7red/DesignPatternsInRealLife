using System;
using Adaptation_Builder_Immutable.Enums;
using Adaptation_Builder_Immutable.Interfaces;

namespace Adaptation_Builder_Immutable.Domain
{
    class EconomicEntityObjectBuilder
    {
        private int? _counterpartyId;
        public EconomicEntityObjectBuilder SetCounterpartyId(int counterpartyId)
        {
            _counterpartyId = counterpartyId;
            return this;
        }

        private string _counterpartyName;
        public EconomicEntityObjectBuilder SetCounterpartyName(string counterpartyName)
        {
            _counterpartyName = counterpartyName;
            return this;
        }

        private string _nettingPool;
        public EconomicEntityObjectBuilder SetNettingPool(string nettingPool)
        {
            _nettingPool = nettingPool;
            return this;
        }

        private double _remainingMaturity;
        public EconomicEntityObjectBuilder SetRemainingMaturity(double remainingMaturity)
        {
            _remainingMaturity = remainingMaturity;
            return this;
        }
        private double _effectiveMaturity;
        public EconomicEntityObjectBuilder SetEffectiveMaturity(double effectiveMaturity)
        {
            _effectiveMaturity = effectiveMaturity;
            return this;
        }
        private decimal _exposureAtDefault;
        public EconomicEntityObjectBuilder SetEAD(decimal exposureAtDefault)
        {
            _exposureAtDefault = exposureAtDefault;
            return this;
        }
        private CreditQualityInformation _creditRatings;
        public EconomicEntityObjectBuilder SetCreditRatings(CreditRatings creditRatingMoodys, CreditQualitySteps creditQualityMoodys)
        {
            _creditRatings = new CreditQualityInformation(creditRatingMoodys, creditQualityMoodys);
            
            return this;
        }

        private bool _isEligible;
        public EconomicEntityObjectBuilder SetIsEligible(bool isEligible)
        {
            _isEligible = isEligible;
            return this;
        }
        private RiskWeight _riskWeight;
        public EconomicEntityObjectBuilder SetRiskWeight(CreditQualitySteps creditQuality, double weight)
        {
            _riskWeight = new RiskWeight(creditQuality, weight);

            return this;
        }

        public IEconomicEntity BuildDeal()
        {
            if(_counterpartyId == null)
            {
                throw new ArgumentNullException("CounterpartyId is missing");
            }

            return new EconomicEntityObject(
                counterpartyId:_counterpartyId.Value,
                counterpartyName:_counterpartyName,
                nettingGroupName: _nettingPool,
                effectiveMaturity:_effectiveMaturity,
                remainingMaturity:_remainingMaturity,
                exposureAtDefault:_exposureAtDefault,
                creditRatings: _creditRatings,
                isEligible: _isEligible,
                riskWeight:_riskWeight
            );
        }

    }
}
