using System;
using Xunit;

namespace String_Calculator
{
    public class StringCalculator_Add
    {
        private StringCalculator _calculator = new StringCalculator();

        [Fact]
        public void Return0GivenEmptyString()
        {
            var result = _calculator.Add("");

            Assert.Equal(0, result);
        }
        [Theory]
        [InlineData("1", 1)]
        [InlineData("2", 2)]
        public void Return1GivenStringWithOne(string numbers, int expectedOutput)
        {
            var calculator = new StringCalculator();
            var result = _calculator.Add(numbers);

            Assert.Equal(expectedOutput, result);
        }

        [Theory]
        [InlineData("1,2", 3)]
        [InlineData("2,3", 5)]
        public void ReturnSumGivenStringWithTwoCommaSeparatedNumbers(string numbers, int expectedOutput)
        {
            var calculator = new StringCalculator();
            var result = _calculator.Add(numbers);

            Assert.Equal(expectedOutput, result);
        }
        [Theory]
        [InlineData("1,2,3", 6)]
        [InlineData("2,3,4", 9)]
        public void ReturnSumGivenStringWithThreeCommaSeparatedNumbers(string numbers, int expectedOutput)
        {
            var calculator = new StringCalculator();
            var result = _calculator.Add(numbers);

            Assert.Equal(expectedOutput, result);
        }
        [Theory]
        [InlineData("1\n2,3", 6)]
        [InlineData("1\n2\n3", 6)]
        [InlineData("1,2\n3", 6)]
        
        public void ReturnSumGivenStringWithThreeCommaOrNewlineSeparatedNumbers(string numbers, int expectedOutput)
        {
            var calculator = new StringCalculator();
            var result = _calculator.Add(numbers);

            Assert.Equal(expectedOutput, result);
        }
        [Theory]
        [InlineData("//;\n1;2;3", 6)]
        [InlineData("1\n2\n3", 6)]
        [InlineData("1,2\n3", 6)]

        public void ReturnSumGivenStringWithCustomDelimeter(string numbers, int expectedOutput)
        {
            var calculator = new StringCalculator();
            var result = _calculator.Add(numbers);

            Assert.Equal(expectedOutput, result);
        }


    }
}

