using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherxUnit.Interfaces
{
    /// <summary>
    /// ITemperature
    /// Calculates temperature
    /// </summary>
    public interface ITemperature
    {
        /// <summary>
        ///  Getting temperature
        /// </summary>
        /// <returns>int</returns>
        int GetTemperature();
    }
}
