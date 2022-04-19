using System.Text.Json.Serialization;

namespace WallpaperInformator.DataAccess.Entities;

public class DailyForecast : WeatherBase
{
    [JsonPropertyName("sunrise")]    public int          Sunrise                    { get; set; }
    [JsonPropertyName("sunset")]     public int          Sunset                     { get; set; }
    [JsonPropertyName("moonrise")]   public int          Moonrise                   { get; set; }
    [JsonPropertyName("moonset")]    public int          Moonset                    { get; set; }
    [JsonPropertyName("moon_phase")] public float        MoonPhase                  { get; set; }
    [JsonPropertyName("pop")]        public float        ProbabilityOfPrecipitation { get; set; }
    [JsonPropertyName("temp")]       public Temperature? TemperatureDaily           { get; set; }
    [JsonPropertyName("feels_like")] public Feels_Like?  FeelsLike                  { get; set; }
}