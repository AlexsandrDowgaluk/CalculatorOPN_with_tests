using System;
using Xunit;

namespace CalculatorOPN.Tests
{
    public class DivideTests
    {
        [Fact]
        public void DivideByZeroExceptionOccursWhenDivideByZero()
        {
            Assert.Throws<DivideByZeroException>(DivideByZero);
        }

        private void DivideByZero()
        {
            Divide calc = new Divide();
            calc.ApplyTo(1, 0);
        }
        [Theory]
        [InlineData(1, 2, 0.5)]
        [InlineData(-1.24, 2, -0.62)]
        [InlineData(6.8, -2, -3.4)]
        public void PossibleToSumarizeValidParameters(double a, double b, double expected)
        {
            Divide calc = new Divide();
            double actual = calc.ApplyTo(a, b);
            Assert.Equal(expected, actual);
        }
    }
}
