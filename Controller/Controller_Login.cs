using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Common.cache;
using System.Data;

namespace Controller
{
    public class Controller_Login
    {
        public Controller_Login() { }
        public string User { get; set; }
        public string Pwd { get; set; }

        public bool VerifyData(string User, string Pwd)
        {
            return Model_Login.IniciarSesion(User, Pwd);
        }
    }
}
