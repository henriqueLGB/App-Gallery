using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.Xamarin_forms.Controles.RadioButton
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RadioButton : ContentPage
	{
		public RadioButton ()
		{
			InitializeComponent ();
		}

        private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            lblInformativo.Text =  e.Value.ToString();
        }
    }
}