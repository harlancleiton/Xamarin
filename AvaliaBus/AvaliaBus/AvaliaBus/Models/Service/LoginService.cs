namespace AvaliaBus.Models.Services
{
    public class LoginService
    {
        public bool ValidateLogin(UsuarioModel user)
        {
            if (user.Usuario.Equals("Harlan") && user.Senha.Equals("123"))
                return true;
            else
                return false;
        }
    }
}
