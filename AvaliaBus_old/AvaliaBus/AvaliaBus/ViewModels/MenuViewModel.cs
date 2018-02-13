using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using AvaliaBus.Models;
using AvaliaBus.Models.Services;
using AvaliaBus.ViewModels.Services;
using Xamarin.Forms;

namespace AvaliaBus.ViewModels
{
    public class MenuViewModel : ViewModelBase
    {
        public ObservableCollection<MenuModel> Menu { get; set; }
        private readonly INavigationService _navigationService;
        public ICommand NavigateToCommand { get; set; }

        public MenuViewModel()
        {
            Menu = new ObservableCollection<MenuModel>(new MenuService().GetMenu());
            NavigateToCommand = new Command<MenuModel>(NavigateTo);
            _navigationService = DependencyService.Get<INavigationService>();
        }

        public void NavigateTo(MenuModel menu)
        {
            _navigationService.NavigateTo(menu.ViewName);
        }
    }
}
