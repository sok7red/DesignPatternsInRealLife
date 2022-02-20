using System.Collections.Generic;
using Adaptation_Builder_Immutable.Interfaces;

namespace SpecflowTests.Context
{
    public class EligibleCounterpartiesContext
    {
        private readonly List<IEligibilityInformation> TheEligibleModels = new List<IEligibilityInformation>();
        
        public void AddEECounterpartyModel(IEligibilityInformation counterpartyModel)
        {
            TheEligibleModels.Add(counterpartyModel);
        }

        public IEnumerable<IEligibilityInformation> GetEligibleCounterpartyInformation()
        {
            return TheEligibleModels;
        }

    }
}
