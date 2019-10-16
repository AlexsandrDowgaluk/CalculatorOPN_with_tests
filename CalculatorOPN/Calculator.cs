using System;
using System.Collections.Generic;

namespace CalculatorOPN
{
    public class Calculator
    {
        public double Calculate(string str)
        {
            string expression = new ArifmeticExpressionConverter(str).ToOPN();
            double result = new ExpressionCalculator().CalculateByOPN(expression);
            return result;
        }
    }  
}
