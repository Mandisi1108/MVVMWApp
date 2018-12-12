using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using MVVMWeatherApp.Core.Services;
using System.Threading.Tasks;

namespace MVVMWeatherApp.Core.ViewModels
{
    public class WeatherViewModel : MvxViewModel
    {
        private readonly IWeatherService _weatherService;
        private readonly IMvxNavigationService _navigationService;
        private readonly ISystemCacheService _systemCacheService;

        public WeatherViewModel(IWeatherService weatherService, IMvxNavigationService mvxNavigationService,
                                ISystemCacheService systemCacheService)
        {
            _weatherService = weatherService;
            _navigationService = mvxNavigationService;
            _systemCacheService = systemCacheService;

            ButtonCommand = new MvxAsyncCommand(DoButtonCommand, CanDoButton); 
        }

        private string _cityName;
        public string CityName
        {
            get { return _cityName; }
            set
            {
                SetProperty(ref _cityName, value);
                ButtonCommand.RaiseCanExecuteChanged();   
            }
        }

        public MvxAsyncCommand ButtonCommand { get; }
        private async Task DoButtonCommand()
        {
            try
            {
                var res = await _weatherService.GetWeather(CityName);
                if(res != null)
                {
                    _systemCacheService.Weather = res;
                    await _navigationService.Navigate<DetailsViewModel>();
                }
            }
            finally
            {
            }
        }
        private bool CanDoButton()
        {
            return !string.IsNullOrEmpty(CityName);
        }
    }
}
