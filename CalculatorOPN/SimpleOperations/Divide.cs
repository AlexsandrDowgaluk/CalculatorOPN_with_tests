using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorOPN
{
    public class Divide : Operation
    {
        public Divide() : base('/', 2)
        {
        }
        public override double ApplyTo(params double[] operands)
        {
            if (operands[1] == 0.0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            double result = operands[0] / operands[1];
            if (double.IsInfinity(result))
            {
                throw new ArgumentException("Final result is too big.");
            }
            return result;
        }
    }
}
