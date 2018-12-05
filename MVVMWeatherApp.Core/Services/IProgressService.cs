using System;
using System.Collections.Generic;
using System.Text;

namespace MVVMWeatherApp.Core.Services
{
    public interface IProgressService
    {
        void Show(string Text = null);
        void Hide();
    }
}
