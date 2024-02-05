using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ShopMaar.Core.Dto.OpenWeatherDtos
{
    public class DailyOpenForecastDto
    {
        public Temperature Temperature { get; set; }
        public FeelsLike FeelsLike { get; set; }
        public Weather Weather { get; set; }
    }
    public class Temperature
    {
        public decimal Day { get; set; }
        [JsonPropertyName("min")]
        public decimal Minimum { get; set; }
        [JsonPropertyName("max")]
        public decimal Maximum { get; set; }
        public decimal Night { get; set; }
        public decimal Eve { get; set; }
        [JsonPropertyName("morn")]
        public decimal Morning { get; set; }
    }
    public class FeelsLike
    {
        public decimal FeelDay { get; set; }
        public decimal FeelNight { get; set; }
        public decimal FeelEve { get; set; }
        [JsonPropertyName("morn")]
        public decimal FeelMorning { get; set; }
    }
    public class Weather
    {
        public int Id { get; set; }
        public string Icon { get; set; }
    }
}
