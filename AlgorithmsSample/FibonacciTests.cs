// Copyright (c) Costin Morariu. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
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
        public void CalculateNthFibonacciNumber_returns_number_in_sequence_for_valid_input(
            int input, int expected)
        {
            var result = Functions.CalculateNthFibonacciNumber(input);

            Assert.AreEqual(expected, result);
        }

        [Test]
        [ExpectedException(
            typeof(ArgumentOutOfRangeException),
            ExpectedMessage = "Specified argument was out of the range of valid values.\r\nParameter name: n")]
        public void CalculateNthFibonacciNumber_throws_for_input_with_result_over_max_int()
        {
            Functions.CalculateNthFibonacciNumber(48);
        }
    }
}