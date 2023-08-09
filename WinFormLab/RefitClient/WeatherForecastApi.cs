using Refit;
using CommonRes;

namespace WinFormLab.RefitClient;

public interface IWeatherForecastApi
{
  [Get("/WeatherForecast")]
  Task<List<WeatherForecast>> WeatherForecastAsync();
}
