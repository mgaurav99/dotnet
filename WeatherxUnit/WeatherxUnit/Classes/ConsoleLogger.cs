using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherxUnit.Interfaces;

namespace WeatherxUnit.Classes
{
    /// <summary>
    /// ConsoleLogger
    /// Logging related implementations
    /// </summary>
    public class ConsoleLogger : ILogger
    {
        /// <summary>
        /// Loggin errors 
        /// </summary>
        /// <param name="message"></param>
        public void LogError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
        }

        /// <summary>
        /// Logging information
        /// </summary>
        /// <param name="message"></param>

        public void LogInfo(string message)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(message);
        }

        /// <summary>
        /// Logging warnings
        /// </summary>
        /// <param name="message"></param>

        public void LogWarning(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
        }
    }
}
