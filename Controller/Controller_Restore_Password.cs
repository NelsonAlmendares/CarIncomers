using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controller
{
    public class Controller_Restore_Password
    {
        public int ID { get; set; }
        public string Correo { get; set; }

        // MÉTODO PARA VER LA EXISTENCIA DE UN CORREO EN 
        public bool GetEmail(string Correo)
        {
            return Restore_Password.ChechEmail(Correo);
        }
    }
}
