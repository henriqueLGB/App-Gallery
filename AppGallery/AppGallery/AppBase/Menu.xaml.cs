using System;
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

        private void AbrirStackLayout(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new Xamarin_forms.Layouts.PilhaLayout.Pilha();
            ((FlyoutPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirGradeLayout(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new Xamarin_forms.Layouts.GradeLayout.Grade();
            ((FlyoutPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirAbsoluteLayout(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new Xamarin_forms.Layouts.AbsoluteLayout.Absoluto();
            ((FlyoutPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirRelativeLayout(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new Xamarin_forms.Layouts.RelativeLayout.RelativeLayout();
            ((FlyoutPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirFlexLayout(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new Xamarin_forms.Layouts.FlexivelLayout.Flexivel();
            ((FlyoutPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirScrollView(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new Xamarin_forms.Layouts.BarraDeRolagemLayout.BarraDeRolagem();
            ((FlyoutPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirControleView(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new Xamarin_forms.Layouts.ControleLayout.Controle();
            ((FlyoutPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirFrame(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new Xamarin_forms.Layouts.QuadradoLayout.Quadrado();
            ((FlyoutPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirBoxView(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new Xamarin_forms.Controles.BoxView.Caixa());
            ((FlyoutPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirLabel(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new Xamarin_forms.Controles.Label.Label());
            ((FlyoutPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirButton(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new Xamarin_forms.Controles.Button.Button());
            ((FlyoutPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirImgButton(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new Xamarin_forms.Controles.ImageButton.ImageButton());
            ((FlyoutPage)App.Current.MainPage).IsPresented = false;
        }
    }
}