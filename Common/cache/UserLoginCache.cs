using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.cache
{
    public static class UserLoginCache
    {
        public static int ID { get; set; }
        public static string Nombre { get; set; }
        public static string Usuario { get; set; }
        public static string Documento { get; set; }
        public static string Celular { get; set; }
        public static string Telefono { get; set; }
        public static string TipoUsuario { get; set; }
        public static string EstadoUsuario { get; set; }
        public static string Correo { get; set; }
    }
}
