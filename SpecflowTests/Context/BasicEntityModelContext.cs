using System.Collections.Generic;
using SpecflowTests.ValidationModel;

namespace SpecflowTests.Context
{
    public class BasicEntityModelContext
    {
        private readonly List<BasicEntityValidationModel> _theObjects = new List<BasicEntityValidationModel>();
        
        public void AddNonImaEntities(BasicEntityValidationModel dealModel)
        {
            _theObjects.Add(dealModel);
        }

        public IEnumerable<BasicEntityValidationModel> GetNonImaEntities()
        {
            return _theObjects;
        }
    }
}
