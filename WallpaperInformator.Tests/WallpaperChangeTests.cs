using WallpaperInformator.WallpaperChanger;
using Xunit;

namespace WallpaperInformator.Tests
{
    public class WallpaperChangerShould
    {
        private readonly IWallpaperChange wallpaperchage;

        public WallpaperChangerShould()
        {
            wallpaperchage = new WallpaperChange();
        }

        [Fact]
        public void ChangeWallpaper()
        {
            wallpaperchage.SetMonitorWallpaper(1,@"d:\test.jpeg");
        }
    }
}