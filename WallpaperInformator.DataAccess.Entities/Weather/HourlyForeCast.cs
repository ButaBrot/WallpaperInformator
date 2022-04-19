using System.Text.Json.Serialization;

namespace WallpaperInformator.DataAccess.Entities;

public class HourlyForeCast : WeatherBase
{
    [JsonPropertyName("visibility")] public int   Visibility                 { get; set; }
    [JsonPropertyName("pop")]        public float ProbabilityOfPrecipitation { get; set; }
    [JsonPropertyName("temp")]       public float Temperature                { get; set; }
}