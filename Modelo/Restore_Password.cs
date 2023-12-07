using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Modelo
{
    public class Restore_Password
    {
        // Método para ver la existencia de un correo FORM: Restore Password -> GetEmail

        public static bool ChechEmail(string Correo)
        {
            bool response = false;
            try
            {
                string Query = "SELECT * FROM [dbo].[Usuario] WHERE Correo_Usuario = @Email;";
                SqlCommand GetQuery = new SqlCommand(Query, Model_Conexion.Connect());
                GetQuery.Parameters.AddWithValue("@Email", Correo);
                SqlDataReader reader = GetQuery.ExecuteReader();
                if (reader.HasRows)
                {
                    response = true;
                }
                return response;

            }
            catch (SqlException ex)
            {
                // Mensaje de error con número de identificación
                Console.WriteLine($"Sql Error: {ex.Message}");

                // Mensajes de error personalizados
                string ShowMessageError = GetMessageError(ex);
                Console.WriteLine($"Error at: {ShowMessageError}");
                return false;
            }
            catch (Exception ex_)
            {
                Console.WriteLine("Error at: " + ex_);
                return false;
            }
        }

        public static string GetMessageError(SqlException ex)
        {
            // Mensaje de error por defecto 
            string MessageError = "Error al interactuar con la base de datos";

            // Validaciones comúnes con la Librería de Sql Exception
            if (ex.Number == 2527)
            {
                MessageError = "Error de violación de restricción única. Ya existe un registro con la misma clave.";
            }
            else if (ex.Number == 547)
            {
                MessageError = "Error de clave externa. Verifica las relaciones entre las tablas.";
            }
            return MessageError;
        }
    }
}
