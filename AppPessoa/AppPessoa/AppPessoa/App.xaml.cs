using AppPessoa.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace AppPessoa
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            //MainPage = new ListarPessoaView();
            /*
             * new NavigationPage, senão não a transição de telas não é suportada pelo Android
             * e ocorre erro na execução do aplicativo
             */
            MainPage = new NavigationPage(new ListViewPessoasView());
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
