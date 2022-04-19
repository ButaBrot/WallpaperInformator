using System.Text.Json.Serialization;

namespace WallpaperInformator.DataAccess.Entities;

public class WeatherDescription
{
    [JsonPropertyName("id")]          public int    id          { get; set; }
    [JsonPropertyName("main")]        public string Main        { get; set; }
    [JsonPropertyName("description")] public string Description { get; set; }
    [JsonPropertyName("icon")]        public string Icon        { get; set; }
}