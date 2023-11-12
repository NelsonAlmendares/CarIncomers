using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Common.cache;

namespace Modelo
{
    public class Modelo_Solicitud
    {
        public static bool InsertData (int ID_cliente, int Estado_Solicitud, int ID_vehiculo, string Fecha_Inicio, string Fecha_Fin, string Hora_Inicio, string Hora_Fin)
        {
            bool response;
            try
            {
                SqlCommand InsertQuery = new SqlCommand(string.Format("INSERT INTO [dbo].[Solicitudes] (id_cliente, id_estadoSolicitud, id_vehiculo, Fecha_inicio, Fecha_fin, Hora_inicio, Hora_fin) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');", ID_cliente, Estado_Solicitud, ID_vehiculo, Fecha_Inicio, Fecha_Fin, Hora_Inicio, Hora_Fin), Model_Conexion.Connect());
                response = Convert.ToBoolean(InsertQuery.ExecuteNonQuery());
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error at: " + ex);
                return false;
            }
        }

        public static bool UpdateData(int ID_cliente, int Estado_Solicitud, int ID_vehiculo, string Fecha_Inicio, string Fecha_Fin, string Hora_Inicio, string Hora_Fin, int ID_solicitud)
        {
            bool response;
            try
            {
                SqlCommand InsertQuery = new SqlCommand(string.Format("EXEC Update_Solicitud @NEW_ID = '{0}' , @NEW_ESTAD = '{1}', @NEW_VEHICLE = '{2}', @NEW_STARTDATE = '{3}', @NEW_FINISHDATE = '{4}', @NEW_STARTHOUR = '{5}', @NEW_FINISHTIME = '{6}', @SOLICITUD_ID = '{7}';", ID_cliente, Estado_Solicitud, ID_vehiculo, Fecha_Inicio, Fecha_Fin, Hora_Inicio, Hora_Fin, ID_solicitud), Model_Conexion.Connect());
                response = Convert.ToBoolean(InsertQuery.ExecuteNonQuery());
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error at: " + ex);
                return false;
            }
        }

        public static bool DeleteData(int ID_Solicitud)
        {
            bool response;
            try
            {
                string QueryDelete = "DELETE FROM [dbo].[Solicitudes] WHERE ID_solicitud = @ID_Solicitud;";
                SqlConnection ConnectData = Model_Conexion.Connect();
                SqlCommand RunDelete = new SqlCommand(QueryDelete, ConnectData);

                RunDelete.Parameters.AddWithValue("@ID_Solicitud", ID_Solicitud);
                SqlDataReader reader = RunDelete.ExecuteReader();
                response = true;

                ConnectData.Close();
                return response;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error at: " + ex);
                return false;
            }
        }

        // Con este método lleno el ComboBox con el nombre del usuario que se obtiene con el Cache del Login
        public static DataTable LoadUserFromLogin()
        {
            DataTable Data;
            int GetUserId = UserLoginCache.ID;

            try
            {
                string RunQuery = "SELECT  ID_usuario ,CONCAT (Nombre_usuario, ' ' , Apellido_usuario) AS Usuario FROM [dbo].[Usuario] WHERE ID_usuario =  @UserID;";
                SqlCommand CmbSelect = new SqlCommand(string.Format(RunQuery), Model_Conexion.Connect());
                // Mandamos el parámetro para llenar el ComboBox y lo dejamos inhabilitado para dejar un nivel de usuario sin privilegios de actualizar el CRUD
                CmbSelect.Parameters.AddWithValue("@UserID", GetUserId);

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

        public static DataTable LoadData() 
        {
            DataTable Data;
            try
            {
                string SelectQuery = "SELECT * FROM Select_Solicitud;";
                SqlCommand CmbSelect = new SqlCommand(SelectQuery, Model_Conexion.Connect());
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

        public static DataTable LoadDataClient()
        {
            DataTable Data;
            try
            {
                string User = UserLoginCache.Nombre;

                string SelectQuery = "SELECT * FROM Select_Solicitud WHERE [Cliente Solicitante] = @user;";
                SqlCommand CmbSelect = new SqlCommand(SelectQuery, Model_Conexion.Connect());
                CmbSelect.Parameters.AddWithValue("@user", User);
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

        // Query para cargar el ComboBox de las solicitudes realizadas para ser actualizadas

        public static DataTable LoadUsersInner(string Nombre)
        {
            DataTable Data;
            try
            {
                string RunQuery = "SELECT ID_usuario ,CONCAT (Nombre_usuario, ' ' , Apellido_usuario) AS Usuario FROM [dbo].[Usuario] WHERE CONCAT (Nombre_usuario, ' ' , Apellido_usuario) = @Nombre;";
                SqlCommand CmbSelect = new SqlCommand(string.Format(RunQuery), Model_Conexion.Connect());
                CmbSelect.Parameters.AddWithValue("@Nombre", Nombre);
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

        public static DataTable LoadVehiculoInner(string Vehicle)
        {
            DataTable Data;
            try
            {
                string RunQuery = "SELECT ID_vehiculo ,CONCAT(Marca, ' ', Modelo, ' - Año ',' ', Anio) AS Vehiculo FROM [dbo].[RegistroVehiculo] WHERE CONCAT(Marca, ' ', Modelo, ' - Año ',' ', Anio) = @Vehicle;";
                SqlCommand CmbSelect = new SqlCommand(string.Format(RunQuery), Model_Conexion.Connect());
                CmbSelect.Parameters.AddWithValue("@Vehicle", Vehicle);
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

        public static DataTable LoadEstadoSolicitudInner(string Solicitud)
        {
            DataTable Data;
            try
            {
                string RunQuery = "SELECT ID_estadoSolicitud, estado_solicitud FROM [dbo].[EstadoSolicitud] WHERE estado_solicitud = @Solicitud;";
                SqlCommand CmbSelect = new SqlCommand(string.Format(RunQuery), Model_Conexion.Connect());
                CmbSelect.Parameters.AddWithValue("@Solicitud", Solicitud);
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
