using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.Xamarin_forms.Controles.ImagemControle
{
    [ContentProperty(nameof(Source))]
    public class ImageResourceExtension : IMarkupExtension
    {
        public string Source { get; set; }  

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (serviceProvider == null) return null;

            return ImageSource.FromResource(Source, typeof(ImageResourceExtension).GetTypeInfo().Assembly);

        }
    }
}
