using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Modelo
{
    public class Modelo_Contactos
    {
        public static bool InsertContacto(int ID_user, string Nombre, string Apellido, string Celuar, string Email)
        {
            bool Response;
            try
            {
                SqlCommand InsertQuery = new SqlCommand(string.Format("INSERT INTO [dbo].[Contactos] (id_usuario, Nombre_contacto, Apellido_contacto, Telefono_contacto, Email_contacto) VALUES ('{0}', '{1}','{2}', '{3}', '{4}');", ID_user, Nombre, Apellido, Celuar,Email), Model_Conexion.Connect());
                Response = Convert.ToBoolean(InsertQuery.ExecuteNonQuery());
                return Response;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error at: " + ex);
                return false;
            }
        }

        public static DataTable LoadData() 
        {
            DataTable Data;
            try
            {
                string TblSelect = "SELECT ID_contacto AS ID, CONCAT(Nombre_usuario, ' ' , Apellido_usuario) AS Usuario, CONCAT(Nombre_contacto, ' ', Apellido_contacto) AS 'Nombre del contacto', CONCAT('+ 503 ', STUFF(Telefono_contacto, LEN(Telefono_contacto) - 3, 0, '-')) AS 'Celular de contacto', Email_contacto AS 'Dirección de correo electrónico' FROM[dbo].[Contactos] INNER JOIN[dbo].[Usuario] ON[dbo].[Contactos].id_usuario = [dbo].[Usuario].ID_usuario; ";
                SqlCommand RunLoadQuery = new SqlCommand(TblSelect, Model_Conexion.Connect());
                SqlDataAdapter ADP = new SqlDataAdapter(RunLoadQuery);
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
