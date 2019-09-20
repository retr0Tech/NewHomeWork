using System;
using Xamarin.Forms.Internals;

namespace DependencyService.Services
{
    public interface IGetOrientation
    {
        DeviceOrientation GetOrientation();
    }
}
