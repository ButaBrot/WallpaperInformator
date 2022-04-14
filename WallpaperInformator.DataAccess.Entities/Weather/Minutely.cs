using System.Text.Json.Serialization;

namespace WallpaperInformator.DataAccess.Entities;

public class Minutely
{
    [JsonPropertyName("precipitation")]
    public int Precipitation { get; set; }
    [JsonPropertyName("dt")]
    public int Date { get; set; }
}