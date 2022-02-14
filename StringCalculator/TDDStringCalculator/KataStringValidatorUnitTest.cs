using NUnit.Framework;
using System.Collections.Generic;
using StringCalculatorConsole.Validators;

namespace TDDStringCalculator
{
    class KataStringValidatorUnitTest
    {
        private AbstractValidator _sut;
        [SetUp]
        public void Setup()
        {
            _sut = new ValidateNegativeNumbers();
            _sut.SetNext(new ValidateLessThanThousand());
        }

        [Test]
        public void TestIgnoreThousand()
        {
            var input = new List<int>() { 2, 1001 };
            var expected = new List<int>() { 2 };
            Assert.AreEqual(expected, _sut.Validate(input));
        }
        [Test]
        public void TestIgnoreThreeThousand()
        {
            var input = new List<int>() { 1, 2, 3000 };
            var expected = new List<int>() { 1, 2 };
            Assert.AreEqual(expected, _sut.Validate(input));
        }
    }
}