﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TennisBookings.Web.External.Models;

namespace TennisBookings.Web.Services
{
    public class AmazingWeatherForecaster
    {
        public WeatherResult GetCurrentWeather()
        {
            // DO SOMETHING AMAZING HERE !!!

            return new WeatherResult
            {
                WeatherCondition = WeatherCondition.Sun
            };
        }
    }
}
