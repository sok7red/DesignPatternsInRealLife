using Adaptation_Builder_Immutable.Enums;

namespace SpecflowTests.TestModel
{
    interface ICreditInformationModel
    {
       CreditRatings Rating { get; set; }
       CreditQualitySteps CreditQuality { get; set; }

       CreditQualitySteps RiskWeightCreditQuality { get; set; }
       double RiskWeight { get; set; }
    }
}
