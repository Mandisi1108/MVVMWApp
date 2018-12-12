namespace MVVMWeatherApp.Core.Services
{
    public interface IProgressService
    {
        void Show(string Text = null);
        void Hide();
    }
}
