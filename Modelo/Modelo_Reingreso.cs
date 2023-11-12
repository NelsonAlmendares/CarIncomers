using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Modelo
{
    public class Modelo_Reingreso
    {
        public static bool InsertDataQuery(int ID_factura, double Kilometraje, string Hora_Entrada, string Fecha_Entreada, string Detalles) 
        {
            bool response;
            try
            {
                SqlCommand RunInsert = new SqlCommand(string.Format("INSERT INTO [dbo].[Reingreso] (id_factura, Kilometraje, Hora_entrada, Fecha_Entrada, Detalles) VALUES ('{0}','{1}','{2}','{3}','{4}');", ID_factura, Kilometraje, Hora_Entrada, Fecha_Entreada, Detalles), Model_Conexion.Connect());
                response = Convert.ToBoolean(RunInsert.ExecuteNonQuery());
                return response;
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
                string SelectQuery = "SELECT * FROM Reingresos;";
                SqlConnection GetConnect = Model_Conexion.Connect();
                SqlCommand RunQuery = new SqlCommand(string.Format(SelectQuery), GetConnect);
                SqlDataAdapter ADP = new SqlDataAdapter(RunQuery);
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
