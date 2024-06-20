using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.Xamarin_forms.Controles.AtualizaControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Atualiza : ContentPage
    {
        public Atualiza()
        {
            InitializeComponent();
        }

        private void RefreshView_Refreshing(object sender, EventArgs e)
        {
            lblStatus.Text = $"Atualizado: {DateTime.Now.ToString("dd/MM/yyyy")}";

            ((RefreshView)sender).IsRefreshing = false;
        }
    }
}