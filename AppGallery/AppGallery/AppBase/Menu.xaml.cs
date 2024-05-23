﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.AppBase
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Menu : FlyoutPage
    {
		public Menu ()
		{
			InitializeComponent ();
		}

        private void AbrirContentPage(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new Xamarin_forms.Paginas.PaginasConteudo.Conteudo01();
            ((FlyoutPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirNavigationPage(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new Xamarin_forms.Paginas.PaginaNavegacao.Conteudo01());
            ((FlyoutPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirCarrousel(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new Xamarin_forms.Paginas.PaginaCarrousel.Carrousel();
            ((FlyoutPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirTabbedPage(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new Xamarin_forms.Paginas.PaginaAbas.Abas();
            ((FlyoutPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirFlyoutPage(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new Xamarin_forms.Paginas.PaginaMenuLateral.MenuLateral();
            ((FlyoutPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirModal(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new Xamarin_forms.Paginas.Modal.Conteudo01();
            ((FlyoutPage)App.Current.MainPage).IsPresented = false;
        }
    }
}