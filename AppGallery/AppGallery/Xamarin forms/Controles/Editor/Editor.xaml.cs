using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.Xamarin_forms.Controles.Editor
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Editor : ContentPage
    {
        public Editor()
        {
            InitializeComponent();
        }

        private void FocusEvento(object sender, FocusEventArgs e)
        {
            lblFocus.Text = "campo focado !";
        }

        private void UnFocusEvento(object sender, FocusEventArgs e)
        {
            lblUnfocus.Text = "campo desfocado !";
        }

        private void TextChangeEvento(object sender, TextChangedEventArgs e)
        {
            lblTextchange.Text = e.NewTextValue + " - " + e.NewTextValue.Length;
        }

        private void CompletedEvento(object sender, EventArgs e)
        {
            lblComplete.Text = "Texto completado !";
        }
    }
}