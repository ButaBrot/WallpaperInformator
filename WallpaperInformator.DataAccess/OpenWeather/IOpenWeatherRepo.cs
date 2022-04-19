using WallpaperInformator.DataAccess.Entities;

namespace WallpaperInformator.DataAccess;

public interface IOpenWeatherRepo
{
    Task<OpenWeatherEntity> GetWeatherData();
}