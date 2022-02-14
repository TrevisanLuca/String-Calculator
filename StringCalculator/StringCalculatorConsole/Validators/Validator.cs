using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorConsole
{
    public class Validator : IValidator
    {
        public IEnumerable<int> Validate(IEnumerable<int> input)
        {
            var result = ValidateNegativeNumbers(input);
            result = ValidateNumberLessThanThousand(result);
            return result;
        }
        IEnumerable<int> ValidateNegativeNumbers(IEnumerable<int> input) =>
            input.Any(x => x < 0) ?
            throw new NegativeNumbersException() :
            input;
        IEnumerable<int> ValidateNumberLessThanThousand(IEnumerable<int> input) => input.Where(x => x < 1000);
    }
}
