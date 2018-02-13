using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using AvaliaBus.Models;
using AvaliaBus.Models.Services;
using AvaliaBus.ViewModels.Services;
using AvaliaBus.Views;
using Xamarin.Forms;

namespace AvaliaBus.ViewModels
{
    public class LoginViewModel: ViewModelBase
    {

        #region Properties
        //private UserModel User { get { return User; } set { User = value; this.Notify("User"); } }
        string username;
        public string Username { get { return username; } set { username = value; this.Notify("Username"); } }
        string password;
        public string Password { get { return password; } set { password = value; this.Notify("Password"); } }
        public ICommand LoginCommand { get; set; }
        public ICommand RegisterCommand { get; set; }
        public ICommand ForgotPasswordCommand { get; set; }
        private readonly IMessageService _messageService;
        private readonly INavigationService _navigationService;
        #endregion

        public LoginViewModel()
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

        private void Login()
        {
            /*
             * Trabalhar com injeção de dependencias. Trabalhar com interfaces
             * A ViewModel não precisa saber como enviar uma mensagem
             * --> A VIEWMODEL NÃO CONHECE A VIEW <--
             */
            if (string.IsNullOrEmpty(this.Username) && string.IsNullOrEmpty(this.Password))
                _messageService.ShowAsync("Por favor, preencha os campos \"Usuário\" e \"Senha\".");
            else if (new LoginService().ValidateLogin(new UserModel(){ Username = this.Username, Password = this.Password }))
            {
                _navigationService.NavigateToMaster();
            }
            else
            {
                _messageService.ShowAsync("Usuário ou senha inválidos.");
            }
        }

        private void Register()
        {
            _navigationService.NavigateToRegister();
        }

        private void ForgotPassword()
        {
            _navigationService.NavigateToForgotPassword();
        }
    }
}