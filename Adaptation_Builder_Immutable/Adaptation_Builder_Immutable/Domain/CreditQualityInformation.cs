using Adaptation_Builder_Immutable.Enums;

namespace Adaptation_Builder_Immutable.Domain
{
    public class CreditQualityInformation
    {
        public CreditQualityInformation(CreditRatings creditRating, CreditQualitySteps creditQualityStep)
        {
            CreditRating = creditRating;
            CreditQualityStep = creditQualityStep;
        }

        public CreditRatings CreditRating { get; }
        private CreditQualitySteps CreditQualityStep { get; }

        public (CreditRatings CreditRating, CreditQualitySteps CreditQualityStep) TheCreditQuality => new (CreditRating, CreditQualityStep);

    }
}
