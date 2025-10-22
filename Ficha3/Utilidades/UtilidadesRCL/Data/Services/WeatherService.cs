using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilidadesRCL.Data.Dtos;
using UtilidadesRCL.Data.Interfaces;

namespace UtilidadesRCL.Data.Services
{
    public class WeatherService : IWeatherService
    {
        private static readonly string[] Summaries = new[]
        {
            "Gelado", "Frio", "Ameno", "Quente", "Escaldante"
        };
        public Task<IEnumerable<WeatherForecastDto>> GetForecastAsync()
        {
            var rng = new Random();
            var data = Enumerable.Range(1, 5).Select(index => new WeatherForecastDto
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-5, 35),
                Summary = Summaries[rng.Next(Summaries.Length)]
            });

            return Task.FromResult(data);
        }
    }
}
