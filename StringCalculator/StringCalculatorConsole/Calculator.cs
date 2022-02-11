using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculatorConsole
{
    public class Calculator : ICalculator
    {
        public int Add(string numbers)
        {
            var tempNumbers = numbers.StringSplitter();

            foreach (var number in tempNumbers)
                if (number < 0)
                    throw new NegativeNumbersException("Nevative number(s) not allowed");

            return tempNumbers.Sum();
        }
    }
}