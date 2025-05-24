
namespace WeatherReport.Interfaces
{
    /// <summary>
    /// ILoggerService 
    /// Defines a contract for logging messages at different levels (info, warning, error).
    /// </summary>
    public interface IConsoleLoggerService
    {
        /// <summary>
        /// Logging info
        /// </summary>
        /// <param name="message">Message to be displayed.</param>
        void LogInfo(string message);

        /// <summary>
        /// Logging warnings
        /// </summary>
        /// <param name="message">Warning to be displayed.</param>
        void LogWarning(string message);

        /// <summary>
        /// Logging Errors
        /// </summary>
        /// <param name="message">Error to be displayed.</param>
        void LogError(string message);
    }
}
