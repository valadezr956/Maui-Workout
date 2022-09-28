using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutApp
{
    public static class AppLocator
    {
        public static HomeViewModel HomeViewModel => Locator.Current.GetService<HomeViewModel>();
        public static double DisplayHeight { get; set; }

        public static void Initialize()
        {
            Locator.CurrentMutable.Register(() => new HomeViewModel());
            //DisplayHeight = (DeviceDisplay.Current.MainDisplayInfo.Height / DeviceDisplay.Current.MainDisplayInfo.Density)-130;
        }
    }
}
