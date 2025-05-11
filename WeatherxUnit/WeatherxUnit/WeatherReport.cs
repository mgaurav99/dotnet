using WeatherxUnit;

public class WeatherReport
{
    private readonly IWeatherService _weatherService;

    public WeatherReport(IWeatherService weatherService)
    {
        _weatherService = weatherService;
    }

    public string GetWeatherMessage(string city)
    {
        int temp = _weatherService.GetTemperature(city);
        return temp > 25 ? "Warm" : "Cold";
    }
}