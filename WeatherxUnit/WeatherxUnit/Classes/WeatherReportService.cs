using WeatherxUnit.Interfaces;

namespace WeatherxUnit.Classes
{

    /// <summary>
    /// WeatherReportService
    /// This service contains tasks related to weather report
    /// </summary>
    public class WeatherReportService : IWeatherReportService
    {
        private readonly ILoggerService _loggerService;
        private readonly ITemperatureService _temperatureService;
        private readonly IDateTimeService _dateTimeService;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="logger">The logging service used for recording operational or diagnostic messages.</param>
        /// <param name="temperature">The service used to retrieve temperature data.</param>
        /// <param name="dateTime">The service used to access the current date and time.</param>
        /// <exception cref="ArgumentNullException">
        /// /// Thrown if <paramref name="logger"/>, <paramref name="temperature"/>, or <paramref name="dateTime"/> is <c>null</c>.
        /// </exception>
        public WeatherReportService(ILoggerService logger, ITemperatureService temperature, IDateTimeService dateTime)
        {
            _loggerService = logger ?? throw new ArgumentNullException(nameof(logger));
            _temperatureService = temperature ?? throw new ArgumentNullException(nameof(temperature));
            _dateTimeService = dateTime ?? throw new ArgumentNullException(nameof(dateTime));
        }

        /// <summary>
        /// Returns details regarding climate of the city based on the name of city
        /// </summary>
        /// <param name="city"></param>
        /// <returns>string</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public string GetClimate(string city)
        {
            DateTime currentDateTime = _dateTimeService.GetCurrentDateTime();
            _loggerService.LogInfo($"This function called for city:{city} at {currentDateTime} ");

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
            else if (temp > 10 && temp < 30)
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