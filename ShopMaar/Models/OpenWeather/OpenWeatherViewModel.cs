namespace ShopMaar.Models.OpenWeather
{
    public class OpenWeatherViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Temp { get; set; }
        public double Feels_like { get; set; }
        public int Pressure { get; set; }
        public int Humidity { get; set; }
        public double Speed { get; set; }
    }
}
