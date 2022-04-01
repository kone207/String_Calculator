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
    }
}
