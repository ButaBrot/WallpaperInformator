﻿using System.Text.Json.Serialization;

namespace WallpaperInformator.DataAccess.Entities;

public class Location : Entity
{
   [JsonPropertyName("name")] public string Name    { get; set; }
   [JsonPropertyName("lat")] public double Latitude     { get; set; }
   [JsonPropertyName("lon")] public double Longitude     { get; set; }
   [JsonPropertyName("country")] public string Country { get; set; }
   [JsonPropertyName("state")] public string State   { get; set; }
}