// Copyright (c) Costin Morariu. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using NUnit.Framework;

namespace Basics
{
    [TestFixture]
    public class PalindromeTests
    {
        [TestCase(0x0, Description = "0")]
        [TestCase(0x3, Description = "11")]
        [TestCase(0x5, Description = "101")]
        [TestCase(0x7, Description = "111")]
        [TestCase(0x9, Description = "1001")]
        [TestCase(0xF, Description = "1111")]
        [TestCase(0x40000001, Description = "1000000000000000000000000000001")]
        [TestCase(-1,         Description = "11111111111111111111111111111111")]
        public void IsPalindrome_returns_true_for_input_with_palindrome_pattern(int input)
        {
            Assert.IsTrue(Functions.IsPalindrome(input));
        }

        [TestCase(0x2, Description = "10")]
        [TestCase(0x4, Description = "100")]
        [TestCase(0x6, Description = "110")]
        [TestCase(0x8, Description = "1000")]
        [TestCase(0xA, Description = "1010")]
        [TestCase(0xB, Description = "1011")]
        [TestCase(0xC, Description = "1100")]
        [TestCase(0xD, Description = "1101")]
        [TestCase(0xE, Description = "1110")]
        [TestCase(0x40000002, Description = "1000000000000000000000000000010")]
        [TestCase(-2,         Description = "11111111111111111111111111111110")]
        public void IsPalindrome_returns_false_for_input_with_non_palindrome_pattern(int input)
        {
            Assert.IsFalse(Functions.IsPalindrome(input));
        }
    }
}