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
        [InlineData("1,2", 3)]
        [InlineData("2,3", 5)]

        public void ReturnSumGivenStringWithTwoCommaSeparatedNumbers(string numbers, int expectedOutput)
        {
            var calculator = new StringCalculator();
            var result = calculator.Add(numbers);

            Assert.Equal(expectedOutput, result);
        }
    }
}
