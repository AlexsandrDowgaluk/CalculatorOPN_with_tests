using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorOPN
{
    public class ArifmeticExpressionConverter
    {
        private string _expression;
        private OperactionService _operationService;
        public ArifmeticExpressionConverter(string expression) : this(new OperactionService())
        {
            _expression = expression;
        }
        protected ArifmeticExpressionConverter(OperactionService operationService)
        {
            _operationService = operationService;
        }
        public string ToOPN()
        {
            string finalOPNExpression = String.Empty;
            Stack<char> operationsStack = new Stack<char>();

            for (int i = 0; i < _expression.Length; i++)
            {
                if (Char.IsDigit(_expression[i]))
                {
                    finalOPNExpression += _expression[i];
                    continue;
                }
                if (_expression[i] == '(')
                {
                    operationsStack.Push(_expression[i]);
                    continue;
                }
                if (_expression[i] == ')')
                {
                    while (operationsStack.Peek() != '(')
                    {
                        finalOPNExpression += operationsStack.Pop();
                    }
                    operationsStack.Pop();
                    continue;
                }
                if (_operationService.GetOperationByName(_expression[i]) != null)
                {
                    while ((operationsStack.Count > 0) && (_operationService.GetOperationByName(operationsStack.Peek()).Priority <= _operationService.GetOperationByName(_expression[i]).Priority))
                    {
                        finalOPNExpression += operationsStack.Pop();
                    }
                    operationsStack.Push(_expression[i]);
                    continue;
                }
            }

            while (operationsStack.Count > 0)
            {
                finalOPNExpression += operationsStack.Pop();
            }
            return finalOPNExpression;
        }
    }
}
