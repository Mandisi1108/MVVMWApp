using MVVMWeatherApp.Core.Enum;

namespace MVVMWeatherApp.Core.Services
{
    public interface IPreferenceService
    {
        void SaveValue(PreferenceType Key, string Value);
        string GetValue(PreferenceType Key);
    }
}
