using Microsoft.AspNetCore.Mvc;
using ShopMaar.ApplicationServices.Services;
using ShopMaar.Core.Dto.OpenWeatherDtos;
using ShopMaar.Core.ServiceInterface;
using ShopMaar.Models.OpenWeather;


namespace ShopMaar.Controllers
{
    public class OpenWeatherController : Controller
    {
        private readonly IWeatherForecastsServices _weatherForecastServices;
        public OpenWeatherController(IWeatherForecastsServices weatherForecastServices)
        {
            _weatherForecastServices = weatherForecastServices;
        }
        public IActionResult Index()
        {
            OpenWeatherViewModel vm = new OpenWeatherViewModel();
            return View(vm);
        }

        [HttpPost]
        public IActionResult ShowOpenWeather()
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("OpenCity", "OpenWeather");
            }
            return View();
        }

        [HttpGet]
        public IActionResult OpenCity()
        {
            OpenWeatherResultDto dto = new();
            OpenWeatherViewModel vm = new();

            _weatherForecastServices.OpenWeatherDetail(dto);

            vm.City = dto.City;
            vm.Description = dto.Description;
            vm.Temp = dto.Temp;
            vm.Feels_like = dto.Feels_like;
            vm.Pressure = dto.Pressure;
            vm.Humidity = dto.Humidity;
            vm.Speed = dto.Speed;

            return View(vm);
        }
    }
}
