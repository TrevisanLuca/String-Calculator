using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorConsole.Validators
{
    public class ValidateNegativeNumbers : AbstractValidator
    {
        public override List<int> Validate(List<int> input) =>
            input.Any(x => x < 0) ?
            throw new NegativeNumbersException() :
            _next == null ? input : _next.Validate(input);        
    }
}
