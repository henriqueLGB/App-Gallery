using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.Xamarin_forms.Controles.SeletorTempo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SelectorTime : ContentPage
    {
        public SelectorTime()
        {
            InitializeComponent();
        }

        private void TimePicker_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if(e.PropertyName == "Time")
            {
                //((TimePicker)sender).Time;
                lblInformativo.Text = "Time Alterado";
            }
        }
    }
}