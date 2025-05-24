
namespace WeatherReport.Interfaces
{
    /// <summary>
    /// IWeatherService
    /// Defines a contract to get weather report related data
    /// </summary>
    public interface IWeatherReportService
    {
        /// <summary>
        /// Provides a contract for retrieving weather report data.
        /// </summary>
        /// <param name="city">The name of the city for which climate data is retrieved.</param>
        /// <returns>A string containing the climate information for the specified city.</returns>
        string GetClimate(string city);
    }
}
