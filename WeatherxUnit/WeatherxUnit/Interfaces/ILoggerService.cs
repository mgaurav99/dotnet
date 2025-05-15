
namespace WeatherxUnit.Interfaces
{
    /// <summary>
    /// ILoggerService 
    /// Defines a contract for logging messages at different levels (info, warning, error).
    /// </summary>
    public interface ILoggerService
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
