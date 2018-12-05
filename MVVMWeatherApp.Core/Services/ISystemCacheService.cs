using MVVMWeatherApp.Core.POCO;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVVMWeatherApp.Core.Services
{
    public interface ISystemCacheService
    {
        Data.RootObject Weather { get; set; }
    }
}
