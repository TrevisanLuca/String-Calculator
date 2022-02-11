using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorConsole
{
    public class Validator : IValidator
    {
        public  IEnumerable<int> Validate(IEnumerable<int> input)
        {
            if (input.Any(x => x < 0))
                throw new NegativeNumbersException();

            return input;
        }
    }
}