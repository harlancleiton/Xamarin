using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace ServicosCEP
{
    class Servico
    {
        private static string UrlBase = "https://viacep/ws/{0}/json";
        public static string BuscarCEP(string CEP)
        {
            string URL = string.Format(UrlBase, CEP);
            HttpClient httpClient = new HttpClient();
            string JsonCEP = httpClient.GetStringAsync(URL).GetAwaiter().GetResult();

            return ;

        }
    }
}
