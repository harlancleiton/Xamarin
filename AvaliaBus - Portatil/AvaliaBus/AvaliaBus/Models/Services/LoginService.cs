using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliaBus.Models.Services
{
    public class LoginService
    {
        public bool ValidateLogin(UserModel user)
        {
            if (user.Username.Equals("Harlan") && user.Password.Equals("123"))
                return true;
            else
                return false;
        }
    }
}
