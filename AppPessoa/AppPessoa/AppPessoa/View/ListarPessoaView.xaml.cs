using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppPessoa.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppPessoa.Model;

namespace AppPessoa.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListarPessoaView : ContentPage
	{
        public ListarPessoaView (Pessoa pessoa)
		{
			InitializeComponent ();

            BindingContext = new ListarPessoaViewModel(pessoa);

            /*string Nome = "Harlan";
            String Cpf = "123";
            string Sexo = "Masculino";
            int Idade = 22;
            DateTime DataNascimento = new DateTime(1994, 12, 15);
            string Email = "harlancleiton@gmail.com";
            BindingContext = new ListarPessoaViewModel(new Pessoa(Nome,Cpf,Sexo,Idade,DataNascimento,Email));*/
            //BindingContext = new ListarPessoaViewModel();
		}

        
	}
}