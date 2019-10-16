using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorOPN
{
    public class Multiply : Operation
    {
        public Multiply() : base('*', 2)
        {
        }
        public override double ApplyTo(params double[] operands)
        {
            double result = operands[0] * operands[1];
            if (double.IsInfinity(result))
            {
                throw new ArgumentException("Final result is too big.");
            }
            return result;
        }
    }
}
