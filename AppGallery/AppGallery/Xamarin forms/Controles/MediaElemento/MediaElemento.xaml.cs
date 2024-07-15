using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.Xamarin_forms.Controles.MediaElemento
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MediaElemento : ContentPage
	{
        private bool continuaAtualizando = true;

		public MediaElemento ()
		{
			InitializeComponent ();
		}

        private void BotaoPlay(object sender, EventArgs e)
        {
            VideoControle.Play();
            continuaAtualizando = true;
            AtualizarVideoPosicao();
        }

        private void BotaoPause(object sender, EventArgs e)
        {
            VideoControle.Pause();
            continuaAtualizando = false;
            AtualizarVideoPosicao();
        }

        private void BotaoStop(object sender, EventArgs e)
        {
            VideoControle.Stop();
            continuaAtualizando = false;
            AtualizarVideoPosicao();
        }

        private void SliderVolume(object sender, ValueChangedEventArgs e)
        {
            VideoControle.Volume = e.NewValue;
            lblVolume.Text = $"Volume({e.NewValue})";
        }

        private void MediaOpened(object sender, EventArgs e)
        {
            LblDuracao.Text = VideoControle.Duration.Value.ToString(@"mm\:ss");
            SliderPosicaoVideo.Maximum = VideoControle.Duration.Value.TotalSeconds;
        }

        private void AtualizarVideoPosicao()
        {
            Device.StartTimer(TimeSpan.FromMilliseconds(500), () =>
            {
                LblPosicao.Text = VideoControle.Position.ToString(@"mm\:ss");
                SliderPosicaoVideo.Value = VideoControle.Position.Seconds;
                VideoControle.Position = new TimeSpan(0, 0, 3); 

                return continuaAtualizando;
            });
        }
    }
}