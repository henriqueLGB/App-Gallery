using AppGallery.Xamarin_forms.Paginas.PaginaNavegacao;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new NavigationPage(new Conteudo01());

            //MainPage = new AppGallery.Xamarin_forms.Paginas.Modal.Conteudo01();

            //MainPage = new AppGallery.Xamarin_forms.Paginas.PaginaCarrousel.Carrousel();

            //MainPage = new AppGallery.Xamarin_forms.Paginas.PaginaAbas.Abas();

            //MainPage = new AppGallery.Xamarin_forms.Paginas.PaginaMenuLateral.MenuLateral();

            MainPage = new AppGallery.AppBase.Menu();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
