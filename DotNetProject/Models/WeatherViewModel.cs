﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetProject.Models
{
    public class WeatherViewModel
    {
        public String City { get; set; }
        public String Temperature { get; set; }
        public String HighTemp { get; set; }
        public String LowTemp { get; set; }
        public String Condition { get; set; }
        public String ImageURL { get; set; }
    }
}
