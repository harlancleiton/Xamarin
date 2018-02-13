using AvaliaBus.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AvaliaBus.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EvaluationGeneralView : ContentPage
    {
        public EvaluationGeneralView()
        {
            InitializeComponent();

            BindingContext = new EvaluationViewModel();
        }
    }
}