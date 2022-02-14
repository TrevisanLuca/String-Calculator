using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorConsole.Validators
{
    public class ValidateLessThanThousand : AbstractValidator
    {
        public override IEnumerable<int> Validate(IEnumerable<int> input)
        {
            var result = input.Where(x => x < 1000);
            return _next == null ? result : _next.Validate(result);
        }
    }
}
