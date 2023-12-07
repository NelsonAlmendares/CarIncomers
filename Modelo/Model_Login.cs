using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Common;
using Common.cache;

namespace Modelo
{
    public class Model_Login
    {
        public static bool IniciarSesion(string User, string Pwd) 
        {
            _ = new Encrypt();
            bool response = false;
            try
            {
                // Cadena para los usuarios registrados dentro de la base de datos
                string Query = "SELECT * FROM LoginUser WHERE Usuario = @user AND Password_usuario = @password;";
                // Instanciamos el acceso a la clase de conexión para poder realizar la consulta
                SqlConnection ConnectData = Model_Conexion.Connect();
                SqlCommand RunQuery = new SqlCommand(Query, ConnectData);

                // Agregamos los parametros a la cadena de consulta
                RunQuery.Parameters.AddWithValue("@user", User);
                RunQuery.Parameters.AddWithValue("@password", Encrypt.HashString(Pwd));
                SqlDataReader reader = RunQuery.ExecuteReader();

                // Evaluamos que la consulta retorne datos:
                if (reader.HasRows)
                {
                    while (reader.Read()) {
                        UserLoginCache.ID = reader.GetInt32(0);
                        UserLoginCache.Usuario = reader.GetString(1);
                        UserLoginCache.Nombre = reader.GetString(3);
                        UserLoginCache.TipoUsuario = reader.GetString(4);
                        UserLoginCache.Telefono = reader.GetString(5);
                        UserLoginCache.Celular = reader.GetString(6);
                        UserLoginCache.EstadoUsuario = reader.GetString(7);
                        UserLoginCache.Documento = reader.GetString(8);
                        UserLoginCache.Correo = reader.GetString(10);
                    }
                    response = true;
                }
                ConnectData.Close();
                return response;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error at: " + ex);
                return false;
            }
        }
    }
}
