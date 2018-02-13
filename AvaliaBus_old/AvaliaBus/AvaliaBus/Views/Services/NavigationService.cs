using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AvaliaBus.ViewModels.Services;
using Xamarin.Forms;

namespace AvaliaBus.Views.Services
{
    public class NavigationService : INavigationService
    {
        public async Task NavigateTo(string viewName)
        {
            if (viewName.Equals("AboutView"))
                //await App.Current.MainPage.Navigation.PushAsync(new AboutView());
                await App.NavigateMasterDetail(new AboutView());
            else if (viewName.Equals("HistoricView"))
                await App.NavigateMasterDetail(new HistoricView());
            else if (viewName.Equals("SettingsView"))
                await App.NavigateMasterDetail(new SettingsView());
            else if (viewName.Equals("EvaluationView"))
                await App.NavigateMasterDetail(new EvaluationView());
            else if (viewName.Equals("UserView"))
                await App.NavigateMasterDetail(new UserView());
        }

        public void NavigateToMaster()
        {
            App.Current.MainPage = new MasterView();
        }

        public void NavigateToLogin()
        {
            App.Current.MainPage = new LoginView();
        }

        public void NavigateToRegister()
        {
            App.Current.MainPage = new RegisterView();
        }

        public void NavigateToForgotPassword()
        {
            App.Current.MainPage = new ForgotPassword();
        }
    }
}
