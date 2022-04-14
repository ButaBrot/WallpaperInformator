using System.Text.Json.Serialization;

namespace WallpaperInformator.DataAccess.Entities;

public class Feels_Like
{
    [JsonPropertyName("day")]
    public float Day { get; set; }

    [JsonPropertyName("night")]
    public float Night { get; set; }

    [JsonPropertyName("eve")]
    public float Evening { get; set; }

    [JsonPropertyName("morn")]
    public float Morning { get; set; }
}