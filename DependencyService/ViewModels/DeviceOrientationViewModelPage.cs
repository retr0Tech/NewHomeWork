using System.Windows.Input;
using Xamarin.Forms;

namespace DependencyServiceHW.ViewModels
{
    public class DeviceOrientationViewModelPage
    {
        public ICommand getOrientation { get; set; }
        public DeviceOrientationViewModelPage()
        {
            getOrientation = new Command(() =>
            {
                //Ige service = DependencyService.Get<IGetOrientation>();
            });
        }
    }
}
