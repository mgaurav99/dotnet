using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherxUnit.Interfaces
{
    public interface IWeatherService
    {
        string GetClimate(string city);
    }
}
