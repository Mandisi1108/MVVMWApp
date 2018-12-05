using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross.Platforms.Android.Views;
using MVVMWeatherApp.Core.ViewModels;

namespace MVVMWeatherApp.Droid.View
{
    [Activity(Label = "Weather", MainLauncher = false, Theme = "@style/AppTheme")]
    public class DetailsView : MvxActivity<DetailsViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.DetailsView);
            // Create your application here
        }
    }
}