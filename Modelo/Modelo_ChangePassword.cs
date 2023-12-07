using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Common;

namespace Modelo
{
    public class Modelo_ChangePassword
    {
        public static bool ChangePwd (string Correo, string Password)
        {
            // Método para encriptar la contraseña en SHA 256
            _ = new Encrypt();
            bool response;
            try
            {
                SqlCommand UpdatePassword = new SqlCommand(string.Format("UPDATE [dbo].[Usuario] SET Password_usuario = @Pwd WHERE Correo_Usuario = @Email;"), Model_Conexion.Connect());
                UpdatePassword.Parameters.AddWithValue("@Email", Correo);
                UpdatePassword.Parameters.AddWithValue("@Pwd", Encrypt.HashString(Password));                
                response = Convert.ToBoolean(UpdatePassword.ExecuteNonQuery());
                return response;
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error at: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error at: {ex.Message}");
                return false;
            }
        }
    }
}
