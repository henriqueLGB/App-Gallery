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

        private void AbrirImagem(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new Xamarin_forms.Controles.ImagemControle.Imagem());
            ((FlyoutPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirEntry(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new Xamarin_forms.Controles.Entry.Entry());
            ((FlyoutPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirEditor(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new Xamarin_forms.Controles.Editor.Editor());
            ((FlyoutPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirCheckbox(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new Xamarin_forms.Controles.Checkbox.Checkbox());
            ((FlyoutPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirRadioButton(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new Xamarin_forms.Controles.BotaoRadio.BotaoRadio());
            ((FlyoutPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirSwitch(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new Xamarin_forms.Controles.Switch.Switch());
            ((FlyoutPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirStepper(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new Xamarin_forms.Controles.Stepper.Stepper());
            ((FlyoutPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirSlider(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new Xamarin_forms.Controles.Arrastar.Arrasta());
            ((FlyoutPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirPicker(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new Xamarin_forms.Controles.Seletor.Seletor());
            ((FlyoutPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirDatePicker(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new Xamarin_forms.Controles.DataSelecao.DataSelecao());
            ((FlyoutPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirTimePicker(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new Xamarin_forms.Controles.SeletorTempo.SelectorTime());
            ((FlyoutPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirActivity(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new Xamarin_forms.Controles.IndicadorAtividade.IndificadorAtividade());
            ((FlyoutPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirProgressBar(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new Xamarin_forms.Controles.BarraProgresso.BarraDeProgresso());
            ((FlyoutPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirSearchBar(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new Xamarin_forms.Controles.BarraPesquisa.BarraDePesquisa());
            ((FlyoutPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirRefreshView(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new Xamarin_forms.Controles.AtualizaControle.Atualiza());
            ((FlyoutPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirSwipeView(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new Xamarin_forms.Controles.ArrastaControle.Arrasta());
            ((FlyoutPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirWebView(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new Xamarin_forms.Controles.VisualizacaoWeb.VisualizacaoWeb());
            ((FlyoutPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirMediaElement(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new Xamarin_forms.Controles.MediaElemento.MediaElemento());
            ((FlyoutPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirExpander(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new Xamarin_forms.Controles.ExpansorControle.Expansor());
            ((FlyoutPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirTableView(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new Xamarin_forms.Listas.TabelaControle.Tabela());
            ((FlyoutPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirListView(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new Xamarin_forms.Listas.ListaControle.Lista());
            ((FlyoutPage)App.Current.MainPage).IsPresented = false;
        }
    }
}