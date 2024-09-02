using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.Xamarin_forms.Listas.ListaControle
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Lista : ContentPage
	{

		public Lista ()
		{
			InitializeComponent ();

			Lista01.ItemsSource = GetMarcas();

		}

        private List<Marca> GetMarcas()
        {
            return new List<Marca>()
            {
                GetListaCarrosFiat(),
                GetListaCarrosFord()
            };

        }

        private Marca GetListaCarrosFiat()
		{
			var fiat = new Marca()
			{
				new Carro{Nome = "Mobi", Motorizacao = "1.0", Descricao = "Aventura não vai faltar", ItemsDeSerie = "Air-bags"},
                new Carro{Nome = "Uno", Motorizacao = "1.0", Descricao = "Aventura não vai faltar",ItemsDeSerie = "Air-bags"},
                new Carro{Nome = "Argo", Motorizacao = "1.0", Descricao = "Aventura não vai faltar",ItemsDeSerie = "Air-bags"},
                new Carro{Nome = "Crono", Motorizacao = "1.0", Descricao = "Aventura não vai faltar", ItemsDeSerie = "Air-bags"},
                new Carro{Nome = "Toro", Motorizacao = "1.0", Descricao = "Aventura não vai faltar",ItemsDeSerie = "Air-bags"},
                new Carro{Nome = "Dublò", Motorizacao = "1.0", Descricao = "Aventura não vai faltar",ItemsDeSerie = "Air-bags"}
            };

			fiat.Nome = "FIAT";

			return fiat;
		}


        private Marca GetListaCarrosFord()
        {
            var ford = new Marca()
            {
                new Carro{Nome = "KA", Motorizacao = "1.0", Descricao = "Aventura não vai faltar", ItemsDeSerie = "Air-bags"},
                new Carro{Nome = "Fusion", Motorizacao = "1.0", Descricao = "Aventura não vai faltar",ItemsDeSerie = "Air-bags"},
                new Carro{Nome = "Ranger", Motorizacao = "1.0", Descricao = "Aventura não vai faltar",ItemsDeSerie = "Air-bags"},
                new Carro{Nome = "Mustang", Motorizacao = "1.0", Descricao = "Aventura não vai faltar", ItemsDeSerie = "Air-bags"}
            };

            ford.Nome = "FORD";

            return ford;
        }

        private void EventoVisualizar(object sender, EventArgs e)
        {
            var parametro = ((MenuItem)sender).CommandParameter;
            var carro = (Carro) parametro;

            DisplayAlert("Clicou no Visualizar", $"Registro: {carro.Nome}","Ok");
        }


        private Marca GetListaCarrosRenault()
        {
            var renault = new Marca()
            {
                new Carro{Nome = "Kwid", Motorizacao = "1.6", Descricao = "Aventura não vai faltar", ItemsDeSerie = "Air-bags"},
                new Carro{Nome = "Captur", Motorizacao = "1.4", Descricao = "Aventura não vai faltar",ItemsDeSerie = "Air-bags"},
                new Carro{Nome = "Logan", Motorizacao = "1.0", Descricao = "Aventura não vai faltar",ItemsDeSerie = "Air-bags"},
            };

            renault.Nome = "RENAULT";

            return renault;
        }

        private void RecarregandoLista(object sender, EventArgs e)
        {
            var lista = new List<Marca>()
            {
                GetListaCarrosRenault()
            };

            Lista01.ItemsSource = lista;
            Lista01.IsRefreshing = false; 
        }

        private void Lista01_Scrolled(object sender, ScrolledEventArgs e)
        {
            LblScroll.Text = $"X: {e.ScrollX} - Y {e.ScrollY}";
        }

        private void MoverParaFordKa(object sender, EventArgs e)
        {
            var marcas = (List<Marca>)Lista01.ItemsSource;
            var ford = marcas[1];
            var ka   = ford[0];

            Lista01.ScrollTo(ka, ScrollToPosition.Center,true);
        }

        private void Lista01_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            DisplayAlert("Selecionado","Item selecionado","Ok");
        }

        private void Lista01_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            DisplayAlert("Clicado", "Item tocado", "Ok");
        }
    }

    public class Carro
	{
		public string Nome { get; set; }
		public string Motorizacao { get; set; }
		public string Descricao { get; set; }
		public string ItemsDeSerie { get; set; }
	}

	public class Marca : List<Carro>
	{
        public string Nome { get; set; }
    }

}