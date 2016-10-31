// Copyright (c) Costin Morariu. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Basics
{
    [TestFixture]
    public class SelectPrimeNumbersTests
    {
        [Test]
        [ExpectedException(
            typeof(ArgumentNullException),
            ExpectedMessage = "Value cannot be null.\r\nParameter name: numbers")]
        public void SelectPrimeNumbers_throws_for_null_input()
        {
            Functions.SelectPrimeNumbers(null);
        }

        [Test]
        public void SelectPrimeNumbers_returns_empty_for_empty_input()
        {
            var result = Functions.SelectPrimeNumbers(Enumerable.Empty<int>());

            Assert.IsEmpty(result);
        }

        // List of Prime Numbers up to 1000
        // 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 
        // 101, 103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199, 
        // 211, 223, 227, 229, 233, 239, 241, 251, 257, 263, 269, 271, 277, 281, 283, 293, 
        // 307, 311, 313, 317, 331, 337, 347, 349353, 359, 367, 373, 379, 383, 389, 397, 
        // 401, 409, 419, 421, 431, 433, 439, 443, 449, 457, 461, 463, 467, 479, 487, 491, 499, 
        // 503, 509, 521, 523, 541, 547, 557, 563, 569, 571, 577, 587, 593, 599, 
        // 601, 607, 613, 617, 619, 631, 641, 643, 647, 653, 659, 661, 673, 677, 683, 691, 
        // 701, 709, 719, 727, 733, 739, 743, 751, 757, 761, 769, 773, 787, 797, 
        // 809, 811, 821, 823, 827, 829, 839, 853, 857, 859, 863, 877, 881, 883, 887, 
        // 907, 911, 919, 929, 937, 941, 947, 953, 967, 971, 977, 983, 991, 997

        [Test]
        public void SelectPrimeNumbers_returns_enumeration_containing_only_prime_numbers()
        {
            var input = new List<int> {121, 61, -1, 3, 45, 50, 7, 100, 11, 1, 3, 344, 255, 349, 0};

            var result = Functions.SelectPrimeNumbers(input);

            CollectionAssert.AreEqual(new List<int> {61, 3, 7, 11, 3, 349}, result);
        }
    }
}