using System.Security.Cryptography.X509Certificates;
using SkiaSharp;
using Topten.RichTextKit;
using WallpaperInformator.WallpaperChanger;

namespace WallpaperInformator.TextDraw;

public class TextDrawer
{
    private RichString SetText(string text)
    {
        return new RichString()
            .Alignment(TextAlignment.Center)
            .TextColor(SKColors.DimGray)
            .FontFamily("Inverkrug")
            .FontSize(80)
            .Add($"{text}");
    }

    private SKData GetSKImage(RichString text)
    {
        var sizeInfo = new SKImageInfo(1920, 1080);
        using var surface = SKSurface.Create(sizeInfo);
        var canvas = surface.Canvas;
        canvas.Clear(SKColors.CadetBlue);
        var skPoint = new SKPoint((sizeInfo.Width - text.MeasuredWidth) / 2,
            (sizeInfo.Height - text.MeasuredHeight )/ 2);
        text.Paint(canvas, skPoint);
        using var image = surface.Snapshot();
        return image.Encode(SKEncodedImageFormat.Png, 100);
    }

    private void SaveImage(SKData SKdata, string path)
    {
        using (var stream = File.Create(path))
        {
            SKdata.SaveTo(stream);
        }
    }

    public void SetWallpaper()
    {
        var testText = DateTime.Now.ToLongDateString() + Environment.NewLine + DateTime.Now.ToShortTimeString();
        var testPath = @"d:\testSK.png";
        var richText = SetText(testText);
        var skImage = GetSKImage(richText);
        SaveImage(skImage, testPath);

        var wallpaperChanger = new WallpaperChange();
        wallpaperChanger.SetMonitorWallpaper(0, testPath);
    }
}