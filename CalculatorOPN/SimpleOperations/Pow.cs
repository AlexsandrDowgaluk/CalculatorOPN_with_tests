using System;

namespace CalculatorOPN
{
    public class Pow : Operation
    {
        public Pow() : base('^', 1)
        {
        }
        public override double ApplyTo(params double[] operands)
        {
            double result = Math.Pow(operands[0], operands[1]);
            if (double.IsInfinity(result))
            {
                throw new ArgumentException("Final result is too big.");
            }
            return result;
        }
    }
}
