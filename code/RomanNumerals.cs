using System;
using System.Collections.Generic;

namespace katas
{
    public static class RomanNumeralsConverter
    {
        private const int MAXIMUM_ROMAN = 4000;
        private const int MINIMUM_ROMAN = 0;
        private static SortedDictionary<int, string> numerals = new SortedDictionary<int, string>(new DescendingComparer<int>())
        {
            {1, "I"},
            {4, "IV"},
            {5, "V"},
            {9, "IX"},
            {10, "X"},
            {40, "XL"},
            {50, "L"},
            {90, "XC"},
            {100, "C"},
            {400, "CD"},
            {500, "D"},
            {900, "CM"},
            {1000, "M"}
        };

        public static string Convert(int input)
        {
            if (input <= MINIMUM_ROMAN || input >= MAXIMUM_ROMAN)
                throw new RomanNumeralsConverterException();

            if(numerals.TryGetValue(input, out var numeral))
                return numeral;
            else
                return ConvertComplexNumber(ref input);
        }

        private static string ConvertComplexNumber(ref int input)
        {
            var result = String.Empty;
            foreach (var num in numerals)
            {
                while (input - num.Key >= 0)
                {
                    result += num.Value;
                    input = input - num.Key;
                }
            }
            return result;
        }
    }

    public class RomanNumeralsConverterException: Exception {}

    class DescendingComparer<T> : IComparer<T> where T : IComparable<T> {
        public int Compare(T x, T y) {
            return y.CompareTo(x);
        }
    }
}