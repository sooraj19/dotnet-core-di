using System;
using Microsoft.Extensions.DependencyInjection;

namespace CalculatorWithDI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // register the deps
            var services = new ServiceCollection()
                .AddCalculatorDeps()
                .BuildServiceProvider();

            // get instance of the dep
            var calculatorDep = services.GetService<ICalculator>();
            var consumer = new Consumer(calculatorDep);

            var result = consumer.ConsumerAdd(1, 2);
            Console.WriteLine($"Result: {result}");

            Console.ReadKey();
        }
    }
}
