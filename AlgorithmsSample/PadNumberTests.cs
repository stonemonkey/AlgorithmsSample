// Copyright (c) Costin Morariu. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using NUnit.Framework;

namespace Basics
{
    [TestFixture]
    public class PadNumberTests
    {
        private const string OutOfRangeMessage = 
            "Number must be between 1 and 99999.\r\nParameter name: number";

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException), ExpectedMessage = OutOfRangeMessage)]
        public void PadNumberWithZeroes_throws_for_negative_input()
        {
            Functions.PadNumberWithZeroes(-1);
        }

        [TestCase(0, "00000")]
        [TestCase(123, "00123")]
        [TestCase(99999, "99999")]
        public void PadNumberWithZeroes_returns_5_digits_for_valid_input(int input, string expected)
        {
            var result = Functions.PadNumberWithZeroes(input);

            Assert.AreEqual(expected, result);
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException), ExpectedMessage = OutOfRangeMessage)]
        public void PadNumberWithZeroes_throws_for_input_greather_then_99999()
        {
            Functions.PadNumberWithZeroes(100000);
        }
    }
}