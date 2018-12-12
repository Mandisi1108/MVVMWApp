using MVVMWeatherApp.Core.POCO;

namespace MVVMWeatherApp.Core.Services
{
    public class SystemCacheService : ISystemCacheService
    {
        public Data.RootObject Weather { get; set; }
    }
}
