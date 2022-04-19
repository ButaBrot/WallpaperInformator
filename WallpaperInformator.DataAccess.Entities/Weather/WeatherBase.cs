using System.Text.Json.Serialization;

namespace WallpaperInformator.DataAccess.Entities;

public abstract class WeatherBase
{
    [JsonPropertyName("dt")]         public int       Date          { get; set; }
    [JsonPropertyName("feels_like")] public float     FeelsLike     { get; set; }
    [JsonPropertyName("pressure")]   public int       Pressure      { get; set; }
    [JsonPropertyName("humidity")]   public int       Humidity      { get; set; }
    [JsonPropertyName("dew_point")]  public float     DewPoint      { get; set; }
    [JsonPropertyName("wind_speed")] public float     WindSpeed     { get; set; }
    [JsonPropertyName("wind_deg")]   public int       WindDirection { get; set; }
    [JsonPropertyName("wind_gust")]  public float     WindGust      { get; set; }
    [JsonPropertyName("uvi")]        public float     UvIndex       { get; set; }
    [JsonPropertyName("clouds")]     public int       Clouds        { get; set; }
    [JsonPropertyName("weather")]    public WeatherDescription[] Weather       { get; set; }
}