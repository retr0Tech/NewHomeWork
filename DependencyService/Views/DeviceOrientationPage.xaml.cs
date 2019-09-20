using System;
using System.Collections.Generic;
using DependencyServiceHW.ViewModels;
using Xamarin.Forms;

namespace DependencyServiceHW.Views
{
    public partial class DeviceOrientationPage : ContentPage
    {
        public DeviceOrientationPage()
        {
            InitializeComponent();
            BindingContext = new DeviceOrientationViewModelPage();
        }
    }
}
