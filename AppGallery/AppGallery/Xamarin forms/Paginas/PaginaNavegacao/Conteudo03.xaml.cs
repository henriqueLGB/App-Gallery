using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.Xamarin_forms.Paginas.PaginaNavegacao
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Conteudo03 : ContentPage
    {
        public Conteudo03()
        {
            InitializeComponent();
        }

        private void EventoVoltar(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void EventoVoltarParaInicio(object sender, EventArgs e)
        {
            Navigation.PopToRootAsync();
        }

        private void EventoInserirPilha(object sender, EventArgs e)
        {
            Navigation.InsertPageBefore(
                new PaginaInserida(),
                this
            );
        }

        private void EventoRemoverPilha(object sender, EventArgs e)
        {
            Navigation.RemovePage(Navigation.NavigationStack[0]);
        }

        //Não Deixa voltar através do botão do android/ios
        protected override bool OnBackButtonPressed()
        {
            return true;
        }

    }
}