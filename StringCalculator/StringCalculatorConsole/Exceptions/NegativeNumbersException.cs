using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorConsole
{
    public class NegativeNumbersException : Exception
    {
        public NegativeNumbersException() : base("Nevative number(s) not allowed")
        { }
    }    
}