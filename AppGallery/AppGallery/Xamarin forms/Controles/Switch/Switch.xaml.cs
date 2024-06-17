using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.Xamarin_forms.Controles.Switch
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Switch : ContentPage
	{
		public Switch ()
		{
			InitializeComponent ();
		}

        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
			lblInformativo.Text = e.Value ? "Marcado" : "Desmarcado";
        }
    }
}