using Calculator.Domain;
using System;
using Xunit;

namespace Calculator.Tests
{
    public class CalculatorTest
    {
        public CalculatorTest()
        {
        }

        [Theory]
        [InlineData(1, 2, 3, 6)]
        [InlineData(0, 0, 3, 3)]
        [InlineData(-1, 0, 1, 0)]
        public void ShouldAdd_Correctly(params int[] inputs)
        {
            var output = CalculatorLib.Add(inputs[..^1]);
            Assert.Equal(inputs[^1], output);
        }

        [Theory]
        [InlineData(10, 2, 3, 5)]
        [InlineData(0, 0, 3, -3)]
        [InlineData(-1, 0, 1, -2)]
        public void ShouldSubstract_Correctly(params int[] inputs)
        {
            var output = CalculatorLib.Substract(inputs[..^1]);
            Assert.Equal(inputs[^1], output);
        }


        [Theory]
        [InlineData(1, 2, 3, 6)]
        [InlineData(0, 0, 3, 0)]
        [InlineData(-1, 2, 3, -6)]
        public void ShouldMultiply_Correctly(params int[] inputs)
        {
            var output = CalculatorLib.Multiply(inputs[..^1]);
            Assert.Equal(inputs[^1], output);
        }


        [Theory]
        [InlineData(16.0, 4.0, 4.0)]
        [InlineData(5.0, 2.0, 2.5)]
        [InlineData(10.0, 10.0, 1.0)]
        [InlineData(-10.0, 2.0, -5.0)]
        public void ShouldDivide_Correctly(params double[] inputs)
        {
            var output = CalculatorLib.Divide(inputs[..^1]);
            Assert.Equal(inputs[^1], output);
        }


        [Theory]
        [InlineData(120, 4, 30.0, 30.0, 30.0, 30.0)]
        [InlineData(100, 3, 33.33, 33.33, 33.33)]
        public void ShouldSplitEq_Correctly(int value, int divider, params double[] expected)
        {
            var output = CalculatorLib.SplitEq(value, divider);
            Assert.Equal(expected, output);
        }


        [Theory]
        [InlineData(1, 2, 3, 6)]
        [InlineData(0, 0, 3, 3)]
        [InlineData(-1, 0, 1, 0)]
        public void ShouldSplitNum_Correctly(params int[] inputs)
        {
            var output = CalculatorLib.SplitNum(inputs[..^1]);
            Assert.Equal(inputs[^1], output);
        }
    }
}
