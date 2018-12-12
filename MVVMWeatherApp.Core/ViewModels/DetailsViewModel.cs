using MvvmCross.ViewModels;
using MVVMWeatherApp.Core.POCO;
using MVVMWeatherApp.Core.Services;
using System;
using System.Collections.Generic;
using Java.Sql;
using Java.Text;

namespace MVVMWeatherApp.Core.ViewModels
{
    public class DetailsViewModel : MvxViewModel
    {
        private readonly ISystemCacheService _systemCacheService;
        readonly string _imageUrl = "http://openweather.org/img/w";
        public DetailsViewModel(ISystemCacheService systemCacheService)
        {
            _systemCacheService = systemCacheService;
            ItemsWeather = new List<ItemWeather>();
        }

        public string CityName { get; private set; }
        public string Country { get; private set; }
        public string Temperature { get; private set; }
        public string Description { get; private set; }
        public string Icon { get; private set; }
        public string IconUrl { get; private set; }
        public string Date_Time { get; private set; }
        public string Cloudiness { get; private set; }
        public string Wind { get; private set; }
        public string Pressure { get; private set; }
        public string Humidity { get; private set; }
        public string Sunrise { get; private set; }
        public string Sunset { get; private set; }
        public string Coords { get; private set; }

        public List <ItemWeather> ItemsWeather { get; private set; }

        public override void Start()
        {
            base.Start();
            var data = _systemCacheService.Weather;
            CityName = "Weather in " + data.Name + ", " + data.Sys.Country;
            Icon = data.Weather[0].Icon;
            IconUrl = _imageUrl + Icon + ".png";
            Temperature = data.Main.Temp + " \u2103";
            Date _date = new Date(Convert.ToInt64(data.Dt) * 1000);
            SimpleDateFormat _sd = new SimpleDateFormat("yyyy/MM/dd HH:mm");
            Date_Time = _sd.Format(_date).ToString();
            Description = data.Weather[0].Description + "\nUpdated at" + Date_Time;
            Wind = data.Wind.Speed;
            Cloudiness = data.Clouds.All;
            Pressure = data.Main.Pressure;
            Humidity = data.Main.Humidity;
            Date _dtsr = new Date(Convert.ToInt64(data.Sys.Sunrise) * 1000);
            SimpleDateFormat _sdsr = new SimpleDateFormat("HH:mm");
            Sunrise = _sdsr.Format(_dtsr).ToString();

            Date _dtss = new Date(Convert.ToInt64(data.Sys.Sunset) * 1000);
            SimpleDateFormat _sdss = new SimpleDateFormat("HH:mm");
            Sunset = _sdss.Format(_dtss).ToString();
            Coords = "[" + data.Coord.Lat + ", " + data.Coord.Lon + "]";

            ItemsWeather.Add(new ItemWeather("Wind: ", Wind + " km/h"));
            ItemsWeather.Add(new ItemWeather("Cloudiness: ", Cloudiness + " %"));
            ItemsWeather.Add(new ItemWeather("Pressure: ", Pressure + " hpa"));
            ItemsWeather.Add(new ItemWeather("Humidity: ", Humidity + " %"));
            ItemsWeather.Add(new ItemWeather("Sunrise: ", Sunrise));
            ItemsWeather.Add(new ItemWeather("Sunset: ", Sunset));
            ItemsWeather.Add(new ItemWeather("Geo coords: ", Coords));
        }
    }
}
