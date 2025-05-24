using WeatherReport.Interfaces;

namespace WeatherReport.Classes
{
    ///<summary>
    /// ConsoleLoggerService
    ///Provides logging functionality by writing messages to the console with appropriate formatting 
    ///based on the log level.
    /// </summary>
    public class ConsoleLoggerService : IConsoleLoggerService
    {
        /// <summary>
        /// Log errors to console.Use red as foreground color.
        /// </summary>
        /// <param name="message">Error message to be loggged.</param>
        public void LogError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
        }

        /// <summary>
        /// Log information to console. use white as foreground color.
        /// </summary>
        /// <param name="message">The information to be logged.</param>
        public void LogInfo(string message)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(message);
        }

        /// <summary>
        /// Log warnings to console. Use yellow as foreground color.
        /// </summary>
        /// <param name="message">Warning message to be logged.</param>
        public void LogWarning(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
        }
    }
}
