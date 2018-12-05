using MVVMWeatherApp.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVVMWeatherApp.Core.Services
{
    public interface IPreferenceService
    {
        void SaveValue(PreferenceType Key, string Value);
        string GetValue(PreferenceType Key);
    }
}
