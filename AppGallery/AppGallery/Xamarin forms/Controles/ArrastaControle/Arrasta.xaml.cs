using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.Xamarin_forms.Controles.ArrastaControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Arrasta : ContentPage
    {
        public Arrasta()
        {
            InitializeComponent();
        }

        private void SwipeDetalhe(object sender, EventArgs e)
        {
            lblDetalhe.Text = $"Acionado Detalhe: {DateTime.Now.ToString("dd/MM/yyyy")}";
        }

        private void SwipeEditar(object sender, EventArgs e)
        {
            lblEditar.Text = $"Acionado Editar: {DateTime.Now.ToString("dd/MM/yyyy")}";
        }

        private void SwipeExcluir(object sender, EventArgs e)
        {
            lblExcluir.Text = $"Acionado Excluir: {DateTime.Now.ToString("dd/MM/yyyy")}";
        }

        private void SwipeStart(object sender, SwipeStartedEventArgs e)
        {
            lblStart.Text = $"Acionado SwipeStart: {DateTime.Now.ToString("dd/MM/yyyy")} - {e.SwipeDirection}";
        }

        private void SwipeChanged(object sender, SwipeChangingEventArgs e)
        {
            lblChange.Text = $"Acionado SwipeChanged: {DateTime.Now.ToString("dd/MM/yyyy")} - {e.SwipeDirection}:{e.Offset}";
        }

        private void SwipeEnded(object sender, SwipeEndedEventArgs e)
        {
            lblEnded.Text = $"Acionado SwipeEnded: {DateTime.Now.ToString("dd/MM/yyyy")} - {e.SwipeDirection}";
        }

        private void FecharSwipe(object sender, EventArgs e)
        {
            SwipeViewControle.Close();
        }
    }
}