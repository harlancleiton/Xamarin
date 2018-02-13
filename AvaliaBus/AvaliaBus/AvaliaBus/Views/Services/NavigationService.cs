using System;
using System.Threading.Tasks;
using AvaliaBus.ViewModels.Services;
using Xamarin.Forms;

namespace AvaliaBus.Views.Services
{
    public class NavigationService : INavigationService
    {
        public async Task NavigateTo(string viewName)
        {
            if (viewName.Equals("SobreView"))
                //await App.Current.MainPage.Navigation.PushAsync(new AboutView());
                await App.NavigateMasterDetail(new SobreView());
            else if (viewName.Equals("HistoricoView"))
                await App.NavigateMasterDetail(new HistoricoView());
            else if (viewName.Equals("ConfiguracoesView"))
                await App.NavigateMasterDetail(new ConfiguracoesView());
            else if (viewName.Equals("AvaliacaoView"))
                await App.NavigateMasterDetail(new AvaliacaoView());
            else if (viewName.Equals("UsuarioView"))
                await App.NavigateMasterDetail(new UsuarioView());
        }

        public void NavigateToMaster()
        {
            App.Current.MainPage = new MasterView();
        }

        public void NavigateToLogin()
        {
            App.Current.MainPage = new LoginView();
        }

        public void NavigateToLogin(Type type)
        {
            Page page = (Page) Activator.CreateInstance(type);
            App.Current.MainPage = page;
        }

        public void NavigateToRegister()
        {
            App.Current.MainPage = new RegisterView();
        }

        public void NavigateToForgotPassword()
        {
            //App.Current.MainPage = new ForgotPassword();
        }
    }
}