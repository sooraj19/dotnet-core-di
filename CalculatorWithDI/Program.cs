using System;
using Microsoft.Extensions.DependencyInjection;

namespace CalculatorWithDI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // register deps
            var services = new ServiceCollection();
            services.AddCalculatorDeps();

            Console.ReadKey();
        }
    }
}
