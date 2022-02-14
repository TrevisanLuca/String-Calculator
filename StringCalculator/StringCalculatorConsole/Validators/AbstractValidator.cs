using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorConsole.Validators
{
    public abstract class AbstractValidator : IValidator
    {
        protected IValidator _next;
        public IValidator SetNext(IValidator validator) => _next = validator;
        public abstract IEnumerable<int> Validate(IEnumerable<int> input);
    }
}
