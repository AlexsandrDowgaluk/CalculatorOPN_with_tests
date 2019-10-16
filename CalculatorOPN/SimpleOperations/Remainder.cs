using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorOPN.SimpleOperations
{
   public class Remainder: Operation { 
    
        public Remainder() : base('%', 2)
        {
        }
        public override double ApplyTo(params double[] operands)
        {
            if (operands[1] == 0) throw new ArgumentException("Division by zero is not possible");
            double result = operands[0] % operands[1];
            return result;
            
        }
    }
}
