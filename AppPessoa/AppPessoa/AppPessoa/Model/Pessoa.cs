using System;
using System.Collections.Generic;
using System.Text;

namespace AppPessoa.Model
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public String Cpf { get; set; }
        public string Sexo { get; set; }
        public int Idade { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        //public List<Pessoa> ListaPessoas = new List<Pessoa>();

        public Pessoa(string Nome, string Cpf, string Sexo, DateTime DataNascimento, string Email) 
        {
            this.Nome = Nome;
            this.Cpf = Cpf;
            this.Sexo = Sexo;
            this.Idade = CalcularIdade(DataNascimento);
            this.DataNascimento = DataNascimento;
            this.Email = Email;
        }

        public Pessoa(string Nome, string Cpf, string Sexo, int Idade, DateTime DataNascimento, string Email)
        {
            this.Nome = Nome;
            this.Cpf = Cpf;
            this.Sexo = Sexo;
            //this.Idade = CalcularIdade(DataNascimento);
            this.Idade = Idade;
            this.DataNascimento = DataNascimento;
            this.Email = Email;
        }

        /*public Pessoa CadastrarPessoa(Pessoa ListaPessoas)
        {
            ListaPessoas.ListaPessoas.Add(ListaPessoas);
            return ListaPessoas;
        }*/

        public int CalcularIdade(DateTime DataNascimento)
        {
            int Idade = 0;


            return Idade;
        }
    }
}
