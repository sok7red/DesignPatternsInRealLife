using Adaptation_Builder_Immutable.Enums;
using Adaptation_Builder_Immutable.Interfaces;

namespace SpecflowTests.ValidationModel
{
    public class BasicEntityValidationModel : IBasicEntityObject
    {
        public int CounterpartyId { get; set; }
        public string CounterpartyName { get; set; }
        public string NettingGroupName { get; set; }
        public double RemainingMaturity { get; set; }
        public double EffectiveMaturity { get; set; }
        public CreditRatings CreditRating { get; set; }
        public decimal ExposureAtDefault { get; set; }
    }
}
