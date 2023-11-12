using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Modelo
{
    public class Modelo_RegistroVehiculo
    {
        public static bool InsertData(string Num_Motor, string Num_Chasis, string Capacidad, double Kilometraje, string Trasmision, string Fecha_Ingreso, double Valor_Unidad, string Puertas, string Marca, string Modelo, string Anio, string Descripcion, string Equipaje, string Placas, int ID_tipoVehiculo)
        { 
            bool response;
            try
            {
                SqlCommand InsertData = new SqlCommand(string.Format("EXEC Add_Vehicle @NumeroMotor = '{0}', @NumeroChasis = '{1}', @Capacidad = '{2}', @Kilometraje = '{3}', @Transmicion = '{4}', @FechaIngreso = '{5}', @ValorUnidad = '{6}', @Puertas = '{7}', @Marca = '{8}', @Modelo = '{9}', @Anio = '{10}', @Descripcion = '{11}', @Equipaje = '{12}', @Placa = '{13}', @ID_TipoVhehiculo = '{14}';", Num_Motor, Num_Chasis, Capacidad, Kilometraje, Trasmision, Fecha_Ingreso, Valor_Unidad, Puertas, Marca, Modelo, Anio, Descripcion, Equipaje, Placas, ID_tipoVehiculo), Model_Conexion.Connect());
                response = Convert.ToBoolean(InsertData.ExecuteNonQuery());
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
                string LoadQuery = "SELECT * FROM Registro_Vehiculo;";
                SqlCommand RunQuery = new SqlCommand(string.Format(LoadQuery), Model_Conexion.Connect());
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
