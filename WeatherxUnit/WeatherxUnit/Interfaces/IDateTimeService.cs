using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherxUnit.Interfaces
{
    /// <summary>
    /// IDateTimeService
    /// Provides functionality related to date and time
    /// </summary>
    public interface IDateTimeService
    {
        /// <summary>
        /// Returns the current date and time in a string format
        /// </summary>
        /// <returns></returns>
        string GetCurrentDateTime();
    }
}
