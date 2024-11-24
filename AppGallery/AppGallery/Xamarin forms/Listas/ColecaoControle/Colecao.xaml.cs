using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.Xamarin_forms.Listas.ColecaoControle
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Colecao : ContentPage
	{
		private ObservableCollection<Categoria> categorias { get; set; }
		public Colecao ()
		{
			InitializeComponent ();

            //Colecao01.ItemsSource = new List<FastFood>();
            Colecao01.ItemsSource = GetCategoria();

        }

        private ObservableCollection<Categoria> GetCategoria()
		{

			categorias = new ObservableCollection<Categoria>();

			var sanduiches = new Categoria()
			{
				new FastFood {Nome = "Subway", QuantidadeDeFranquias = 44870},
				new FastFood {Nome = "McDonalds", QuantidadeDeFranquias = 20564},
				new FastFood {Nome = "Burger King", QuantidadeDeFranquias = 70000}
			};

            sanduiches.Nome = "Sanduiches";

            var pizzarias = new Categoria()
            {
                new FastFood {Nome = "Domino's", QuantidadeDeFranquias = 44870},
                new FastFood {Nome = "Pizza Hut", QuantidadeDeFranquias = 20564},
            };

            pizzarias.Nome = "Pizzaria";

            var variedades = new Categoria()
			{
                new FastFood {Nome = "Starbucks", QuantidadeDeFranquias = 44870},
                new FastFood {Nome = "KFC", QuantidadeDeFranquias = 20564},
                new FastFood {Nome = "Baskin-Robbins", QuantidadeDeFranquias = 44870},
                new FastFood {Nome = "Taco Bell", QuantidadeDeFranquias = 20564},
            };

            pizzarias.Nome = "Variedades";

            categorias.Add(sanduiches);
            categorias.Add(pizzarias);
            categorias.Add(variedades);


            return categorias;

		}

        private void RemainingReached(object sender, EventArgs e)
        {
            var restaurantes = new Categoria()
            {
                new FastFood {Nome = "Marmitex", QuantidadeDeFranquias = 10},
                new FastFood {Nome = "John Hamburgers", QuantidadeDeFranquias = 5},
                new FastFood {Nome = "Mix", QuantidadeDeFranquias = 2},
                new FastFood {Nome = "Marietta", QuantidadeDeFranquias = 20},
            };

            restaurantes.Nome = "Restaurantes";

            categorias.Add(restaurantes);

            Colecao01.ItemsSource = new List<Categoria>(categorias);

            //Caso seja no final, ele não deve exibir mais itens (serve para não repetir essa linha de código)
            Colecao01.RemainingItemsThreshold = -1;
        }

        private void Colecao01_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            StringBuilder sb = new StringBuilder(); 

            foreach(FastFood fastFood in Colecao01.SelectedItems)
            {
                sb.Append(fastFood.Nome + " - ");
            }

            lblSelecao.Text = "Seleção: " + sb.ToString();
        }
    }

    public class FastFood
	{
		public string Nome { get; set; }
		public int QuantidadeDeFranquias { get; set; }


	}

	public class Categoria : List<FastFood> 
	{ 
		public string Nome { get; set; }
	}

}