using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.Xamarin_forms.Paginas.Modal
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Conteudo01 : ContentPage
	{
		public Conteudo01 ()
		{
			InitializeComponent ();
		}

        private void EventoPushModal(object sender, EventArgs e)
        {
			Navigation.PushModalAsync(new PaginaDeModal());
        }
    }
}