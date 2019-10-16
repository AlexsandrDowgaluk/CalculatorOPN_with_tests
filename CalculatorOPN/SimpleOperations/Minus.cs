
namespace CalculatorOPN
{
    public class Minus : Operation
    {
        public Minus() : base('-', 3)
        {
        }
        public override double ApplyTo(params double[] operands)
        {
            double result = operands[0] - operands[1];

            return result;
        }
    }
}
