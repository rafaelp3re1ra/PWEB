using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilidadesRCL.Data.Dtos;

namespace UtilidadesRCL.Data.Interfaces
{
    public interface IWeatherService
    {
        Task<IEnumerable<WeatherForecastDto>> GetForecastAsync();
    }
}
