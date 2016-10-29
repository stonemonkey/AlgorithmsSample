// Copyright (c) Costin Morariu. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using NUnit.Framework;

namespace Basics
{
    [TestFixture]
    public class FibonacciTests
    {
        [Test]
        [ExpectedException(
            typeof(ArgumentOutOfRangeException),
            ExpectedMessage = "Specified argument was out of the range of valid values.\r\nParameter name: n")]
        public void CalculateNthFibonacciNumber_throws_for_negative_input()
        {
            Functions.CalculateNthFibonacciNumber(-1);
        }

        [TestCase(1, 0)]
        [TestCase(2, 1)]
        [TestCase(3, 1)]
        [TestCase(4, 2)]
        [TestCase(5, 3)]
        [TestCase(6, 5)]
        [TestCase(7, 8)]
        [TestCase(8, 13)]
        [TestCase(47, 1836311903)]
        public void CalculateNthFibonacciNumber_returns_corect_sequence_number_after_third_number_in_sequence(
            int input, int expected)
        {
            var result = Functions.CalculateNthFibonacciNumber(input);

            Assert.AreEqual(expected, result);
        }

        [Test]
        [ExpectedException(
            typeof(ArgumentOutOfRangeException),
            ExpectedMessage = "Specified argument was out of the range of valid values.\r\nParameter name: n")]
        public void CalculateNthFibonacciNumber_throws_for_input_with_result_over_int()
        {
            Functions.CalculateNthFibonacciNumber(48);
        }
    }

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

            if (n == 1)
                return 0;
            if (n == 2 || n == 3)
                return 1;

            int previous = 1;
            int current = 1;
            int next = 0;
            for (var i = 3; i < n; i++)
            {
                next = current + previous;
                previous = current;
                current = next;
            }

            return next;
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
