using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data;

namespace Controller
{
    public class Controller_Contactos
    {
        public Controller_Contactos() { }
        public int ID_contacto { get; set; }
        public int ID_usuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }

        public bool InsertDataContact() 
        {
            return Modelo_Contactos.InsertContacto(ID_usuario, Nombre, Apellido, Celular,Email);
        }

        public DataTable ShowContacts() 
        {
            return Modelo_Contactos.LoadData();
        }

    }
}
