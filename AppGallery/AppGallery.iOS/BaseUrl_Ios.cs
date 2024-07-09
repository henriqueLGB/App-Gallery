using AppGallery.iOS;
using AppGallery.Xamarin_forms.Controles.VisualizacaoWeb;
using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;

[assembly: Xamarin.Forms.Dependency(typeof(BaseUrl_Ios))]
namespace AppGallery.iOS
{
    public class BaseUrl_Ios : IBaseUrl
    {
        public string Get()
        {
            return NSBundle.MainBundle.BundlePath;
        }
    }
}