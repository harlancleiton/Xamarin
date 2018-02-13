using System.Collections.ObjectModel;
using System.Windows.Input;
using AvaliaBus.Models;
using AvaliaBus.Models.Services;
using Xamarin.Forms;

namespace AvaliaBus.ViewModels
{
    public class EvaluationViewModel : ViewModelBase
    {
        public EvaluationModel EvaluationModelsGeneral { get; set; }
        public ICommand SaveEvaluationCommand { get; set; }

        public EvaluationViewModel()
        {
            EvaluationModelsGeneral = new EvaluationService().GetEvaluationModelsGeneral();
            SaveEvaluationCommand = new Command<EvaluationModel>(SaveEvaluation);
        }

        private void SaveEvaluation(EvaluationModel evaluation)
        {
            
        }
    }
}
