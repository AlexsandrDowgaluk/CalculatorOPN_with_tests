using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CalculatorOPN.SimpleOperations;


namespace CalculatorOPN.Tests
{
    public class RemainderTest
    {
        [Theory]
        [InlineData(-2, 3, -2.0)]
        [InlineData(3, -2, 1.0)]
        [InlineData(-1.5, 2, -1.5)]
        [InlineData(2, -1.5, 0.5)]
        [InlineData(0, -2, 0)]
        [InlineData(3, 2, 1.0)]
        [InlineData(2, 3, 2.0)]
        public void PossibleToRemainderValidParameters(double a, double b, double expected)
        {
            Remainder calc = new Remainder();
            double actual = calc.ApplyTo(a, b);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void RemainderDivisionWhenSecondNumberZerol()
        {
            Assert.Throws<ArgumentException>(RemainderDivision);
        }
        private void RemainderDivision()
        {
            Remainder calc = new Remainder();
            double actual = calc.ApplyTo(1, 0);
        }
    }
}
