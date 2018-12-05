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
using Android.App;

namespace MVVMWeatherApp.Droid.Views
{
    [Activity(Label = "DetailsView", MainLauncher = true)]
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