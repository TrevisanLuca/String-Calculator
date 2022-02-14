using System.Collections.Generic;
namespace StringCalculatorConsole
{
    public interface IValidator
    {
        List<int> Validate(List<int> input);
    }
}