using System;

namespace katas
{
    public class StringCalculator
    {
        private char[] separators = {',', '\n'};
        public int Add(string input)
        {
            if (input.Length == 0)
                return 0;

            var inputArr = input.Split(separators);
            var sum = 0;

            foreach (var inp in inputArr)
            {
                sum = AddParsedNumber(sum, inp);
            }

            return sum;
        }

        private static int AddParsedNumber(int sum, string inp)
        {
            var parsedNumber = Int32.Parse(inp);

            if (parsedNumber < 0)
                throw new Exception("Negatives are not allowed");

            if (parsedNumber > 1000)
                parsedNumber = 0;

            sum += parsedNumber;
            return sum;
        }
    }
}