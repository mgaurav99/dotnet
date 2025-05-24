
namespace WeatherReport.Interfaces
{
    /// <summary>
    /// IDateTimeService
    /// Defines a contract to retrieve date and time related data
    /// </summary>
    public interface IDateTimeService
    {
        /// <summary>
        /// Returns  current date and time in utc 
        /// </summary>
        /// <returns>DateTime</returns>
        DateTime GetCurrentDateTime();
    }
}
