using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace AvaliaBus.Models
{
    public class UsuarioModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public string Genero { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
