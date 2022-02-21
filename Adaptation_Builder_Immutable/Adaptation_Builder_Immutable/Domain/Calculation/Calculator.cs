using System;
using System.Collections.Generic;
using System.Text;
using Adaptation_Builder_Immutable.Interfaces.Calculation;

namespace Adaptation_Builder_Immutable.Domain.Calculation
{
    public abstract class Calculator : ICalculate
    {
        public abstract void Calculate();
    }
}
