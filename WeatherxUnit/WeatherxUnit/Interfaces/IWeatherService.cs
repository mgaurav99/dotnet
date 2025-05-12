using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherxUnit.Interfaces
{
    /// <summary>
    /// IWeatherService
    /// Fetching weather report/data
    /// </summary>
    public interface IWeatherService
    {
        /// <summary>
        /// Fetching climate on basis of city provided
        /// </summary>
        /// <param name="city"></param>
        /// <returns></returns>
        string GetClimate(string city);
    }
}
