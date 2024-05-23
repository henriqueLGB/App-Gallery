using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.Xamarin_forms.Paginas.PaginaCarrousel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Carrousel : CarouselPage
    {
        public Carrousel()
        {
            InitializeComponent();

            //INICIALIZA ATRAVÉS DE UMA PÁGINA ESPECÍFICA
            CurrentPage = Children[1];
        }
    }
}