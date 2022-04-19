using System.Net.Http.Json;
using WallpaperInformator.DataAccess.Entities;

namespace WallpaperInformator.DataAccess
{
    public class OpenWeatherRepo : Repository<OpenWeatherEntity>, IOpenWeatherRepo
    {
        private HttpClient _client;
        private string     _cityName;


        public OpenWeatherRepo(HttpClient client)
        {
            this._client = client;
        }

        private void FillInputData()
        {
            _apiKey     = OpenWeatherSettings.ApiKey;
            _baseAdress = OpenWeatherSettings.BaseAddress;
            _cityName   = OpenWeatherSettings.CityName;
            ValidateInput();
            _client.BaseAddress = _baseAdress;
        }

        protected override void ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(_cityName))
                throw new ArgumentException("An Name of City has to be provided");

            base.ValidateInput();
        }

        //https://api.openweathermap.org/data/2.5/onecall?lat={lat}&lon={lon}&exclude={part}&appid={API key}
        // http: //api.openweathermap.org/geo/1.0/direct?q={city name},{state code},{country code}&limit={limit}&appid={API key}
        internal async Task<OpenWeatherEntity> GetWeather(double lat, double lon)
        {
            return await _client.GetFromJsonAsync<OpenWeatherEntity>($"data/2.5/onecall?lat={lat}&lon={lon}&units=metric&lang=de&appid={_apiKey}").ConfigureAwait(false);
        }

        private async Task<Location[]> GetLocationByName()
        {
            if (string.IsNullOrWhiteSpace(_cityName)) FillInputData();
            return await _client.GetFromJsonAsync<Location[]>($"geo/1.0/direct?q={_cityName}&limit=1&appid={_apiKey}").ConfigureAwait(false);
        }

        public async Task<OpenWeatherEntity> GetWeatherData()
        {
            var location = await GetLocationByName().ConfigureAwait(false);
            return await GetWeather(location[0].Latitude, location[0].Longitude).ConfigureAwait(false);
        }
    }
}