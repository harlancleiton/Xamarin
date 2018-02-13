using AvaliaBus.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AvaliaBus.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AvaliacaoGeralView : ContentPage
	{
		public AvaliacaoGeralView ()
		{
			InitializeComponent ();

            BindingContext = new AvaliacaoViewModel();
        }
	}
}