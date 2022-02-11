using NUnit.Framework;
using StringCalculatorConsole;

namespace TDDStringCalculator
{
    public class Tests
    {
        private ICalculator _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new Calculator();
        }

        [TestCase("", ExpectedResult = 0)]
        [TestCase("1", ExpectedResult = 1)]
        [TestCase("1,2", ExpectedResult = 3)]
        [TestCase("1,2,3,4,5,6", ExpectedResult = 21)]        
        [TestCase("1,2\n3", ExpectedResult = 6)]        
        [TestCase("1\n2,4", ExpectedResult = 7)]        
        public int Test(string input) => _sut.Add(input);
    }
}