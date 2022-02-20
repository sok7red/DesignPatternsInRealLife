using System.Collections.Generic;
using Adaptation_Builder_Immutable.Enums;
using SpecflowTests.TestModel;

namespace SpecflowTests.Context
{
    public class CreditInformationContext
    {
        private readonly Dictionary<CreditRatings, CreditQualitySteps> _ratings    = new Dictionary<CreditRatings, CreditQualitySteps>();
        private readonly Dictionary<CreditQualitySteps, double> _riskWeight    = new Dictionary<CreditQualitySteps, double>();
        
        public void MakeCreditObject(CreditInformationModel creditInformationModel)
        {
            _ratings.Add(creditInformationModel.Rating, creditInformationModel.CreditQuality);
            _riskWeight.Add(creditInformationModel.RiskWeightCreditQuality, creditInformationModel.RiskWeight);
        }

        public Dictionary<CreditRatings, CreditQualitySteps> Ratings => _ratings;
        public Dictionary<CreditQualitySteps, double> RiskWeight => _riskWeight;

    }
}
