using System.Text.Json.Serialization;

namespace WallpaperInformator.DataAccess.Entities;

public class OpenWeatherEntity : Entity
{
    [JsonPropertyName("lat")]             public float              Latitude         { get; set; }
    [JsonPropertyName("lon")]             public float              Longitude        { get; set; }
    [JsonPropertyName("timezone")]        public string             TimeZone         { get; set; }
    [JsonPropertyName("timezone_offset")] public int                TimeZoneOffset   { get; set; }
    [JsonPropertyName("current")]         public CurrentWeather     CurrentWeather   { get; set; }
    [JsonPropertyName("minutely")]        public MinutelyForecast[] MinutelyForecast { get; set; }
    [JsonPropertyName("hourly")]          public HourlyForeCast[]   HourlyForeCast   { get; set; }
    [JsonPropertyName("daily")]           public DailyForecast[]    DailyForecast    { get; set; }
}