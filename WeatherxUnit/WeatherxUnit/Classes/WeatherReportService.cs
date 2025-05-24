using WeatherReport.Interfaces;

namespace WeatherReport.Classes
{
    ///<summary>
    /// WeatherReportService
    /// This service contains tasks related to weather report.
    /// </summary>
    public class WeatherReportService : IWeatherReportService
    {
        private readonly IConsoleLoggerService _loggerService;
        private readonly ITemperatureService _temperatureService;
        private readonly IDateTimeService _dateTimeService;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="loggerService">Service used for recording operational or diagnostic messages.</param>
        /// <param name="temperatureService">Service used to retrieve temperature data.</param>
        /// <param name="dateTimeService">Service used to access the current date and time.</param>
        public WeatherReportService(IConsoleLoggerService loggerService, ITemperatureService temperatureService, 
            IDateTimeService dateTimeService)
        {
            _loggerService = loggerService;
            _temperatureService = temperatureService;
            _dateTimeService = dateTimeService;
        }

        /// <summary>
        /// Returns details regarding climate of the city based on the name of city
        /// </summary>
        /// <param name="city">City for which temperature is searched</param>
        /// <returns>string</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public string GetClimate(string city)
        {
            DateTime currentDateTime = _dateTimeService.GetCurrentDateTime();
            _loggerService.LogInfo($"This function called for city:{city} at {currentDateTime}");

            if (String.IsNullOrWhiteSpace(city))
            {
                _loggerService.LogWarning("No city provided!");
                throw new ArgumentNullException("Provide city!");
            }

            int temp = _temperatureService.GetTemperature();
            string climate = String.Empty;

            if (temp < 10)
            {
                climate = "cold";
            }
            else if (temp >= 10 && temp < 30)
            {
                climate = "warm";
            }

            else if (temp >= 30)
            {
                climate = "hot";
            }

            return $"The climate of the {city} is {climate}";
        }
    }

}