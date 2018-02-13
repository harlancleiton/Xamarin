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
    public partial class Switch : ContentPage
    {
        public Switch()
        {
            InitializeComponent();
        }

        private void OnToggledSwitch(object sender, ToggledEventArgs e)
        {
            LblSwitch.Text = e.Value.ToString();
        }
    }
}