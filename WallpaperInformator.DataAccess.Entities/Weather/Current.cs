using System.Text.Json.Serialization;

namespace WallpaperInformator.DataAccess.Entities;

public class Current : WeatherBase
{
    [JsonPropertyName("sunrise")] public int Sunrise { get; set; }
    [JsonPropertyName("sunset")] public int Sunset { get; set; }
    [JsonPropertyName("visibility")] public int   Visibility  { get; set; }
    [JsonPropertyName("temp")]       public float Temperature { get; set; }
}