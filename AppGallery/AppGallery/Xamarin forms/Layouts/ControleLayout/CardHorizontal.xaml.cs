using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.Xamarin_forms.Layouts.ControleLayout
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CardHorizontal : ContentView
    {

        public static readonly BindableProperty TituloProperty = BindableProperty.Create("Titulo",typeof(string),typeof(CardHorizontal));
        public static readonly BindableProperty TextoProperty = BindableProperty.Create("Texto", typeof(string), typeof(CardHorizontal));
        public static readonly BindableProperty CorProperty = BindableProperty.Create("Cor", typeof(Color), typeof(CardHorizontal));

        public string Titulo 
        {
            get{return (string)GetValue(TituloProperty);}
            set{SetValue(TituloProperty, value);}
        }

        public string Texto
        {
            get { return (string)GetValue(TextoProperty); }
            set { SetValue(TextoProperty, value); }
        }

        public Color Cor
        {
            get { return (Color)GetValue(CorProperty); }
            set { SetValue(CorProperty, value); }
        }

        public CardHorizontal()
        {
            InitializeComponent();
        }
    }
}