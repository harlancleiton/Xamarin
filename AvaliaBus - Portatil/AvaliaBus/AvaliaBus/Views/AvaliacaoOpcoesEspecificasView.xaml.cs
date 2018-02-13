using AvaliaBus.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AvaliaBus.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EvaluationSpecificView : ContentPage
    {
        public EvaluationSpecificView()
        {
            InitializeComponent();

            BindingContext = new EvaluationViewModel();
        }
    }
}