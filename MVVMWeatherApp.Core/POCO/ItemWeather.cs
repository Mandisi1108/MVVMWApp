﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MVVMWeatherApp.Core.POCO
{
    public class ItemWeather
    {
        public ItemWeather(string title, string value)
        {
            Title = title;
            Value = value;
        }
        public string Title { get; }
        public string Value { get; }
    }
}
