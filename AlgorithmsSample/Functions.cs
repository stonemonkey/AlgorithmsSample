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
        #region ReverseString
        
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

        #endregion

        /// <summary>
        /// Calculates the Nth fibonacci number.
        /// </summary>
        /// <param name="n">Fibonacci number to calculate.</param>
        /// <returns>The nth fibonacci number.</returns>
        public static int CalculateNthFibonacciNumber(int n)
        {
            if (n < 1 || n > 47)
                throw new ArgumentOutOfRangeException(nameof(n));

            var index = n - 1;
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
            throw new NotImplementedException(); 
        }

        /// <summary>
        /// Determines if a year is a leap year.
        /// </summary>
        /// <param name="year">Year to determine.</param>
        /// <returns>True if leap year, false if not.</returns>
        public static bool IsLeapYear(int year)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Find the N:th largest number in a range of numbers.
        /// </summary>
        /// <param name="numbers">List of integers.</param>
        /// <returns>The third largest number in list.</returns>
        public static int FindNthLargestNumber(List<int> numbers, int nthLargestNumber)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Selects the prime numbers from a enumerable with numbers.
        /// </summary>
        /// <param name="numbers">Enumerable with numbers.</param>
        /// <returns>An enumerable with only prime numbers.</returns>
        public static IEnumerable<int> SelectPrimeNumbers(IEnumerable<int> numbers)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Determines if the bit pattern of value the same if you reverse it.
        /// </summary>
        /// <param name="value">Value to inspect.</param>
        /// <returns>True if the bit value is a palindrome otherwise false.</returns>
        public static bool IsPalindrome(int value)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Counts all bits in an int value.
        /// </summary>
        /// <param name="value">Integer value to count bits in.</param>
        /// <returns>Number of bits in integer value.</returns>
        public static int CountSetBits(int value)
        {
            throw new NotImplementedException();
        }
    }
}
