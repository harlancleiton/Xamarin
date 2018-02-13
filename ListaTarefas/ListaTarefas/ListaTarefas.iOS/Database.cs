using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Foundation;
using SQLite;
using UIKit;
using ListaTarefas.iOS;
using System.IO;

[assembly: Xamarin.Forms.Dependency(typeof(Database))]
namespace ListaTarefas.iOS
{
    public class Database : IDatabase
    {
        public SQLiteConnection GetConnection()
        {
            var NomeDB = "ListaTarefas.db3";
            var PersonalFolder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string LibraryFolder = Path.Combine(PersonalFolder, "..", "Library");
            string CaminhoBD = Path.Combine(LibraryFolder, NomeDB);
            return new SQLiteConnection(CaminhoBD);
        }
    }
}