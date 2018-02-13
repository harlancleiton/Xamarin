using System;
using System.Collections.ObjectModel;
using SQLite;

namespace AvaliaBus.Models
{
    public class EvaluationModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string PropertyName { get; set; }
        public float DriverNote { get; set; }
        public float NoteCleaning { get; set; }
        public float BusNote { get; set; }
        public float NoteSecurity { get; set; }
        public bool IsNotClean { get; set; }
        public bool BusBroke { get; set; }
        public bool IsWithBrokenWindow { get; set; }
        public bool IsWithBrokenChair { get; set; }
        public bool DriverDidNotStop { get; set; }
        public bool SuddenlyStop { get; set; }
        public bool UsedTheCellPhone { get; set; }
        public bool BusWasRobbed { get; set; }

        public static implicit operator EvaluationModel(ObservableCollection<EvaluationModel> v)
        {
            throw new NotImplementedException();
        }
    }
}
