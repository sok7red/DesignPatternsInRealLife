using System;
using System.Collections.Generic;
using System.Text;
using Adaptation_Builder_Immutable.Interfaces;

namespace Adaptation_Builder_Immutable.Domain.Calculation
{
    public class RiskCalculator : Calculator
    {
        private IEnumerable<IEconomicEntity> _economicEntities;

        public RiskCalculator(IEnumerable<IEconomicEntity> economicEntities)
        {
            _economicEntities = economicEntities;
        }

        public override void Calculate()
        {
            throw new NotImplementedException();
        }
    }
}
