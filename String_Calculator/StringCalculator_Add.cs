using System;
using Xunit;

namespace String_Calculator
{
    public class StringCalculator_Add
    {
        [Fact]
        public void Return0GivenEmptyString()
        {
            var calculator = new StringCalculator();
            var result = calculator.Add("");

            Assert.Equal(0, result);
        }
        [Theory]
        [InlineData("1", 1)]
        public void ReturnOneGivenStringWith1(string numbers, int expectedOutput)
        {
            var calculator = new StringCalculator();
            var result = calculator.Add("1");

            Assert.Equal(expectedOutput, result);
        }
    }
}
