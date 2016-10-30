// Copyright (c) Costin Morariu. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using NUnit.Framework;

namespace Basics
{
    [TestFixture]
    public class FibonacciTests
    {
        private const string OutOfRangeMessage = 
            "Number must be between 1 and 47.\r\nParameter name: n";

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException), ExpectedMessage = OutOfRangeMessage)]
        public void CalculateNthFibonacciNumber_throws_for_input_less_than_1()
        {
            Functions.CalculateNthFibonacciNumber(0);
        }

        [Test]
        public void CalculateNthFibonacciNumber_returns_0_for_the_first_number()
        {
            var result = Functions.CalculateNthFibonacciNumber(1);

            Assert.AreEqual(0, result);
        }

        [Test]
        public void CalculateNthFibonacciNumber_returns_1_for_the_second_number()
        {
            var result = Functions.CalculateNthFibonacciNumber(2);

            Assert.AreEqual(1, result);
        }

        [TestCase(3, 1)]
        [TestCase(4, 2)]
        [TestCase(5, 3)]
        [TestCase(6, 5)]
        [TestCase(7, 8)]
        [TestCase(8, 13)]
        [TestCase(47, 1836311903)]
        public void CalculateNthFibonacciNumber_returns_the_sum_of_the_2_previous_numbers_in_sequence(
            int input, int expected)
        {
            var result = Functions.CalculateNthFibonacciNumber(input);

            Assert.AreEqual(expected, result);
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException), ExpectedMessage = OutOfRangeMessage)]
        public void CalculateNthFibonacciNumber_throws_for_input_greather_than_47()
        {
            Functions.CalculateNthFibonacciNumber(48);
        }
    }
}