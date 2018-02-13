using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliaBus.Models.Services
{
    public class EvaluationService
    {
        public EvaluationModel GetEvaluationModelsGeneral()
        {
            return LoadEvaluationModelsGeneral();
        }

        private EvaluationModel LoadEvaluationModelsGeneral()
        {
            EvaluationModel loadEvaluationModelsGeneral = new EvaluationModel()
            {
                DriverNote = 0,
                NoteCleaning = 0,
                BusNote = 0,
                NoteSecurity = 0
            };

            /*loadEvaluationModelsGeneral.Add(new EvaluationModel
            {
                //PropertyName = "Dirigibilidade do motorista",
                DriverNote = 0,
                NoteCleaning = 0,
                BusNote = 0,
                NoteSecurity = 0
            });*/

            return loadEvaluationModelsGeneral;
        }
    }
}
