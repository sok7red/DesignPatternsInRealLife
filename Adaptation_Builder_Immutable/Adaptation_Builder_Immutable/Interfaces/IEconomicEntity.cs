using Adaptation_Builder_Immutable.Domain;

namespace Adaptation_Builder_Immutable.Interfaces
{
    public interface IEconomicEntity
    {
        int CounterpartyId { get; }

        string CounterpartyName { get; }

        string NettingGroupName { get; }

        CreditQualityInformation CreditRatings { get; }

        double EffectiveMaturity { get; }
        double EffectiveMaturityCapped { get; }

        double RemainingMaturity { get; }
        decimal ExposureAtDefault { get; }
        bool IsEligible { get; }

        RiskWeight RiskWeight { get; }
    }
}
