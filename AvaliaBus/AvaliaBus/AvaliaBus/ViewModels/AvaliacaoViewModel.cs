using System.Windows.Input;
using AvaliaBus.Models;
using AvaliaBus.Models.Services;
using Xamarin.Forms;

namespace AvaliaBus.ViewModels
{
    public class AvaliacaoViewModel
    {
        public AvaliacaoModel AvaliacaoGeralModel { get; set; }
        public ICommand SalvarAvaliacaoCommand { get; set; }

        public AvaliacaoViewModel()
        {
            //AvaliacaoGeralModel = new EvaluationService().GetEvaluationModelsGeneral();
            SalvarAvaliacaoCommand = new Command<AvaliacaoModel>(SalvarAvaliacao);
        }

        private void SalvarAvaliacao(AvaliacaoModel avaliacao)
        {

        }
    }
}
