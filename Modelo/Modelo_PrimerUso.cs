using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Common;

namespace Modelo
{
    public class Modelo_PrimerUso
    {
        public static int Check_User() 
        {
            int RowCount;
            try
            {
                // Verificamos por medio de una consulta que hayan usuarios registrados en la base de datos
                string Query = "SELECT * FROM [dbo].[Usuario];";
                SqlCommand RunQuery = new SqlCommand(string.Format(Query), Model_Conexion.Connect());
                RowCount = Convert.ToInt32(RunQuery.ExecuteScalar());
                return RowCount;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error at: " + ex);
                return 0;
            }
        }

        Encrypt en = new Encrypt();

        public static int InsertData(string Nombre, string Apellido, string Usuario, string Documento, string Password, int Edad, string Telefono, string Celular, string Licencia, string Fecha, int TipoUsuario, int EstadoUsuario)                 
        {
            int retorno = 0;
            try
            {
                SqlCommand InsertQuery = new SqlCommand(string.Format("INSERT INTO [dbo].[Usuario] (Nombre_usuario, Apellido_usuario, Documento, Password_usuario, Edad_usuario, Telefono_usuario, Celular_usuario, Numero_tarjeta, Fecha_tarjeta, ID_estadoUsuario, ID_tipoUsuario, Acceso_usuario) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}', '{10}', '{11}');", Nombre, Apellido, Usuario, Documento, Encrypt.GetHash(Password) ,Edad ,Telefono ,Celular ,Licencia ,Fecha ,TipoUsuario , EstadoUsuario), Model_Conexion.Connect());
                retorno = Convert.ToInt32(InsertQuery.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error at: " + ex);
                return 0;
            }
        }
    }
}
