using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorOPN
{
    public class Parenthesis : Operation
    {
        public Parenthesis() : base('(', 4)
        {
        }
        public override double ApplyTo(params double[] operands)
        {
            return double.NaN;
        }
    }
}
