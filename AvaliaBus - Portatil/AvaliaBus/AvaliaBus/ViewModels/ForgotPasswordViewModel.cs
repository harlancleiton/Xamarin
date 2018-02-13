using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using AvaliaBus.ViewModels.Services;
using AvaliaBus.Views;
using Xamarin.Forms;

namespace AvaliaBus.ViewModels
{
    public class ForgotPasswordViewModel
    {
        public string Username { get; set; }
        public ICommand RegisterCommand { get; set; }
        public ICommand ForgotPasswordCommand { get; set; }
        public ICommand LoginCommand { get; set; }
        private readonly IMessageService _messageService;
        private readonly INavigationService _navigationService;

        public ForgotPasswordViewModel()
        {
            LoginCommand = new Command(Login);
            RegisterCommand = new Command(Register);
            ForgotPasswordCommand = new Command(ForgotPassword);

            /*
             * É assim que se trabalha na ViewModel, eu sei que precisa enviar uma mensagem, como vai ser enviada não me importa
             * Me dá uma instancia da classe que implementa essa interface
             */
            _messageService = DependencyService.Get<IMessageService>();
            _navigationService = DependencyService.Get<INavigationService>();
        }

        private void ForgotPassword()
        {
            throw new NotImplementedException();
        }

        private void Login()
        {
            _navigationService.NavigateToLogin();
        }

        private void Register()
        {
            _navigationService.NavigateToRegister();
        }
    }
}
