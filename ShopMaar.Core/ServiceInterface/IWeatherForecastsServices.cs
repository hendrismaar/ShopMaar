using ShopMaar.Core.Dto.OpenWeatherDtos;
using ShopMaar.Core.Dto.WeatherDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopMaar.Core.ServiceInterface
{
    public interface IWeatherForecastsServices
    {
        Task<WeatherResultDto> WeatherDetail(WeatherResultDto dto);
        Task<OpenWeatherResultDto> OpenWeatherDetail(OpenWeatherResultDto dto);

    }
}
