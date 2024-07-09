using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;
using AppGallery.Xamarin_forms.Controles.VisualizacaoWeb;
using AppGallery.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(BaseUrl_Android))]
namespace AppGallery.Droid
{
    public class BaseUrl_Android : IBaseUrl
    {
        public string Get()
        {
            return "file:///android_asset/";
        }
    }
}