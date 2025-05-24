using WeatherReport.Interfaces;

namespace WeatherReport.Classes
{
    /// <summary>
    /// DateTimeService
    /// Provides functionality related to date and time
    /// </summary>
    public class DateTimeService : IDateTimeService
    {
        /// <summary>
        /// Returns the current date and time 
        /// </summary>
        /// <returns>Utc DateTime</returns>
        public DateTime GetCurrentDateTime()
        {
            return DateTime.UtcNow;
        }
    }
    
}
