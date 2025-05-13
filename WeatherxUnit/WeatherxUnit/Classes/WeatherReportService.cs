using WeatherxUnit.Interfaces;

/// <summary>
/// WeatherReportService
/// This service used for tasks related to weather report
/// </summary>
public class WeatherReportService : IWeatherReportService
{
    private readonly ILoggerService _loggerService;
    private readonly ITemperatureService _temperatureService;
    private readonly IDateTimeService _dateTimeService;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="logger"></param>
    /// <param name="temperature"></param>
    /// <param name="dateTime"></param>
    /// <exception cref="ArgumentNullException"></exception>
    public WeatherReportService(ILoggerService logger, ITemperatureService temperature, IDateTimeService dateTime)
    {
        _loggerService = logger ?? throw new ArgumentNullException(nameof(logger));
        _temperatureService = temperature ?? throw new ArgumentNullException(nameof(temperature));
        _dateTimeService = dateTime ?? throw new ArgumentNullException(nameof(dateTime));
    }

    /// <summary>
    /// Returns climate of the city
    /// </summary>
    /// <param name="city"></param>
    /// <returns>string</returns>
    /// <exception cref="ArgumentNullException"></exception>
    public string GetClimate(string city)
    {
        string currentDateTime = _dateTimeService.GetCurrentDateTime();
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