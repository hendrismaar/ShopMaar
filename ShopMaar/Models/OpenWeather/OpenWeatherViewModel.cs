namespace ShopMaar.Models.OpenWeather
{
    public class OpenWeatherViewModel
    {
        public string Main { get; set; }
        public int Sunrise { get; set; }
        public int Sunset { get; set; }
        public int Moonrise { get; set; }
        public int Moonset { get; set; }
        public decimal MoonPhase { get; set; }
        public string Description { get; set; }
        public string Summary { get; set; }
        public DateTime Date { get; set; }
        public int Timezone { get; set; }
        public int Pressure { get; set; }
        public int Humidity { get; set; }
        public decimal DewPoint { get; set; }
        public decimal WindSpeed { get; set; }
        public int WindDegree { get; set; }
        public decimal WindGust { get; set; }
        public int Clouds { get; set; }
        public decimal Pop { get; set; }
        public decimal Rain { get; set; }
        public decimal Uvi { get; set; }

        public decimal Day { get; set; }
        public decimal Minimum { get; set; }
        public decimal Maximum { get; set; }
        public decimal Night { get; set; }
        public decimal Eve { get; set; }
        public decimal Morning { get; set; }
        
        
        public decimal FeelDay { get; set; }
        public decimal FeelNight { get; set; }
        public decimal FeelEve { get; set; }
        public decimal FeelMorning { get; set; }
        
        
        public int Id { get; set; }
        public string Icon { get; set; }
        
    }
}
