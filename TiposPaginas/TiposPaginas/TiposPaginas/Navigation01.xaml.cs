using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TiposPaginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Navigation01 : ContentPage
    {
        public Navigation01()
        {
            InitializeComponent();
        }

        private void IrParaNavigation02(object sender, EventArgs eventArgs)
        {
            Navigation.PushAsync(new Navigation02());
        }
    }
}