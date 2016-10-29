// Copyright (c) Costin Morariu. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Basics
{
    [TestFixture]
    public class ReverseStringTests
    {
        [Test]
        [ExpectedException(
            typeof(ArgumentNullException),
            ExpectedMessage = "Value cannot be null.\r\nParameter name: value")]
        public void ReverseString_throws_for_null_input()
        {
            Functions.ReverseString(null);
        }

        [Test]
        public void ReverseString_returns_empty_for_empty_input()
        {
            var result = Functions.ReverseString(string.Empty);

            Assert.AreEqual(string.Empty, result);
        }

        [Test]
        public void ReverseString_returns_single_char_string_for_single_char_input()
        {
            var result = Functions.ReverseString("a");

            Assert.AreEqual("a", result);
        }

        [Test]
        public void ReverseString_returns_string_with_chars_in_reversed_order()
        {
            var result = Functions.ReverseString("12");

            Assert.AreEqual("21", result);
        }
    }

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

            var array = value.ToCharArray();
            var reversedArray = array.Reverse().ToArray();

            return new string(reversedArray);
        }

        /// <summary>
        /// Calculates the Nth fibonacci number.
        /// </summary>
        /// <param name="n">Fibonacci number to calculate.</param>
        /// <returns>The nth fibonacci number.</returns>
        public static int CalculateNthFibonacciNumber(int n)
        {
            throw new NotImplementedException();
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
