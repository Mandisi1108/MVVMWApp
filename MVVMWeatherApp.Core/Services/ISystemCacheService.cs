using MVVMWeatherApp.Core.POCO;

namespace MVVMWeatherApp.Core.Services
{
    public interface ISystemCacheService
    {
        Data.RootObject Weather { get; set; }
    }
}
