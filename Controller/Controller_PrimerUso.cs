using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controller
{
    public class Controller_PrimerUso
    {
        public int VerifyUser() 
        {
            return Modelo_PrimerUso.Check_User();
        }
    }
}
