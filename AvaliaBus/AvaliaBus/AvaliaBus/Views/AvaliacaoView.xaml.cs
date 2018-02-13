using System.Dynamic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AvaliaBus.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AvaliacaoView : TabbedPage
	{
		public AvaliacaoView ()
		{
			InitializeComponent ();

		    BindingContext = new AvaliacaoViewModel();
		}
	}
}