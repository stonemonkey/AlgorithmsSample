// Copyright (c) Costin Morariu. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using NUnit.Framework;

namespace Basics
{
    [TestFixture]
    public class CountBitsTests
    {
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(3, 2)]
        [TestCase(13, 3)]
        [TestCase(-2, 31)]
        [TestCase(-1, 32)]
        public void CountSetBits_returns_the_number_of_1_bits_from_input(int input, int expected)
        {
            var result = Functions.CountSetBits(input);

            Assert.AreEqual(expected, result);
        }
    }
}