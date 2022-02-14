using System.Collections.Generic;
namespace StringCalculatorConsole.Validators
{
    public abstract class AbstractValidator : IValidator
    {
        protected IValidator _next;
        public IValidator SetNext(IValidator validator) => _next = validator;
        public abstract List<int> Validate(List<int> input);
    }
}