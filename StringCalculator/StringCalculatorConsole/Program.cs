using StringCalculatorConsole.Validators;
using System;

namespace StringCalculatorConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci la stringa da calcolare");
            var read = Console.ReadLine();
            Console.WriteLine($"Il risultato è => {Calculate(read)}");
            //Console.ReadLine();
        }
        static int Calculate(string inputString)
        {
            var validator = new ValidateNegativeNumbers().SetNext(new ValidateLessThanThousand());
            var calculator = new Calculator(validator);

            var result = calculator.Add(inputString);
            return result;
        }
    }
}
