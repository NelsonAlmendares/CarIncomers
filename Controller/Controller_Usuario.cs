using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data;

namespace Controller
{
    public class Controller_Usuario
    {
        // Construtor de la clase
        public Controller_Usuario() { }
        public int ID_usuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Documento { get; set; }
        public string Password { get; set; }
        public int Edad { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Licencia { get; set; }
        public string Fecha { get; set; }
        public int TipoUsuario { get; set; }
        public int EstadoUsuario { get; set; }
        public string Usuario { get; set; }
        public string Correo { get; set; }

        public int Add_Data() 
        {
            return Modelo_Usuario.InsertData(Nombre, Apellido, Documento, Password, Edad, Telefono, Celular, Licencia, Fecha, TipoUsuario, EstadoUsuario, Usuario, Correo);
        }
        public DataTable ShowData()
        {
            return Modelo_Usuario.LoadData();
        }
    }
}
