using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CalculatorOPN.Tests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(2, 2, 3, 7)]
        [InlineData(5, 6, 7, 18)]
        public void PossibleToCalculateTrianglePerimetr(int part1, int part2, int part3, double expectedPerimetr)
        {
            Calculator calc = new Calculator();
            string str = part1.ToString()+ "+" + part2.ToString() + "+" + part3.ToString();
            double actualPerimetr = calc.Calculate(str);
            Assert.Equal(expectedPerimetr, actualPerimetr);
        }
        [Theory]
        [InlineData(5, 6, 7, 14.7)]
        public void PossibleToUseCalculatorForTriangleArea(int part1, int part2, int part3, double expectedArea)
        {
            int semiPerimetr = (part1 + part2 + part3) / 2;
            Calculator calc = new Calculator();
            string str = semiPerimetr.ToString() + "*(" + semiPerimetr.ToString() + "-" + part1.ToString() + ")*(" + semiPerimetr.ToString() + "-" + part2.ToString() + ")*(" + semiPerimetr.ToString() + "-" + part3.ToString() + ")";
            double tmp = calc.Calculate(str);
            double actualArea = Math.Sqrt(tmp);
            Assert.Equal(expectedArea, actualArea, 2);
        }
        [Theory]
        [InlineData("1+2", 3.0)]
        [InlineData("3+4*2/(1-5)^2", 3.5)]
        [InlineData("4^3", 64.0)]
        public void PossibleToDoCalculationsForValidExpressions(string str, double expected)
        {
            Calculator calc = new Calculator();
            double actual = calc.Calculate(str);
            Assert.Equal(expected, actual);
        }
    }
}
