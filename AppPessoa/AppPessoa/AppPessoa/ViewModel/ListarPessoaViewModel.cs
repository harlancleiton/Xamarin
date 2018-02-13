using AppPessoa.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppPessoa.ViewModel
{
    public class ListarPessoaViewModel
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Sexo { get; set; }
        public int Idade { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }

        public ListarPessoaViewModel(Pessoa pessoa)
        {
            //pessoa = CadastrarPessoa(pessoa);
            Nome = pessoa.Nome;
            Cpf = pessoa.Cpf;
            Sexo = pessoa.Sexo;
            Idade = pessoa.Idade;
            DataNascimento = pessoa.DataNascimento;
            Email = pessoa.Email;
            //pessoa = new Pessoa(Nome, Cpf, Sexo, Idade, DataNascimento, Email);
        }

        /*public Pessoa CadastrarPessoa()
        {
            string Nome = "Harlan";
            String Cpf = "123";
            string Sexo = "Masculino";
            int Idade = 22;
            DateTime DataNascimento = new DateTime(1994, 12, 15);
            string Email = "harlancleiton@gmail.com";

            return new Pessoa(Nome, Cpf, Sexo, Idade,DataNascimento, Email);
        }*/

        public Pessoa CadastrarPessoa(Pessoa pessoa)
        {
            string Nome = pessoa.Nome;
            String Cpf = pessoa.Cpf;
            string Sexo = pessoa.Sexo;
            int Idade = pessoa.Idade;
            DateTime DataNascimento = pessoa.DataNascimento;
            string Email = pessoa.Email;

            Pessoa ListaPessoas = new Pessoa(Nome, Cpf, Sexo, DataNascimento, Email);
            //ListaPessoas = ListaPessoas.CadastrarPessoa(ListaPessoas);
            return pessoa;
        }
    }
}
