using AppPessoa.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppPessoa.ViewModel
{
    class ListViewPessoasViewModel
    {
        public List<Pessoa> Pessoas { get; set; } = new List<Pessoa>();

        public ListViewPessoasViewModel()
        {
            Pessoas.Add(new Pessoa("Harlan","123","Masculino",new DateTime(1994,12,15),"harlancleiton@gmail.com"));
            Pessoas.Add(new Pessoa("Vanessa", "122", "Feminino", new DateTime(1996, 10, 25), "whanessasanthos@gmail.com"));
            Pessoas.Add(new Pessoa("Carlos", "124", "Masculino", new DateTime(1983, 08, 23), "carlos@gmail.com"));
            Pessoas.Add(new Pessoa("Conceição", "125", "Feminino", new DateTime(1967, 09, 01), "conceicao@gmail.com"));
            Pessoas.Add(new Pessoa("Harlan", "123", "Masculino", new DateTime(1994, 12, 15), "harlancleiton@gmail.com"));
        }
    }
}
