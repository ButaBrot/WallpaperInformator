using System.Net.Http.Json;
using WallpaperInformator.DataAccess.Entities;

namespace WallpaperInformator.DataAccess
{
    public class OpenWeatherRepo
    {
        private HttpClient _client;
        private string     _apiKey="947aa21a922735ee70e68970da5aebc7";


        public OpenWeatherRepo(HttpClient client/*, string apiKey*/)
        {
            this._client = client;
            // this._apiKey = apiKey;
        }

        //https://api.openweathermap.org/data/2.5/onecall?lat={lat}&lon={lon}&exclude={part}&appid={API key}
        // http: //api.openweathermap.org/geo/1.0/direct?q={city name},{state code},{country code}&limit={limit}&appid={API key}
        internal async Task<WeatherOneClick> GetWeather(double lat,double lon)
        {
            return await _client.GetFromJsonAsync<WeatherOneClick>($"data/2.5/onecall?lat={lat}&lon={lon}&units=metric&lang=de&appid={_apiKey}").ConfigureAwait(false);
        }

        public async Task<Location[]> GetLocationByName(string cityName)
        {
            return  await _client.GetFromJsonAsync<Location[]>($"geo/1.0/direct?q={cityName}&limit=1&appid={_apiKey}").ConfigureAwait(false);
            
        }

        public async Task<WeatherOneClick> GetWeatherByName(string cityName)
        {
            var location=await GetLocationByName(cityName).ConfigureAwait(false);

            return await GetWeather(location[0].Latitude, location[0].Longitude).ConfigureAwait(false);
        }
    }
}