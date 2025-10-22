using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using UtilidadesRCL.Data.Services;
using UtilidadesRCL.Data.Interfaces;

namespace UtilidadesRCL.Data
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDataServices(this IServiceCollection services)
        {
            services.AddScoped<IWeatherService, WeatherService>();
            services.AddScoped<ITodoService, TodoService>();
            return services;
        }
    }
}
