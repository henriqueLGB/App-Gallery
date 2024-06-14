using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.Xamarin_forms.Controles.Checkbox
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Checkbox : ContentPage
    {
        public Checkbox()
        {
            InitializeComponent();
        }

        private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            lblInformativo.Text = (e.Value ? "Marcado" : "Desmarcado");
        }
    }
}