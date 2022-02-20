using Adaptation_Builder_Immutable.Enums;

namespace Adaptation_Builder_Immutable.Interfaces
{
    public interface IBasicEntityObject
    {
        int CounterpartyId { get; set; }
        string CounterpartyName { get; set; }
        string NettingGroupName { get; set; }
        decimal ExposureAtDefault { get; set; }
        double RemainingMaturity { get; set; }

        double EffectiveMaturity { get; set; }

        CreditRatings CreditRating { get; set; }
    }
}
