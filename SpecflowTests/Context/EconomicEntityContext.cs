using System.Collections.Generic;
using Adaptation_Builder_Immutable.Interfaces;

namespace SpecflowTests.Context
{
    public class EconomicEntityContext
    {
        private readonly List<IEconomicEntity> _eEntity;

        public EconomicEntityContext()
        {
            _eEntity = new List<IEconomicEntity>();
        }

        public void AddDeal(IEconomicEntity eEntity)
        {
            _eEntity.Add(eEntity);
        }

        public IEnumerable<IEconomicEntity> EEntity => _eEntity;

    }
}
