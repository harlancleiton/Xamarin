using AvaliaBus.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AvaliaBus.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EvaluationView : TabbedPage
    {
        public EvaluationView()
        {
            InitializeComponent();

            BindingContext = new EvaluationViewModel();
        }
    }
}