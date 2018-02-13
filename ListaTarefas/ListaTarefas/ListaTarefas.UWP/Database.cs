using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using System.IO;
using Windows.Storage;

namespace ListaTarefas.UWP
{
    public class Database : IDatabase
    {
        public SQLiteConnection GetConnection()
        {
            var NomeDB = "ListaTarefas.db3";
            var CaminhoBD = Path.Combine(ApplicationData.Current.LocalFolder.Path, NomeDB);
            return new SQLiteConnection(CaminhoBD);
        }
    }
}
