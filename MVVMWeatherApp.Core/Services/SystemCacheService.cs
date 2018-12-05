using MvvmCross;
using MVVMWeatherApp.Core.POCO;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVVMWeatherApp.Core.Services
{
    public class SystemCacheService : ISystemCacheService
    {
        public Data.RootObject Weather { get; set; }
    }
}
