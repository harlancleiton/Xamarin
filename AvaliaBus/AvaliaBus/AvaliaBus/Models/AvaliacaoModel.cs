using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace AvaliaBus.Models
{
    public class AvaliacaoModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public float DirigibilidadeMotorista { get; set; }
        public float LimpezaOnibus { get; set; }
        public float NotaOnibus { get; set; }
        public float NotaSeguranca { get; set; }
        public bool OnibusSujo { get; set; }
        public bool OnibusQuebrou { get; set; }
        public bool OnibusJanelaQuebrada { get; set; }
        public bool OnibusCadeiraQuebrada { get; set; }
        public bool MotoristaNaoParouNoPonto { get; set; }
        public bool MotoristaFreouBruscamente { get; set; }
        public bool MotoristaUsouCelular { get; set; }
        public bool OnibusAssaltado { get; set; }
    }
}
