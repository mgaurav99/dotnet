

namespace WeatherxUnit.Interfaces
{
    /// <summary>
    /// ITemperature
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
