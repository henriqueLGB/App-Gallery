using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace AppGallery.Xamarin_forms.Controles.Arrastar
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Arrasta : ContentPage
    {
        public Arrasta()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblValueChanged.Text = "Valor antigo: " + e.OldValue.ToString() + " Valor Novo: " + e.NewValue.ToString();   
        }

        private void Slider_DragStarted(object sender, EventArgs e)
        {
            lblDragStarted.Text = "Iniciou o arrasto !";
        }

        private void Slider_DragCompleted(object sender, EventArgs e)
        {
            lblDragCompleted.Text = "Terminou de arrastar !";
        }

        private void Slider_ValueChanged_Step(object sender, ValueChangedEventArgs e)
        {
            int passos = 1;
            double novoPasso = Math.Round(e.NewValue / passos);

            ((Xamarin.Forms.Slider)sender).Value = novoPasso * passos;

            lblValueChangedStep.Text = ((Xamarin.Forms.Slider)sender).Value.ToString();
        }
    }
}