using AppGallery.Xamarin_forms.Paginas.PaginaCarrousel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.Xamarin_forms.Listas.CarrosselControle
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Carrossel : ContentPage
	{
        private ObservableCollection<Colaborador> colaboradores { get; set; } 

		public Carrossel()
		{
			InitializeComponent();

            colaboradores = GetColaboradores();
            Carrossel01.ItemsSource = colaboradores;

        }

		private ObservableCollection<Colaborador> GetColaboradores()
		{
			return new ObservableCollection<Colaborador>()
			{
				new Colaborador() { Nome = "João Ribeiro",		Cargo = "Desenvolvedor",	Descricao = "Sou Desenvolvedor desde 2009"},
                new Colaborador() { Nome = "Lucas da Silva",	Cargo = "Web Designer",		Descricao = "Sou Web Designer desde 2009"},
                new Colaborador() { Nome = "Roberto Hernandes", Cargo = "Designer",			Descricao = "Sou Designer desde 2009"},
                new Colaborador() { Nome = "Henrique da Silva", Cargo = "Suporte",			Descricao = "Sou Suporte desde 2009"},
            };
		}

        private void Carrossel01_RemainingItemsThresholdReached(object sender, EventArgs e)
        {
            colaboradores.Add(new Colaborador() { Nome = "Emanoel da Silva", Cargo = "Infra", Descricao = "Sou Infra desde 2009" });
            colaboradores.Add(new Colaborador() { Nome = "Joaquim da Silva", Cargo = "Dba", Descricao = "Sou Dba desde 2009" });
            colaboradores.Add(new Colaborador() { Nome = "Lucío da Silva", Cargo = "Analista", Descricao = "Sou Analista desde 2009" });

            Carrossel01.RemainingItemsThreshold = - 1;
        }

        private void Carrossel01_CurrentItemChanged(object sender, CurrentItemChangedEventArgs e)
        {
            var colaborador = (Colaborador)e.CurrentItem;
            LblItem.Text = "Nome: " + colaborador.Nome;
        }

        private void Carrossel01_PositionChanged(object sender, PositionChangedEventArgs e)
        {
            LblPosition.Text = "Posição: " + e.CurrentPosition + " - Posição anterior: " + e.PreviousPosition;
        }

        private void Carrossel01_Scrolled(object sender, ItemsViewScrolledEventArgs e)
        {
            LblScroll.Text = "ScrollX: " + e.HorizontalOffset;
        }
    }

    public class Colaborador
    {
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public string Descricao { get; set; }
    }
}