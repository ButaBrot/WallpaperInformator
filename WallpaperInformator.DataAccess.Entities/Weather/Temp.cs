using System.Text.Json.Serialization;

namespace WallpaperInformator.DataAccess.Entities;

public class Temp
{
    [JsonPropertyName("day")]
    public float Day { get; set; }

    [JsonPropertyName("min")]
    public float Minimum { get; set; }

    [JsonPropertyName("max")]
    public float Мaximum { get; set; }

    [JsonPropertyName("night")]
    public float Night { get; set; }

    [JsonPropertyName("eve")]
    public float Evening { get; set; }

    [JsonPropertyName("morn")]
    public float Morning { get; set; }
}