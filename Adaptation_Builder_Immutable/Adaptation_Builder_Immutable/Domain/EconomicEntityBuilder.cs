using System;
using Adaptation_Builder_Immutable.Enums;
using Adaptation_Builder_Immutable.Interfaces;

namespace Adaptation_Builder_Immutable.Domain
{
    class EconomicEntityBuilder
    {
        private int? _counterpartyId;
        public EconomicEntityBuilder SetCounterpartyId(int counterpartyId)
        {
            _counterpartyId = counterpartyId;
            return this;
        }

        private string _counterpartyName;
        public EconomicEntityBuilder SetCounterpartyName(string counterpartyName)
        {
            _counterpartyName = counterpartyName;
            return this;
        }

        private string _nettingPool;
        public EconomicEntityBuilder SetNettingPool(string nettingPool)
        {
            _nettingPool = nettingPool;
            return this;
        }

        private double _remainingMaturity;
        public EconomicEntityBuilder SetRemainingMaturity(double remainingMaturity)
        {
            _remainingMaturity = remainingMaturity;
            return this;
        }
        private double _effectiveMaturity;
        public EconomicEntityBuilder SetEffectiveMaturity(double effectiveMaturity)
        {
            _effectiveMaturity = effectiveMaturity;
            return this;
        }
        private decimal _exposureAtDefault;
        public EconomicEntityBuilder SetEAD(decimal exposureAtDefault)
        {
            _exposureAtDefault = exposureAtDefault;
            return this;
        }
        private CreditQualityInformation _creditRatings;
        public EconomicEntityBuilder SetCreditRatings(CreditRatings creditRatingMoodys, CreditQualitySteps creditQualityMoodys)
        {
            _creditRatings = new CreditQualityInformation(creditRatingMoodys, creditQualityMoodys);
            
            return this;
        }

        private bool _isEligible;
        public EconomicEntityBuilder SetIsEligible(bool isEligible)
        {
            _isEligible = isEligible;
            return this;
        }
        private RiskWeight _riskWeight;
        public EconomicEntityBuilder SetRiskWeight(CreditQualitySteps creditQuality, double weight)
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

            return new EconomicEntity(
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
