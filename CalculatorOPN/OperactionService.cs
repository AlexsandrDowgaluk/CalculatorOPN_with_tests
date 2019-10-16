using CalculatorOPN.SimpleOperations;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorOPN
{
    public class OperactionService
    {
        private Operation[] _supportedOperations;
        public OperactionService()
        {
            _supportedOperations = new Operation[] {
                new Plus(),
                new Minus(),
                new Multiply(),
                new Divide(),
                new Pow(),
                new Parenthesis(),
                new Remainder()

            };
        }
        public Operation GetOperationByName(char operationSymbol)
        {
            foreach (var op in _supportedOperations)
            {
                if (op.Symbol == operationSymbol)
                {
                    return op;
                }
            }
            return null;
        }

    }
}

