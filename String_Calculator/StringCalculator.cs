using System;
using System.Linq;
using System.Collections.Generic;

namespace String_Calculator
{
    public class StringCalculator
    {
        internal object Add(string numbers)
        {
            var delimiters = new List<char> { ',', '\n' };
            if (String.IsNullOrEmpty(numbers)) return 0;

            string numberString = numbers;
            if (numbers.StartsWith("//"))
            {
                var splitInput = numbers.Split('\n');
                var newDelimiter = splitInput.First().Trim('/');

                numberString = String.Join('\n', splitInput.Skip(1));
                delimiters.Add(Convert.ToChar(newDelimiter));
            }
            var numberList = numberString.Split(delimiters.ToArray()).Select(s => int.Parse(s));
            var negatives = numberList.Where(n => n < 0);

            if (negatives.Any())
            {
                string negativeString = String.Join(',', negatives.Select(n => n.ToString()));
                throw new Exception($"Negatives not allowed: {negativeString}");
            }
            var result = numberList
                .Sum();

            return result;
           
        }
    }
}
