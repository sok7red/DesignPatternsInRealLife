using Adaptation_Builder_Immutable.Interfaces;

namespace Adaptation_Builder_Immutable.Domain
{
    public class EconomicEntityEligibilityInformation : IEligibilityInformation
    {
        public string CounterpartyName { get; set; }
        public string NettingGroupName { get; set; }
    }   
}
