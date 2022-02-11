using System.Linq;

namespace StringCalculatorConsole
{
    public class Calculator : ICalculator
    {
        public int Add(string numbers) => 
            numbers
            .StringSplitter()
            .Validate()
            .Sum();
    }
}