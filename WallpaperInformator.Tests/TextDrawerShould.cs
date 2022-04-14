using WallpaperInformator.TextDraw;
using Xunit;

namespace WallpaperInformator.Tests;

public class TextDrawerShould
{
    private TextDrawer sit;

    public TextDrawerShould()
    {
        this.sit = new TextDrawer();
    }

    [Fact]
    public void SetWallpaper()
    {
       sit.SetWallpaper();

    }
}