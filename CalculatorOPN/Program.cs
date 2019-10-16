using System;

namespace CalculatorOPN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter expression.");
            Console.WriteLine("Only positive integer from 0 to 9 can be used. Also +, -, *, ,%,/, ^, (, ) can be used in expression.");
            string str = Console.ReadLine();
            Calculator calc = new Calculator();
            double result = calc.Calculate(str);
            Console.Clear();
            Console.WriteLine($"{str} = {result}");
        }
    }
}
