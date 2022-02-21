using System;
using System.Collections.Generic;
using System.Text;
using Adaptation_Builder_Immutable.Enums;
using Adaptation_Builder_Immutable.Interfaces;

namespace Adaptation_Builder_Immutable.Domain
{
    public class SimpleAdaptor : EconomicEntityAdaptor
    {
        public SimpleAdaptor(Dictionary<CreditQualitySteps, double> riskWeights, Dictionary<CreditRatings, CreditQualitySteps> creditQuality, 
            IEnumerable<IEligibilityInformation> eligibilityInformation) : base(riskWeights, creditQuality, eligibilityInformation)
        {
        }
    }
}
