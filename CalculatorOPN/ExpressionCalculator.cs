using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorOPN
{
    public class ExpressionCalculator
    {
        private OperactionService _operationService;
        public ExpressionCalculator() : this(new OperactionService())
        {

        }
        protected ExpressionCalculator(OperactionService operationService)
        {
            _operationService = operationService;
        }
        public double CalculateByOPN(string expressionOPN)
        {
            Stack<string> calculationsStack = new Stack<string>();

            for (int i = 0; i < expressionOPN.Length; i++)
            {
                if (Char.IsDigit(expressionOPN[i]))
                {
                    calculationsStack.Push(expressionOPN[i].ToString());
                    continue;
                }
                if (_operationService.GetOperationByName(expressionOPN[i]) != null)
                {
                    double b = Convert.ToDouble(calculationsStack.Pop());
                    double a = Convert.ToDouble(calculationsStack.Pop());
                    double result = _operationService.GetOperationByName(expressionOPN[i]).ApplyTo(a, b);
                    calculationsStack.Push(result.ToString());
                    continue;
                }
            }
            return Convert.ToDouble(calculationsStack.Pop());
        }
    }
}
