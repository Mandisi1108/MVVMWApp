using MVVMWeatherApp.Core.POCO;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace MVVMWeatherApp.Core.Services
{
    class WeatherService : IWeatherService
    {
        private const string BaseUrl = "https://api.openweathermap.org/data/2.5/weather?q=";
        private const string Key = "&units=metric&appid=6bf0f2da1228fb3ed7d694d44639e73c";
        private readonly HttpClient httpClient;

        public WeatherService()
        {
            httpClient = new HttpClient();
        }

        public async Task<Data.RootObject> GetWeather(string cityName)
        {
            Data.RootObject result = null;
            try
            {
                var link = BaseUrl + cityName + Key;
                var json = await httpClient.GetAsync(link);
                if (json.IsSuccessStatusCode)
                {
                    var jsonContent = await json.Content.ReadAsStringAsync();
                    result = JsonConvert.DeserializeObject<Data.RootObject>(jsonContent);
                }
            }
            catch (System.Exception)
            {
                
            }
            return result;
        }
    }
}
