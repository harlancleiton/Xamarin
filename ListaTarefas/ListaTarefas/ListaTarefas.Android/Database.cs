using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;
using ListaTarefas.Droid;
using System.IO;

[assembly: Xamarin.Forms.Dependency(typeof(Database))]
namespace ListaTarefas.Droid
{
    public class Database : IDatabase
    {
        public SQLiteConnection GetConnection()
        {
            var NomeBD = "ListaTarefas.db3";
            var CaminhoBD = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), NomeBD);
            return new SQLiteConnection(CaminhoBD);
        }
    }
}