using System;
using Android.Content;
using Android.Runtime;
using Android.Views;
using DependencyService.Droid.Services;
using DependencyService.Services;
using Xamarin.Forms.Internals;

[assembly : Xamarin.Forms.Dependency(typeof(GetOrientationDroid))]
namespace DependencyService.Droid.Services
{
    public class GetOrientationDroid : IGetOrientation
    {
        public DeviceOrientation GetOrientation()
        {
            SurfaceOrientation orientation;
            using (IWindowManager manager = Android.App.Application.Context.GetSystemService(Context.WindowService).JavaCast<IWindowManager>())
            {
                orientation = manager.DefaultDisplay.Rotation;
            }

            bool islandscape = orientation == SurfaceOrientation.Rotation90 ||
                orientation == SurfaceOrientation.Rotation270;
            return islandscape ? DeviceOrientation.Landscape : DeviceOrientation.Portrait;

        }
    }
}
