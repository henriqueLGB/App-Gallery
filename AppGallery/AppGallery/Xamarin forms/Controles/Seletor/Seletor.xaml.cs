using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.Xamarin_forms.Controles.Seletor
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Seletor : ContentPage
    {
        public Seletor()
        {
            InitializeComponent();
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblInformativo.Text = ((Picker)sender).SelectedIndex + " - " + ((Picker)sender).SelectedItem;
        }

        private void LimparPicker(object sender, EventArgs e)
        {
            PickerMarca.SelectedIndex = -1;
            lblInformativo.Text = "";
        }
    }
}