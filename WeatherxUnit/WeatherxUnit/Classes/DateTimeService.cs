using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherxUnit.Interfaces;

namespace WeatherxUnit.Classes
{
    /// <summary>
    /// DateTimeService
    /// Provides functionality related to date and time
    /// </summary>
    public class DateTimeService : IDateTimeService
    {
        /// <summary>
        /// Returns the current date and time in a string format
        /// </summary>
        /// <returns></returns>
        public string GetCurrentDateTime()
        {
            return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
    
}
