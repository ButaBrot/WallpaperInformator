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
        private readonly IDesktopWallpaper _desktopWallpaper;

        public WallpaperChange()
        {
            _desktopWallpaper = (IDesktopWallpaper)new DesktopWallpaper();
        }

        public void SetMonitorWallpaper(int monitorIndex, string pathToWallpaper)
        {
            var monitorId = GetMonitorDevicePath((uint)monitorIndex);
            SetWallpaper(pathToWallpaper,monitorId);
        }
        private void SetWallpaper(string pathToWallpaper, string monitorID)
        {
            _desktopWallpaper.SetWallpaper(monitorID, pathToWallpaper);
        }

        private string GetMonitorDevicePath(uint monitorIndex)
        {
            _desktopWallpaper.GetMonitorDevicePathAt(monitorIndex, out PWSTR monitorIdNative);
            return monitorIdNative.ToString();
        }
    }
}