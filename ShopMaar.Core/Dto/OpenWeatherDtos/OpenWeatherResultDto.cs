﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ShopMaar.Core.Dto.OpenWeatherDtos
{
    public class OpenWeatherResultDto
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
