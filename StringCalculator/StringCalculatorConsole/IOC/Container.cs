using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using StringCalculatorConsole.Validators;

namespace StringCalculatorConsole.IOC
{
    public class Container
    {
        public static T GetService<T>() =>
            CreateHostBuilder().Services.GetService<T>();
            
        static IHost CreateHostBuilder() =>
            Host
            .CreateDefaultBuilder()
            .ConfigureServices((_, services) =>
                services
                    .AddSingleton<ICalculator, Calculator>()
                    .AddSingleton<IValidator>(_ =>
                        {
                            var validator = new ValidateNegativeNumbers();
                            validator.SetNext(new ValidateLessThanThousand());
                            return validator;
                        }
                    )
            ).Build();
    }
}