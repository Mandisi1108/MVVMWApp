using MVVMWeatherApp.Core.POCO;
using System.Threading.Tasks;

namespace MVVMWeatherApp.Core.Services
{   //Business logic
    public interface IWeatherService
    {
        Task<Data.RootObject> GetWeather(string cityName);
    }
}
