using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVVMWeatherApp.Core.POCO
{
    public class Data
    {
        public class Coord
        {
            [JsonProperty(PropertyName = "lon")]
            public double Lon { get; set; }
            [JsonProperty(PropertyName = "lat")]
            public double Lat { get; set; }
        }

        public class Weathers
        {
            [JsonProperty(PropertyName = "id")]
            public int Id { get; set; }
            [JsonProperty(PropertyName = "main")]
            public string Main { get; set; }
            [JsonProperty(PropertyName = "description")]
            public string Description { get; set; }
            [JsonProperty(PropertyName = "icon")]
            public string Icon { get; set; }
        }

        public class Main
        {
            [JsonProperty(PropertyName = "temp")]
            public double Temp { get; set; }
            [JsonProperty(PropertyName = "pressure")]
            public string Pressure { get; set; }
            [JsonProperty(PropertyName = "humidity")]
            public string Humidity { get; set; }
            [JsonProperty(PropertyName = "temp_min")]
            public double Temp_min { get; set; }
            [JsonProperty(PropertyName = "temp_max")]
            public double Temp_max { get; set; }
            [JsonProperty(PropertyName = "sea_level")]
            public double Sea_level { get; set; }
            [JsonProperty(PropertyName = "grnd_level")]
            public double Ground_level { get; set; }
        }

        public class Wind
        {
            [JsonProperty(PropertyName = "speed")]
            public string Speed { get; set; }
            [JsonProperty(PropertyName = "deg")]
            public double Deg { get; set; }

        }

        public class Clouds
        {
            [JsonProperty(PropertyName = "all")]
            public string All { get; set; }
        }

        public class Sys
        {
            [JsonProperty(PropertyName = "message")]
            public double Message { get; set; }
            [JsonProperty(PropertyName = "country")]
            public string Country { get; set; }
            [JsonProperty(PropertyName = "sunrise")]
            public int Sunrise { get; set; }
            [JsonProperty(PropertyName = "sunset")]
            public int Sunset { get; set; }
        }

        public class RootObject
        {
            [JsonProperty(PropertyName = "coord")]
            public Coord Coord { get; set; }
            [JsonProperty(PropertyName = "weather")]
            public List<Weathers> Weather { get; set; }
            [JsonProperty(PropertyName = "base")]
            public string Base { get; set; }
            [JsonProperty(PropertyName = "main")]
            public Main Main { get; set; }
            [JsonProperty(PropertyName = "lat")]
            public Wind Wind { get; set; }
            [JsonProperty(PropertyName = "clouds")]
            public Clouds Clouds { get; set; }
            [JsonProperty(PropertyName = "dt")]
            public int Dt { get; set; }
            [JsonProperty(PropertyName = "sys")]
            public Sys Sys { get; set; }
            [JsonProperty(PropertyName = "id")]
            public int Id { get; set; }
            [JsonProperty(PropertyName = "name")]
            public string Name { get; set; }
            [JsonProperty(PropertyName = "cod")]
            public int Cod { get; set; }
        }
    }
}
