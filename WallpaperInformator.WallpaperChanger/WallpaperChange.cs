using Microsoft.Win32;
using Windows.Win32;
using Windows.Win32.Foundation;
using Windows.Win32.UI.Shell;

namespace WallpaperInformator.WallpaperChanger
{
    public interface IWallpaperChange
    {
        void SetMonitorWallpaper(int monitorIndex, string pathToWallpaper);
    }

    public class WallpaperChange : IWallpaperChange
    {
        private IDesktopWallpaper desktopWallpaper;

        public WallpaperChange()
        {
            desktopWallpaper = (IDesktopWallpaper)new DesktopWallpaper();
        }

        public void SetMonitorWallpaper(int monitorIndex, string pathToWallpaper)
        {
            string monitorId = GetMonitorDevicePath((uint)monitorIndex);
            SetWallpaper(pathToWallpaper,monitorId);
        }
        private void SetWallpaper(string pathToWallpaper, string monitorID)
        {
            desktopWallpaper.SetWallpaper(monitorID, pathToWallpaper);
        }

        private string GetMonitorDevicePath(uint monitorIndex)
        {
            desktopWallpaper.GetMonitorDevicePathAt(monitorIndex, out PWSTR monitorIdNative);
            return monitorIdNative.ToString();
        }
    }
}