using System;
using MVVMWeatherApp.Core.Enums;

namespace MVVMWeatherApp.Core.Services
{
    public class PreferenceService : IPreferenceService
    {
        public string GetValue(PreferenceType Key)
        {
            return Preference.Get(Key.ToString, string.Empty);
        }

        public void SaveValue(PreferenceType preferenceType, string Value)
        {
            Preference.Set(preferenceType.ToString(), Value);
        }
    }
}
