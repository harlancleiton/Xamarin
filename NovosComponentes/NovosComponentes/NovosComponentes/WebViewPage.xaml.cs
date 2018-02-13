using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NovosComponentes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WebViewPage : ContentPage
    {
        public WebViewPage()
        {
            InitializeComponent();

            //Não testei. Não sei se vai funcionar
            var paginaHTML = new UrlWebViewSource();
            paginaHTML.Url= "https://www.google.com.br";
            webView.Source = paginaHTML;
        }
    }
}