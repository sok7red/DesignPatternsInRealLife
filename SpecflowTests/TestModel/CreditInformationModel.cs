using Adaptation_Builder_Immutable.Enums;

namespace SpecflowTests.TestModel
{
    public class CreditInformationModel : ICreditInformationModel
    {
        public CreditRatings Rating { get; set; }
        public CreditQualitySteps CreditQuality { get; set; }

        public CreditQualitySteps RiskWeightCreditQuality { get; set; }
        public double RiskWeight { get; set; }

    }
}
