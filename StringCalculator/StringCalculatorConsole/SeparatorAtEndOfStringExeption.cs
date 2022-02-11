using System;
namespace StringCalculatorConsole
{
    public class SeparatorAtEndOfStringExeption : Exception
    {
        public SeparatorAtEndOfStringExeption(string message) : base(message)
        {
        }
    }
}
