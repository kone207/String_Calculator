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
                var newDelimiter = splitInput.First().Trim();

                numberString = String.Join('\n', splitInput.Skip(1));
                delimiters.Add(Convert.ToChar(newDelimiter));
            }

           
            var result = numbers.Split(delimiters.ToArray())
                .Select(s => int.Parse(s))
                .Sum();
            return result;
           
        }
    }
}
