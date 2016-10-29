using System;
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

        [TestCase("g", "g", Description = "Simple base char")]
        [TestCase("g̈", "g̈", Description = "Grapheme clauster char")]
        [TestCase("ष", "ष", Description = "Legacy grapheme cluster char")]
        [TestCase("நி", "நி", Description = "Extended grapheme cluster char")]
        public void ReverseString_returns_single_char_string_for_single_char_input(
            string input, string expected)
        {
            var result = Functions.ReverseString(input);

            Assert.AreEqual(expected, result);
        }

        [TestCase("Mère", "erèM", Description = "Simple base chars")]
        [TestCase("Me\u0301re", "ere\u0301M", Description = "Simple combined chars")]
        [TestCase(
            "\u0627\u0655\u0650" + "\u064A" + "\u0647\u064E" + "\u0627" + "\u0628\u064C",
            "\u0628\u064C" + "\u0627" + "\u0647\u064E" + "\u064A" + "\u0627\u0655\u0650",
            Description = "Complex combined chars")]
        public void ReverseString_returns_string_with_chars_in_reversed_order(
            string input, string expected)
        {
            var result = Functions.ReverseString(input);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ReverseString_returns_string_with_reversed_surogate_pairs()
        {
            var input =
                char.ConvertFromUtf32(0x10148) +
                char.ConvertFromUtf32(0x20026) +
                "a" +
                char.ConvertFromUtf32(0xF1001);

            var result = Functions.ReverseString(input);

            var expected =
                char.ConvertFromUtf32(0xF1001) +
                "a" +
                char.ConvertFromUtf32(0x20026) +
                char.ConvertFromUtf32(0x10148);

            Assert.AreEqual(expected, result);
        }
    }
}