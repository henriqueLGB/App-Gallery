using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.Xamarin_forms.Controles.Stepper
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Stepper : ContentPage
	{
		public Stepper ()
		{
			InitializeComponent ();
		}

        private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
			lblInformativo.Text = "Valor antigo: " + e.OldValue.ToString() + " -> Valor Novo: " + e.NewValue.ToString();
        }
    }
}