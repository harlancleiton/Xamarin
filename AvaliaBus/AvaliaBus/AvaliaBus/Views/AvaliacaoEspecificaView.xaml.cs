using AvaliaBus.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AvaliaBus.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AvaliacaoEspecificaView : ContentPage
	{
		public AvaliacaoEspecificaView ()
		{
			InitializeComponent ();

		    BindingContext = new AvaliacaoViewModel();
        }
	}
}