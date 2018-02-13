using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ServicosCEP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BuscarCEP(object sender, EventArgs eventArgs)
        {
            if (EntryCEP.Text != null && ValidarCEP(EntryCEP.Text))
            {

            }
        }

        public bool ValidarCEP(string CEP)
        {
            if (CEP.Length == 8)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
