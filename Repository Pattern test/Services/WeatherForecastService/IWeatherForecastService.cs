﻿namespace Repository_Pattern_test.Services.WeatherForecastService
{
    public interface IWeatherForecastService
    {
        IEnumerable<WeatherForecast> Get();
    }
}
