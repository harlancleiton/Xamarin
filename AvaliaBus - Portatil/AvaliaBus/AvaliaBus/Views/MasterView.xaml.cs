using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AvaliaBus.ViewModels;

namespace AvaliaBus.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterView : MasterDetailPage
    {
        public MasterView()
        {
            InitializeComponent();

            BindingContext = new MasterViewModel();
            Master = new MenuView();
            Detail = new NavigationPage(new EvaluationView());
            App.MasterDetail = this;
        }
    }
}