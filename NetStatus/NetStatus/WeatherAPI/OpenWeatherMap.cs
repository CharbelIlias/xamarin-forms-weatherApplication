using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NetStatus.WeatherAPI
{
   public class OpenWeatherMap<T>
    {
        private const string OpenWeatherApi = "http://api.openweathermap.org/data/2.5/weather?q=";
        private const string Key = "8c91f815e297ad3c2c0eb7c8f517e447";
        private const string TempUnitCelsius = "&units=metric";
        HttpClient httpClient = new HttpClient();

        public async Task<T> GetWeather(string city)
        {
            var json = await httpClient.GetStringAsync(OpenWeatherApi + city + "&APPID=" + Key + TempUnitCelsius);
            var weatherModels = JsonConvert.DeserializeObject<T>(json);
            return weatherModels;
        }
    }
}
