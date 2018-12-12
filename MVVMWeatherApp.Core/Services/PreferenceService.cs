using MVVMWeatherApp.Core.Enum;
using Xamarin.Essentials;

namespace MVVMWeatherApp.Core.Services
{
    public class PreferenceService : IPreferenceService
    {
        public string GetValue(PreferenceType Key)
        {
            return Preferences.Get(Key.ToString(), string.Empty);
        }

        public void SaveValue(PreferenceType preferenceType, string Value)
        {
            Preferences.Set(preferenceType.ToString(), Value);
        }
    }
}
