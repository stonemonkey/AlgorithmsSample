// Copyright (c) Costin Morariu. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Basics
{
    public class Functions
    {
        /// <summary>
        /// Reverses a string.
        /// </summary>
        /// <param name="value">String to reverse.</param>
        /// <returns>Reversed string.</returns>
        public static string ReverseString(string value)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));

            if (value == string.Empty)
                return string.Empty;

            var elements = SplitTextElements(value);
            return Concat(elements.Reverse());
        }

        private static string Concat(IEnumerable<string> elements)
        {
            return string.Concat(elements);
        }

        private static IEnumerable<string> SplitTextElements(string input)
        {
            var enumerator = StringInfo.GetTextElementEnumerator(input);
            while (enumerator.MoveNext())
            {
                yield return enumerator.GetTextElement();
            }
        }

        /// <summary>
        /// Calculates the Nth fibonacci number.
        /// </summary>
        /// <param name="n">Fibonacci number to calculate.</param>
        /// <returns>The nth fibonacci number.</returns>
        public static int CalculateNthFibonacciNumber(int n)
        {
            if (n < 1 || n > 47)
                throw new ArgumentOutOfRangeException(
                    nameof(n), "Number must be between 1 and 47.");

            int index = n - 1;
            return FibonacciSequence(index).Skip(index).First();
        }

        private static IEnumerable<int> FibonacciSequence(int lastIndex)
        {
            yield return 0;
            yield return 1;
            yield return 1;

            int current = 1;
            int previous = 1;
            for (var i = 2; i < lastIndex; i++)
            {
                var next = current + previous;
                previous = current;
                current = next;

                yield return next;
            }
        }

        /// <summary>
        /// Pads a number with up to four zeroes.
        /// </summary>
        /// <param name="number">Number to pad.</param>
        /// <returns>Zero-padded number.</returns>
        /// <remarks>Can only pad unsigned numbers up to 99999.</remarks>
        public static string PadNumberWithZeroes(int number)
        {
            if (number < 0 || number > 99999)
                throw new ArgumentOutOfRangeException(
                    nameof(number), "Number must be between 1 and 99999.");

            return number.ToString("D5");
        }

        /// <summary>
        /// Determines if a year is a leap year.
        /// </summary>
        /// <param name="year">Year to determine.</param>
        /// <returns>True if leap year, false if not.</returns>
        public static bool IsLeapYear(int year)
        {
            if (year < 1)
                throw new ArgumentOutOfRangeException(
                    nameof(year), "Year must be between 1 and int.MaxValue.");

            return (year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0);
        }

        // I assume the return value should be the nth largest number from the input list not the
        // third largest number and even the summary says "range" I assume it is meant to include 
        // non distinct list of values since the input is a List<int>.

        /// <summary>
        /// Find the N:th largest number in a range of numbers.
        /// </summary>
        /// <param name="numbers">List of integers.</param>
        /// <returns>The third largest number in list.</returns>
        public static int FindNthLargestNumber(List<int> numbers, int nthLargestNumber)
        {
            if (numbers == null)
                throw new ArgumentNullException(nameof(numbers));
            if (nthLargestNumber < 1)
                throw new ArgumentOutOfRangeException(
                    nameof(nthLargestNumber),
                    "Nth largest number must be greater than 0.");
            if (nthLargestNumber > numbers.Count)
                throw new ArgumentException(
                    "Nth largest number must be less or equal than numbers list count.");

            var sortedNumbers = numbers.OrderByDescending(x => x);

            return sortedNumbers.Skip(nthLargestNumber - 1).First();
        }

        /// <summary>
        /// Selects the prime numbers from a enumerable with numbers.
        /// </summary>
        /// <param name="numbers">Enumerable with numbers.</param>
        /// <returns>An enumerable with only prime numbers.</returns>
        public static IEnumerable<int> SelectPrimeNumbers(IEnumerable<int> numbers)
        {
            if (numbers == null)
                throw new ArgumentNullException(nameof(numbers));

            return numbers.Where(IsPrime);
        }

        private static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;
            if (number == 2)
                return true;
            if (number % 2 == 0)
                return false;

            var sqrt = Math.Sqrt(number);
            for (var i = 3; i <= sqrt; i += 2)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

        /// <summary>
        /// Determines if the bit pattern of value the same if you reverse it.
        /// </summary>
        /// <param name="value">Value to inspect.</param>
        /// <returns>True if the bit value is a palindrome otherwise false.</returns>
        public static bool IsPalindrome(int value)
        {
            var reversed = ReverseBitwiseNumber(value);

            return value == reversed;
        }

        private static int ReverseBitwiseNumber(int value)
        {
            uint reversed = 0;
            uint number = (uint) value;
            while (number != 0)
            {
                uint bit = number & 1;
                reversed = reversed << 1 | bit;
                number = number >> 1;
            } 

            return (int) reversed;
        }

        /// <summary>
        /// Counts all bits in an int value.
        /// </summary>
        /// <param name="value">Integer value to count bits in.</param>
        /// <returns>Number of bits in integer value.</returns>
        public static int CountSetBits(int value)
        {
            int count = 0;
            int number = value;
            while (number != 0)
            {
                count++;
                number = number & (number - 1);
            }

            return count;
        }
    }
}
