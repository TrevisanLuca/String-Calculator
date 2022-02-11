using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculatorConsole
{
    public class Calculator : ICalculator
    {
        public int Add(string numbers) => numbers.StringSplitter().Sum();        
    }
}