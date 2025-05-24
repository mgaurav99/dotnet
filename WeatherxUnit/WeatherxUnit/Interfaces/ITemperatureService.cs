

namespace WeatherReport.Interfaces
{
    /// <summary>
    /// ITemperatureService
    /// Defines a contract for retrieving temperature data.
    /// </summary>
    public interface ITemperatureService
    {
        /// <summary>
        ///  Get random temperature 
        /// </summary>
        /// <returns>int</returns>
        int GetTemperature();
    }
}
