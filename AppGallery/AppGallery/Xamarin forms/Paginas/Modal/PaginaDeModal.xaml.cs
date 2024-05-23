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
	public partial class PaginaDeModal : ContentPage
	{
		public PaginaDeModal ()
		{
			InitializeComponent ();
		}

        private void EventoFecharModal(object sender, EventArgs e)
        {
			Navigation.PopModalAsync();
        }
    }
}