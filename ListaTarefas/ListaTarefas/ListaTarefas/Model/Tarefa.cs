using SQLite;

namespace ListaTarefas.Model
{
    [Table("Tarefas")]
    public class Tarefa
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; } = 0;
        public string Nome { get; set; } = "";
        public bool Finalizada { get; set; } = false;

        /*public Tarefa()
        {
            Finalizada = false;
        }*/
    }
}
