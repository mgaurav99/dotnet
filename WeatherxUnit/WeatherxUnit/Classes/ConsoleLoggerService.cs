
using WeatherxUnit.Interfaces;

namespace WeatherxUnit.Classes
{
    /// <summary>
    /// ConsoleLoggerService
    ///Provides logging functionality by writing messages to the console with appropriate formatting based on the log level.
    /// </summary>
    public class ConsoleLoggerService : ILoggerService
    {
        /// <summary>
        /// Log errors to console using red as foreground color
        /// </summary>
        /// <param name="message">The error message to be loggged. </param>
        public void LogError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
        }

        /// <summary>
        /// Logging information ro console using white as foreground color
        /// </summary>
        /// <param name="message">The information to be logged.</param>

        public void LogInfo(string message)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(message);
        }

        /// <summary>
        /// Logging warnings to console using yellow as foreground color
        /// </summary>
        /// <param name="message">Warning to be logged</param>

        public void LogWarning(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
        }
    }
}
