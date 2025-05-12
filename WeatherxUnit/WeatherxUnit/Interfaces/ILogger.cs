using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherxUnit.Interfaces
{
    /// <summary>
    /// ILogger
    /// Logging purposes
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Logging info
        /// </summary>
        /// <param name="message"></param>
        void LogInfo(string message);

        /// <summary>
        /// Logging warnings
        /// </summary>
        /// <param name="message"></param>
        void LogWarning(string message);

        /// <summary>
        /// Logging Errors
        /// </summary>
        /// <param name="message"></param>
        void LogError(string message);
    }
}
