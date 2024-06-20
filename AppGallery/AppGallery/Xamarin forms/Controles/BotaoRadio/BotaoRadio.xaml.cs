using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.Xamarin_forms.Controles.BotaoRadio
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BotaoRadio : ContentPage
	{
		public BotaoRadio()
		{
			InitializeComponent ();
		}

        private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            lblInformativo.Text = "Texto: " + ((RadioButton)sender).Content + " Valor: " + e.Value.ToString(); 
        }
    }
}