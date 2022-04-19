using WallpaperInformator.Business.Models.OpenWeather;
using WallpaperInformator.DataAccess;

namespace WallpaperInformator.Business.Services;

public class OpenWeatherService
{
    private IOpenWeatherRepo _repo;
    private OpenWeatherModel _model;

    public OpenWeatherService(IOpenWeatherRepo repo)
    {
        _repo = repo;
    }

    public async Task<OpenWeatherModel> GetWeatherModelAsync()
    {
       return Task.Run(async () =>
        {
            var entity = await _repo.GetWeatherData();
             _model = MapFromEntity(entity);
             return _model;
        });


    }
}