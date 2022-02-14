using NUnit.Framework;
using System;
using StringCalculatorConsole;
using System.Collections.Generic;

namespace TDDStringCalculator
{
    class KataStringSplitterExtensionUnitTest
    {        
        [Test]
        public void TestSplit2Input()
        {
            var input = "1,2";
            var expected = new List<int>() { 1, 2 };
            Assert.AreEqual(expected, input.StringSplitter());
        }
        [Test]
        public void TestSplit6Input()
        {
            var input = "1,2,3,4,5,6";
            var expected = new List<int>() { 1, 2, 3, 4, 5, 6 };
            Assert.AreEqual(expected, input.StringSplitter());
        }
        [Test]
        public void TestSeparatorAtEndException()
        {
            var input = "1,2,";
            Assert.Throws<SeparatorAtEndOfStringExeption>(() => input.StringSplitter());
        }
        [Test]
        public void TestNewLineAtEndException()
        {
            var input = "1,2,3\n";
            Assert.Throws<SeparatorAtEndOfStringExeption>(() => input.StringSplitter());
        }
        [Test]
        public void TestNewSeparator()
        {
            var input = "//|\n1|2|3";
            var expected = new List<int>() { 1, 2, 3 };
            Assert.AreEqual(expected, input.StringSplitter());
        }
        [Test]
        [Ignore("")]
        public void TestNewLineNotValidException()
        {
            var input = "//sep\n5sep2\n3";
            Assert.Throws<FormatException>(() => input.StringSplitter());
        }
        [Test]
        public void TestMissingSeparatorException()
        {
            var input = "//\n5sep2sep3";
            Assert.Throws<FormatException>(() => input.StringSplitter());
        }
    }
}
