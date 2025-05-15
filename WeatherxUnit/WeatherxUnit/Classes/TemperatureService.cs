using WeatherxUnit.Interfaces;

namespace WeatherxUnit.Classes
{
    /// <summary>
    ///  TemperatureService
    ///  Calculates temperature
    /// </summary>
    public class TemperatureService : ITemperatureService
    {
        /// <summary>
        ///  Get random temperature 
        /// </summary>
        /// <returns>int</returns>
        public int GetTemperature()
        {
            Random random = new Random();
            return  random.Next(10, 50);
        }
    }
}
