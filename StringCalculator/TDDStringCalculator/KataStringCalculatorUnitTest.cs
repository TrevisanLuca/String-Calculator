using NUnit.Framework;
using StringCalculatorConsole;
using System;

namespace TDDStringCalculator
{
    public class Tests
    {
        private ICalculator _sut;

        [SetUp]
        public void Setup() => _sut = new Calculator(new Validator());

        [TestCase("", ExpectedResult = 0)]
        [TestCase("1", ExpectedResult = 1)]
        [TestCase("1,2", ExpectedResult = 3)]
        [TestCase("1,2,3,4,5,6", ExpectedResult = 21)]
        [TestCase("1,2\n3", ExpectedResult = 6)]
        [TestCase("1\n2,4", ExpectedResult = 7)]
        [TestCase("//;\n1;3", ExpectedResult = 4)]                 
        [TestCase("//|\n1|2|3", ExpectedResult = 6)]                 
        [TestCase("//sep\n5sep2", ExpectedResult = 7)]                 
        [TestCase("2,1001", ExpectedResult = 2)]   
        [TestCase("//|\n1|2|3000", ExpectedResult = 3)]
        public int Test(string input) => _sut.Add(input);
        [Test]
        public void TestReturnException()
        {
            var input = "1,2,";
            Assert.Throws<SeparatorAtEndOfStringExeption>(() =>_sut.Add(input));
        }
        [Test]
        public void TestCharReturnException()
        {
            var input = "1,2,b";
            Assert.Throws<FormatException>(() => _sut.Add(input));
        }
        [Test]
        public void TestWrongSeparatorReturnException()
        {
            var input = "//|\n1|3,4";
            Assert.Throws<FormatException>(() => _sut.Add(input));
        }
        [Test]
        public void TestMissingSeparatorException()
        {
            var input = "//\n1|3|4";
            Assert.Throws<FormatException>(() => _sut.Add(input));
        }
        [Test]
        public void TestSeparatorOverrideException()
        {
            var input = "//|\n1|3|4\n3";
            Assert.Throws<FormatException>(() => _sut.Add(input));
        }
        [Test]
        public void TestNegativeException()
        {
            var input = "//|\n1|3|-4|3";
            Assert.Throws<NegativeNumbersException>(() => _sut.Add(input));
        }
    }
}