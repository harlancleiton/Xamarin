using AvaliaBus.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AvaliaBus.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RegistroView : ContentPage
	{
		public RegistroView ()
		{
		    InitializeComponent();

		    BindingContext = new RegistroViewModel();
        }
	}
}