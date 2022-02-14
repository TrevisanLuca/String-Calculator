using NUnit.Framework;
using StringCalculatorConsole;
using StringCalculatorConsole.IOC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDStringCalculator
{
    public class KataStringIOCUnitTest
    {
        [SetUp]
        public void SetUp() { }
        [Test]
        public void TestGetCalculator()
        {
            var calculator = Container.GetService<ICalculator>();
            Assert.IsNotNull(calculator);
        }
        [Test]
        public void TestGetValidator()
        {
            var calculator = Container.GetService<IValidator>();
            Assert.IsNotNull(calculator);
        }
        [Test]
        public void TestGetValidCalculator()
        {
            var calculator = Container.GetService<ICalculator>();
            var expected = typeof(Calculator);
            Assert.AreEqual(expected, calculator.GetType());
        }
    }
}
