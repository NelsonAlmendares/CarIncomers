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
    public class Modelo_Facturacion
    {
        public static bool InsertData(int ID_solicitud, double Kilometraje, string Hora_Salida, string Fecha_Salida, string Detalles, string Num_Tarjeta, string Pin_Tarjeta, int Polilza_Seguro, int TipoTarjeta, int Equipamento)
        {
            _ = new Encrypt();
            bool response;
            try
            {
                SqlCommand InsertQuery = new SqlCommand(string.Format("INSERT INTO [dbo].[Facturacion] (Id_solicitud, Kilometraje_vehiculo, Hora_salida, Fecha_salida, Detalles_vehiculo, Numero_tarjeta, Pin_tarjeta, Poliza_seguro, Tipo_tarjeta, Equipamentos) " + 
                    "VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}');", ID_solicitud, Kilometraje, Hora_Salida, Fecha_Salida, Detalles, Encrypt.HashString(Num_Tarjeta), Encrypt.HashString(Pin_Tarjeta), Polilza_Seguro, TipoTarjeta, Equipamento), Model_Conexion.Connect());
                response = Convert.ToBoolean(InsertQuery.ExecuteNonQuery());
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
                string SelectQuery = "SELECT * FROM Factura;";
                SqlCommand RunQuery = new SqlCommand(string.Format(SelectQuery), Model_Conexion.Connect());
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
