using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AvaliaBus.ViewModels.Services
{
    public interface INavigationService
    {
        void NavigateToLogin();
        void NavigateToRegister();
        void NavigateToMaster();
        void NavigateToForgotPassword();
        Task NavigateTo(string viewName);
    }
}
