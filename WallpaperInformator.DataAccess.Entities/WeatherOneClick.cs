using System.Text.Json.Serialization;

namespace WallpaperInformator.DataAccess.Entities;

public class WeatherOneClick:Entity
{
   [JsonPropertyName("lat")] public float Latitude { get; set; }
   [JsonPropertyName("lon")] public float Longitude { get; set; }
   [JsonPropertyName("timezone")] public string TimeZone { get; set; }
   [JsonPropertyName("timezone_offset")] public int TimeZoneOffset { get; set; }
   [JsonPropertyName("current")] public Current Current { get; set; }
   [JsonPropertyName("minutely")] public Minutely[] Minutely { get; set; }
   [JsonPropertyName("hourly")] public Hourly[] Hourly { get; set; }
    [JsonPropertyName("daily")] public Daily[] Daily { get; set; }
}