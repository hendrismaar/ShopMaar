using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ShopMaar.Core.Dto.OpenWeatherDtos
{
    public class OpenHeadlineDto
    {
        public string Main { get; set; }
        public string Description { get; set; }
        [JsonPropertyName("dt")]
        public DateTime Date { get; set; }
        public int Sunrise { get; set; }
        public int Sunset { get; set; }
        public int Moonrise { get; set; }
        public int Moonset { get; set; }
        [JsonPropertyName("moon_phase")]
        public decimal MoonPhase { get; set; }
        public string Summary { get; set; }
        public int Pressure { get; set; }
        public int Humidity { get; set; }
        [JsonPropertyName("dew_point")]
        public decimal DewPoint { get; set; }
        [JsonPropertyName("wind_speed")]
        public decimal WindSpeed { get; set; }
        [JsonPropertyName("wind_deg")]
        public int WindDegree { get; set; }
        [JsonPropertyName("wind_gust")]
        public decimal WindGust { get; set; }
        public int Clouds { get; set; }
        public decimal Pop { get; set; }
        public decimal Rain { get; set; }
        public decimal Uvi { get; set; }
    }
}
