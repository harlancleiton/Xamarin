using AvaliaBus.Models;
using AvaliaBus.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AvaliaBus.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuView : ContentPage
    {
        public MenuView()
        {
            InitializeComponent();

            BindingContext = new MenuViewModel();
        }

        private void MenuListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            MenuModel aux = sender as MenuModel;
            new MenuViewModel().NavigateTo(aux);
        }

        private void MenuListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            MenuModel aux = sender as MenuModel;
            new MenuViewModel().NavigateTo(aux);
        }
    }
}