using System.Collections.Generic;
using System.Linq;

namespace StringCalculatorConsole
{
    public static class ValidatorExtension
    {
        public static IEnumerable<int> Validate(this IEnumerable<int> input) => 
            input.Any(x => x < 0) ?
            throw new NegativeNumbersException() :
            input;        
    }
}