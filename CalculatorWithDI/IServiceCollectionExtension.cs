using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

namespace CalculatorWithDI
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddCalculatorDeps(this IServiceCollection services)
        {
            services.AddTransient<ICalculator, RealCalculator>();
            return services;
        }
    }
}
