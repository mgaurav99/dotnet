using WeatherxUnit.Interfaces;

public class WeatherReportService : IWeatherService
{
    readonly ILogger _logger;
    readonly ITemperature _temperature;
    public WeatherReportService(ILogger logger, ITemperature temperature)
    {
        _logger = logger;
        _temperature = temperature;
    }



    public string GetClimate(string city)
    {


        _logger.LogInfo($"This function called for city:{city} at {DateTime.Now} ");

        if (String.IsNullOrWhiteSpace(city))
        {
            _logger.LogWarning("No city provided!");
            throw new ArgumentNullException("Provide city!");
        }

        int temp = _temperature.GetTemperature();  //mock for classes set up for function.

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