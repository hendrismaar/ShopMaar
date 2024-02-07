using Newtonsoft.Json;
using ShopMaar.Core.Dto.WeatherDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopMaar.Core.Dto.OpenWeatherDtos
{
    public class OpenWeatherRootDto
    {
        [JsonProperty("coord")]
        public Coord Coord { get; set; }
        [JsonProperty("weather")]
        public List<Weather> Weather { get; set; }
        [JsonProperty("@base")]
        public string @base { get; set; }
        [JsonProperty("main")]
        public Main Main { get; set; }
        [JsonProperty("visibility")]
        public int Visibility { get; set; }
        [JsonProperty("wind")]
        public Wind Wind { get; set; }
        [JsonProperty("rain")]
        public Rain Rain { get; set; }
        [JsonProperty("clouds")]
        public Clouds Clouds { get; set; }
        [JsonProperty("dt")]
        public int Dt { get; set; }
        [JsonProperty("sys")]
        public Sys Sys { get; set; }
        [JsonProperty("timezone")]
        public int Timezone { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("cod")]
        public int Cod { get; set; }
    }
    public class Clouds
    {
        [JsonProperty("all")]
        public int All { get; set; }
    }

    public class Coord
    {
        [JsonProperty("lon")]
        public double Lon { get; set; }
        [JsonProperty("lat")]
        public double Lat { get; set; }
    }

    public class Main
    {
        [JsonProperty("temp")]
        public double Temp { get; set; }
        [JsonProperty("feels_like")]
        public double Feels_like { get; set; }
        [JsonProperty("temp_min")]
        public double Temp_min { get; set; }
        [JsonProperty("temp_max")]
        public double Temp_max { get; set; }
        [JsonProperty("pressure")]
        public int Pressure { get; set; }
        [JsonProperty("humidity")]
        public int Humidity { get; set; }
        [JsonProperty("sea_level")]
        public int Sea_level { get; set; }
        [JsonProperty("grnd_level")]
        public int Grnd_level { get; set; }
    }

    public class Rain
    {
        [JsonProperty("1h")]
        public double _1h { get; set; }
    }

    public class Sys
    {
        [JsonProperty("type")]
        public int Type { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("country")]
        public string Country { get; set; }
        [JsonProperty("sunrise")]
        public int Sunrise { get; set; }
        [JsonProperty("sunset")]
        public int Sunset { get; set; }
    }

    public class Weather
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("main")]
        public string Main { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("icon")]
        public string Icon { get; set; }
    }

    public class Wind
    {
        [JsonProperty("speed")]
        public double Speed { get; set; }
        [JsonProperty("deg")]
        public int Deg { get; set; }
        [JsonProperty("gust")]
        public double Gust { get; set; }
    }
}
