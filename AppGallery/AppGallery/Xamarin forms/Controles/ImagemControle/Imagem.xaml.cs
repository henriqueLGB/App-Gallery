using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.Xamarin_forms.Controles.ImagemControle
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Imagem : ContentPage
	{
		public Imagem ()
		{
			InitializeComponent ();

			//ResourceID = AppGallery.XamarinForms.Controles.Imagem.background.png 
			//Imagem01.Source = ImageSource.FromResource("AppGallery.Xamarin_forms.Controles.ImagemControle.background.png");

			//Download ->  System.IO (Stream)
			//Imagem01.Source = ImageSource.FromStream(Sytem.IO.Stream);
		}
	}
}