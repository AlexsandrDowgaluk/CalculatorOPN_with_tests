using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CalculatorOPN.Tests
{
    public class MultiplyTests
    {
        [Fact]
        public void ArgumentExceptionOccursWhenMultiplyingOfLargeNumbers()
        {
            Assert.Throws<ArgumentException>(ReceiveTooBigResult);
        }
        private void ReceiveTooBigResult()
        {
            Multiply calc = new Multiply();
            calc.ApplyTo(double.MaxValue, double.MaxValue);
        }
        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(0, 28.5, 0.0)]
        [InlineData(2.5, 0, 0.0)]
        [InlineData(2.5, 2.5, 6.25)]
        [InlineData(-2, 6.3, -12.6)]
        [InlineData(2.5, -3, -7.5)]
        public void PossibleToMultiplyValidParameters(double a, double b, double expected)
        {
            Multiply calc = new Multiply();
            double actual = calc.ApplyTo(a, b);
            Assert.Equal(expected, actual);
        }
    }
}
