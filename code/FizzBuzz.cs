using System;

namespace katas
{
    public class FizzBuzz
    {
        public FizzBuzz()
        {
        }

        public string[] Interpret(int len)
        {
            var result = new string[len];

            for (var i = 0; i < len; i++) {
                var numberToBeTested = i + 1;
                
                if (numberToBeTested % 15 == 0)
                    result[i] = "FizzBuzz";
                else if (numberToBeTested % 3 == 0)
                    result[i] = "Fizz";
                else if (numberToBeTested % 5 == 0)
                    result[i] = "Buzz";
                else 
                    result[i] = numberToBeTested.ToString();
            }

            return result;
        }
    }
}