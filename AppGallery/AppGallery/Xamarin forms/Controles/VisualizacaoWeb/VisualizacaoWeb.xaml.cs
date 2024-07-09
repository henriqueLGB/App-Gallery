using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.Xamarin_forms.Controles.VisualizacaoWeb
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class VisualizacaoWeb : ContentPage
	{
		public VisualizacaoWeb ()
		{
			InitializeComponent ();

			var webViewHtmlSource = new HtmlWebViewSource();

            webViewHtmlSource.Html =
                @"<html>
					<body>
						<h1>Eu sou uma página</h1>
						<h2>dentro do WebView</h2>
						<p>Este é um teste do nosso webview renderizando HTML e <span style='color:red;text-decoration:underline;font-weight:bold;'>CSS</span>
					</body>
				</html>";

			WebView02.Source = webViewHtmlSource;


            //DependencyService - Xamarin forms - Caminho onde se encontra arquivos do site.
            var endereco = new UrlWebViewSource();
			var baseUrl = DependencyService.Get<IBaseUrl>().Get();

			endereco.Url = Path.Combine(baseUrl, "index.html");

			WebView03.Source = endereco;	

		}

        private void BotaoVoltar(object sender, EventArgs e)
        {
			if (WebView03.CanGoBack)
			{
				WebView03.GoBack();
			}
        }

        private void BotaoAtualizar(object sender, EventArgs e)
        {
			WebView03.Reload();
        }

        private void BotaoProximo(object sender, EventArgs e)
        {
			if (WebView03.CanGoForward)
			{
				WebView03.GoForward();
			}
        }

        private void Carregado(object sender, WebNavigatedEventArgs e)
        {
			LblStatus.Text = "Carregado";
			lblUrl.Text = e.Url;
        }

        private void Carregando(object sender, WebNavigatingEventArgs e)
        {
            LblStatus.Text = "Carregando..";
        }
    }
}