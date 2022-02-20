using Adaptation_Builder_Immutable.Enums;

namespace Adaptation_Builder_Immutable.Domain
{
    public class RiskWeight
    {
        public RiskWeight(CreditQualitySteps creditQualityStep, double riskWeightValue)
        {
            CreditQualityStep = creditQualityStep;
            RiskWeightValue = riskWeightValue;
        }

        private CreditQualitySteps CreditQualityStep { get; }
        private double RiskWeightValue { get; }

        public (CreditQualitySteps CreditQualityStep, double value) TheRiskWeight => new (CreditQualityStep, RiskWeightValue);

    }
}
