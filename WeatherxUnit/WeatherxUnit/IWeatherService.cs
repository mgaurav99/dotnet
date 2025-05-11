using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherxUnit
{
    public interface IWeatherService
    {
        int GetTemperature(string city);
    }
}
