using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Modelo
{
    public class Modelo_Usuario
    {
        public static int InsertData (string Nombre, string Apellido, string Documento, string Password, int Edad, string Telefono, string Celular, string Licencia, string Fecha, int EstadoUsuario, int TipoUsuario, string Usuario, string Correo)
        {
            // Método para encriptar la contraseña en SHA 256
            _ = new Encrypt();
            int response;
            try
            {
                // Instancia de Sql para poder realizar la inserccion de los datos por medio de parámetros
                SqlCommand InsertData = new SqlCommand(string.Format("EXEC Add_User @Nombre = '{0}', @Apellido = '{1}', @DUI = '{2}', @PWS = '{3}', @Edad = '{4}', @Telefono = '{5}', @Celular = '{6}', @Tarjeta = '{7}', @Fecha = '{8}', @ID_EstadoUsuario = '{9}', @ID_TipoUsuario = '{10}', @User = '{11}';", Nombre, Apellido, Documento, Encrypt.HashString(Password), Edad, Telefono, Celular, Licencia, Fecha, EstadoUsuario, TipoUsuario, Usuario, Correo),
                    Model_Conexion.Connect());
                response = Convert.ToInt32(InsertData.ExecuteNonQuery());
                return response;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error at :" + ex);
                return 0;
            }
        }

        public static DataTable LoadData() 
        {
            DataTable Data;
            try
            {
                string StringSelectQuery = "SELECT * FROM Complete_User;";
                SqlCommand CmbSelect = new SqlCommand(StringSelectQuery, Model_Conexion.Connect());
                SqlDataAdapter ADP = new SqlDataAdapter(CmbSelect);
                Data = new DataTable();
                ADP.Fill(Data);
                return Data;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error at: " + ex);
                return null;
            }
        }
    }
}
