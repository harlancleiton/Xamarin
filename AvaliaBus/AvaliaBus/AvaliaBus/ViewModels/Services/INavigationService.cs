using System;
using System.Threading.Tasks;

namespace AvaliaBus.ViewModels.Services
{
    public interface INavigationService
    {
        void NavigateToLogin(Type type);
        void NavigateToRegister();
        void NavigateToMaster();
        void NavigateToForgotPassword();
        Task NavigateTo(string viewName);
    }
}