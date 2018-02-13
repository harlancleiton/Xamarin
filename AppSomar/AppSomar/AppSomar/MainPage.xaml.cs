using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppSomar.bll;
using Xamarin.Forms;

namespace AppSomar
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

		    btnSomar.Clicked += delegate
		    {
		        int num1 = int.Parse(txtNumero1.Text);
		        int num2 = int.Parse(txtNumero2.Text);

		        int resultado = Somar.somar(num1, num2);

		        lblResultado.Text = "O resultado é " + resultado;
            };

            

            
		}
	}
}
