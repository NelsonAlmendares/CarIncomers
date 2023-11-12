using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Common.cache;

namespace Modelo
{
    public class Data_Modelo
    {
        public static DataTable LoadTipoUser() 
        {
            DataTable Data;
            try
            {
                string RunQuery = "SELECT * FROM [dbo].[TipoUsuario];";
                SqlCommand CmbSelect = new SqlCommand(string.Format(RunQuery), Model_Conexion.Connect());
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

        public static DataTable LoadEstadoUser()
        {
            DataTable Data;
            try
            {
                string RunQuery = "SELECT * FROM [dbo].[EstadoUsuario];";
                SqlCommand CmbSelect = new SqlCommand(string.Format(RunQuery), Model_Conexion.Connect());
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

        public static DataTable LoadoUsers()
        {
            DataTable Data;
            try
            {
                string RunQuery = "SELECT  ID_usuario ,CONCAT (Nombre_usuario, ' ' , Apellido_usuario) AS Usuario FROM [dbo].[Usuario];";
                SqlCommand CmbSelect = new SqlCommand(string.Format(RunQuery), Model_Conexion.Connect());
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


        public static DataTable LoadSolicitudUser()
        {
            DataTable Data;
            try
            {
                string RunQuery = "SELECT  ID_usuario ,CONCAT (Nombre_usuario, ' ' , Apellido_usuario) AS Usuario FROM [dbo].[Usuario] WHERE ID_tipoUsuario = 3;";
                SqlCommand CmbSelect = new SqlCommand(string.Format(RunQuery), Model_Conexion.Connect());
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

        public static DataTable LoadoTypeVehicle()
        {
            DataTable Data;
            try
            {
                string RunQuery = "SELECT * FROM [dbo].[TipoVehiculo];";
                SqlCommand CmbSelect = new SqlCommand(string.Format(RunQuery), Model_Conexion.Connect());
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

        public static DataTable LoadVehicle()
        {
            DataTable Data;
            try
            {
                string RunQuery = "SELECT ID_vehiculo ,CONCAT(Marca, ' ', Modelo, ' - Año ',' ', Anio) AS Vehiculo FROM [dbo].[RegistroVehiculo];";
                SqlCommand CmbSelect = new SqlCommand(string.Format(RunQuery), Model_Conexion.Connect());
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

        public static DataTable LoadEstadoSolicitud()
        {
            DataTable Data;
            try
            {
                string RunQuery = "SELECT * FROM [dbo].[EstadoSolicitud];";
                SqlCommand CmbSelect = new SqlCommand(string.Format(RunQuery), Model_Conexion.Connect());
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

        public static DataTable LoadSolicitud()
        {
            DataTable Data;
            try
            {
                string RunQuery = "SELECT ID, CONCAT('N° ', ID, ' - ' ,[Cliente Solicitante]) AS Solicitud FROM Select_Solicitud;";
                SqlCommand CmbSelect = new SqlCommand(string.Format(RunQuery), Model_Conexion.Connect());
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

        public static DataTable LoadPoliza()
        {
            DataTable Data;
            try
            {
                string RunQuery = "SELECT ID_tipoSeguro, CONCAT(' $',precio_poliza , ' ' ,poliza_seguro) AS Poliza FROM [dbo].[TipoSeguro];";
                SqlCommand CmbSelect = new SqlCommand(string.Format(RunQuery), Model_Conexion.Connect());
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

        public static DataTable LoadTipoTarjeta()
        {
            DataTable Data;
            try
            {
                string RunQuery = "SELECT * FROM [dbo].[TipoTarjeta];";
                SqlCommand CmbSelect = new SqlCommand(string.Format(RunQuery), Model_Conexion.Connect());
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

        public static DataTable LoadEquipamentos()
        {
            DataTable Data;
            try
            {
                string RunQuery = "SELECT ID_equipamento, CONCAT(' $',precio_equipamento, ' ', nombre_equipamento) AS Equipamento FROM [dbo].[Equipamentos];";
                SqlCommand CmbSelect = new SqlCommand(string.Format(RunQuery), Model_Conexion.Connect());
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

        public static DataTable LoadFactura()
        {
            DataTable Data;
            try
            {
                string RunQuery = "SELECT [Código de Factura] AS Codigo, [Vehículo] AS Carro FROM GetFactura;";
                SqlCommand CmbSelect = new SqlCommand(string.Format(RunQuery), Model_Conexion.Connect());
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
