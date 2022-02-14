using System.Linq;

namespace StringCalculatorConsole
{
    public class Calculator : ICalculator
    {
        protected IValidator _validator;
        public Calculator(IValidator validator)
        {
            _validator = validator;
        }
        public int Add(string numbers) => 
            _validator
            .Validate(numbers.StringSplitter())
            .Sum();
    }
}