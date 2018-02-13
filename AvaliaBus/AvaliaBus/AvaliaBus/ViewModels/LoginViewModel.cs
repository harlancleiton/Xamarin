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
    public class LoginViewModel : ViewModelBase
    {

        #region Properties
        //private UserModel User { get { return User; } set { User = value; this.Notify("User"); } }
        string usuario;
        public string Usuario { get { return usuario; } set { usuario = value; this.Notify("Usuario"); } }
        string senha;
        public string Senha { get { return senha; } set { senha = value; this.Notify("Senha"); } }
        public ICommand LoginCommand { get; set; }
        public ICommand RegistroCommand { get; set; }
        public ICommand ForgotPasswordCommand { get; set; }
        private readonly IMessageService _messageService;
        private readonly INavigationService _navigationService;
        #endregion

        public LoginViewModel()
        {
            LoginCommand = new Command(Login);
            RegistroCommand = new Command(Register);
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
            if (string.IsNullOrEmpty(this.Usuario) && string.IsNullOrEmpty(this.Senha))
                _messageService.ShowAsync("Por favor, preencha os campos \"Usuário\" e \"Senha\".");
            else if (new LoginService().ValidateLogin(new UsuarioModel() { Usuario = this.Usuario, Senha = this.Senha }))
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