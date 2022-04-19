using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WallpaperInformator.DataAccess;
using WallpaperInformator.TextDraw;


namespace WallpaperConsole;

class Program
{
    private static IHost _hosting;

    public static IHost            Hosting  => _hosting ??= CreateHostBuilder(Environment.GetCommandLineArgs()).Build();
    public static IServiceProvider Services => Hosting.Services;

    private static IHostBuilder CreateHostBuilder(string[] args) => Host
                                                                   .CreateDefaultBuilder(args)
                                                                   .ConfigureServices(ConfigureServices);

    private static void ConfigureServices(HostBuilderContext host, IServiceCollection services)
    {
        services.AddHttpClient<OpenWeatherRepo>(client => client.BaseAddress = new Uri(host.Configuration["OpenWeatherBaseUrl"]));
    }

    public static async Task Main()
    {
        var weatherRepo = Services.GetRequiredService<OpenWeatherRepo>();
        // var weather     = await weatherRepo.GetWeather();
        // var location    = await weatherRepo.GetLocationByName("Paris");
        var weather = await weatherRepo.GetWeatherData();
        // TextDrawer textdrawer = new TextDrawer();
        // textdrawer.SetWallpaper();
       }
}