using System;
using System.Collections.Generic;
using System.Text;
using MvvmCross;
using MvvmCross.ViewModels;
using MVVMWeatherApp.Core.Services;
using MVVMWeatherApp.Core.ViewModels;
using MvvmCross.IoC;

namespace MVVMWeatherApp.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            Mvx.IoCProvider.RegisterType<IWeatherService, WeatherService>();
            Mvx.IoCProvider.LazyConstructAndRegisterSingleton<ISystemCacheService, SystemCacheService>();
            RegisterAppStart<WeatherViewModel>();
        }
    }
}
