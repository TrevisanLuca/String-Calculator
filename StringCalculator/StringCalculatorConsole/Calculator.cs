using System.Linq;

namespace StringCalculatorConsole
{
    public class Calculator : ICalculator
    {
        private IValidator validator;
        public Calculator() => validator = new Validator();
        public int Add(string numbers) => validator.Validate(numbers.StringSplitter()).Sum();
    }
}