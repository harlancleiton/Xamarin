using SQLite;

namespace AvaliaBus.Models
{
    public class EvaluationModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public float NoteCleaning { get; set; }
        public float DriverNote { get; set; }
        public float CollectorNote { get; set; }
        public float BusNote { get; set; }
        public float NoteSecurity { get; set; }
    }
}
