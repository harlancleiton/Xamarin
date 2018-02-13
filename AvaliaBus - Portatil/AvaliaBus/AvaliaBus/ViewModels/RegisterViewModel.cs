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
    public class RegisterViewModel : ViewModelBase
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public ICommand RegisterCommand { get; set; }
        public ICommand ForgotPasswordCommand { get; set; }
        public ICommand LoginCommand { get; set; }
        private readonly IMessageService _messageService;
        private readonly INavigationService _navigationService;

        public RegisterViewModel()
        {
            RegisterCommand = new Command(Register);
            ForgotPasswordCommand = new Command(ForgotPassword);
            LoginCommand = new Command(Login);

            /*
             * É assim que se trabalha na ViewModel, eu sei que precisa enviar uma mensagem, como vai ser enviada não me importa
             * Me dá uma instancia da classe que implementa essa interface
             */
            _messageService = DependencyService.Get<IMessageService>();
            _navigationService = DependencyService.Get<INavigationService>();
        }

        private void Register()
        {
            throw new NotImplementedException();
        }

        private void Login()
        {
            _navigationService.NavigateToLogin();
        }

        private void ForgotPassword()
        {
            _navigationService.NavigateToForgotPassword();
        }
    }
}