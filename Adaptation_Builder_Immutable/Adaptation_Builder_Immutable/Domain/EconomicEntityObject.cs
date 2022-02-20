using System;
using Adaptation_Builder_Immutable.Interfaces;
using Ardalis.GuardClauses;

namespace Adaptation_Builder_Immutable.Domain
{
    public class EconomicEntityObject : IEconomicEntity
    {
        public EconomicEntityObject(int counterpartyId, string counterpartyName, string nettingGroupName, double effectiveMaturity, double remainingMaturity,
            decimal exposureAtDefault, CreditQualityInformation creditRatings, bool isEligible, RiskWeight riskWeight)
        {
            Guard.Against.NegativeOrZero(counterpartyId, nameof(counterpartyId));
            Guard.Against.NullOrEmpty(counterpartyName,nameof(counterpartyName));
            Guard.Against.NullOrEmpty(nettingGroupName, nameof(nettingGroupName));
            Guard.Against.NegativeOrZero(effectiveMaturity, nameof(effectiveMaturity));
            Guard.Against.NegativeOrZero(remainingMaturity, nameof(remainingMaturity));
            Guard.Against.NegativeOrZero(exposureAtDefault, nameof(exposureAtDefault));
            Guard.Against.Null(creditRatings, nameof(creditRatings));
            Guard.Against.Null(riskWeight, nameof(riskWeight));
            Guard.Against.Null(riskWeight, nameof(riskWeight));

            CounterpartyId = counterpartyId;
            CounterpartyName = counterpartyName;
            NettingGroupName = nettingGroupName;
            ExposureAtDefault = exposureAtDefault;
            CreditRatings = creditRatings;
            EffectiveMaturity = effectiveMaturity;
            RemainingMaturity = remainingMaturity;

            IsEligible = isEligible;
            RiskWeight = riskWeight;
        }

        public int CounterpartyId { get; }

        public string CounterpartyName { get; }

        public string NettingGroupName { get; }

        public double EffectiveMaturity { get; }

        public double EffectiveMaturityCapped => Math.Min(RemainingMaturity, EffectiveMaturity);

        public double RemainingMaturity { get; }

        public decimal ExposureAtDefault { get; }

        public CreditQualityInformation CreditRatings { get; }

        public bool IsEligible { get; }

        public RiskWeight RiskWeight { get; }
    }
}
