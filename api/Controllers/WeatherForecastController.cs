namespace api.WeatherForecastController;
using api.Services;

public class WeatherForecastController
{
    private readonly IWeatherForecastService1 _weatherService;

    // The runtime automatically supplies the EmailService here
    public WeatherForecastController(IWeatherForecastService1 weatherService)
    {
        _weatherService = weatherService;
    }

    public bool GetWeatherForecast1()
    {
        var result = _weatherService.GetWeatherForecast1();
        return result || false;
    }
}

