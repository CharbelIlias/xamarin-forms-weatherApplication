using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NetStatus.Models;
using NetStatus.WeatherAPI;

namespace NetStatus.Services
{
    public class WeatherServices
    {
        OpenWeatherMap<WeatherMainModel> _openWeatherApi = new OpenWeatherMap<WeatherMainModel>();
        
        public async Task<WeatherMainModel> GetWeatherDetails(string city)
        {
            var getWeatherDetails = await _openWeatherApi.GetWeather(city);
            return getWeatherDetails;
        }
    }
}
