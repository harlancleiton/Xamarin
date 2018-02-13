using ListaTarefas.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListaTarefas.Database
{
    public class TarefasDataAccess
    {
        private SQLiteConnection _database;

        public TarefasDataAccess()
        {
            _database = DependencyService.Get<IDatabase>().GetConnection();
            _database.CreateTable<Tarefa>();
        }

        public List<Tarefa> GetTarefas()
        {
            return _database.Table<Tarefa>().ToList();
        }

        public int SalvarTarefa(Tarefa tarefa)
        {
            return _database.Insert(tarefa);
        }

        public int ExcluirTarefa(Tarefa tarefa)
        {
            return _database.Delete(tarefa);
        }

        public int AtualizarTarefa(Tarefa tarefa)
        {
            return _database.Update(tarefa);
        }
    }
}