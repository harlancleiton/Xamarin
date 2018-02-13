using AppPessoa.Model;
using AppPessoa.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppPessoa.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListViewPessoasView : ContentPage
	{
		public ListViewPessoasView ()
		{
			InitializeComponent ();
            BindingContext = new ListViewPessoasViewModel();
		}

        public void ListViewPessoaItemDetail(object sender, ItemTappedEventArgs eventArgs)
        {
            Pessoa pessoa = eventArgs.Item as Pessoa;
            Navigation.PushAsync(new ListarPessoaView(pessoa));
        }
	}
}