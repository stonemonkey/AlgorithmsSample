// Copyright (c) Costin Morariu. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using NUnit.Framework;

namespace Basics
{
    [TestFixture]
    public class GregorianLeapYearTests
    {
        // Every year that is exactly divisible by four is a leap year, except for years that are 
        // exactly divisible by 100, but these centurial years are leap years if they are exactly 
        // divisible by 400. For example, the years 1700, 1800, and 1900 are not leap years, but 
        // the years 1600 and 2000 are. https://en.wikipedia.org/wiki/Leap_year#Gregorian_calendar

        [Test]
        [ExpectedException(
            typeof(ArgumentOutOfRangeException), 
            ExpectedMessage = "Year must be between 1 and int.MaxValue.\r\nParameter name: year")]
        public void IsLeapYear_throws_for_input_less_than_1()
        {
            Functions.IsLeapYear(0);
        }

        [TestCase(4)]
        [TestCase(44444)]
        public void IsLeapYear_returns_true_for_years_divisible_by_4(int input)
        {
            var result = Functions.IsLeapYear(input);

            Assert.IsTrue(result);
        }

        [TestCase(3)]
        [TestCase(int.MaxValue)]
        public void IsLeapYear_returns_false_for_years_not_divisible_by_4(int input)
        {
            var result = Functions.IsLeapYear(input);

            Assert.IsFalse(result);
        }

        [TestCase(100)]
        [TestCase(1800)]
        [TestCase(11100)]
        public void IsLeapYear_returns_false_for_century_years(int input)
        {
            var result = Functions.IsLeapYear(input);

            Assert.IsFalse(result);
        }

        [TestCase(400)]
        [TestCase(2000)]
        [TestCase(40000)]
        public void IsLeapYear_returns_true_for_century_years_divisible_by_4_and_400(int input)
        {
            var result = Functions.IsLeapYear(input);

            Assert.IsTrue(result);
        }
    }
}