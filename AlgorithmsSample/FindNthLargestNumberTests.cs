using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Basics
{
    [TestFixture]
    public class FindNthLargestNumberTests
    {
        [Test]
        [ExpectedException(
            typeof(ArgumentNullException),
            ExpectedMessage = "Value cannot be null.\r\nParameter name: numbers")]
        public void FindNthLargestNumber_throws_for_null_numbers_input()
        {
            Functions.FindNthLargestNumber(null, 1);
        }

        [Test]
        [ExpectedException(
            typeof(ArgumentOutOfRangeException),
            ExpectedMessage = "Nth largest number must be greater than 0.\r\nParameter name: nthLargestNumber")]
        public void FindNthLargestNumber_throws_for_nth_largest_number_input_smaller_than_1()
        {
            Functions.FindNthLargestNumber(new List<int> {1}, 0);
        }

        [Test]
        [ExpectedException(
            typeof(ArgumentException),
            ExpectedMessage = "Nth largest number must be less or equal than numbers list count.")]
        public void FindNthLargestNumber_throws_for_nth_largest_number_greather_than_numbers_count_input()
        {
            Functions.FindNthLargestNumber(new List<int> {1}, 2);
        }

        [Test]
        public void FindNthLargestNumber_returns_nth_largest_number_for_distinct_list()
        {
            // 16 distinct numbers
            var numbers = new List<int> { 1, 15, 7, 4, 13, 11, 13, -16, 5, 12, 9, 8, 6, 3, 2, 14 };

            var result = Functions.FindNthLargestNumber(numbers, 2);

            Assert.AreEqual(14, result);
        }

        [Test]
        public void FindNthLargestNumber_returns_nth_largest_number_for_non_distinct_list()
        {
            // 18 numbers, 2 and 11 are doubled
            var numbers = new List<int> {1, 15, 7, 4, 13, 2, 11, 13, 16, 5, 11, 12, 9, 8, 6, 3, 2, 14};

            var result = Functions.FindNthLargestNumber(numbers, 15);

            Assert.AreEqual(3, result);
        }
    }
}