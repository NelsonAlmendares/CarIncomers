using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controller
{
    public class Controller_ChangePassword
    {
        // Constructores de la clase
        public string Email { get; set; }
        public string Password { get; set; }        

        public bool ChangePassword(string Email, string Password)
        {
            return Modelo_ChangePassword.ChangePwd(Email, Password);
        }
    }
}
