using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorOPN
{
    public abstract class Operation
    {
        protected Operation(char symbol, int priority)
        {
            Symbol = symbol;
            Priority = priority;
        }
        public char Symbol { get; }
        public int Priority { get; }

        public abstract double ApplyTo(params double[] operands);
    }
}
