using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data;

namespace Controller
{
    public class Controller_Solicitud
    {
        // Constructor de la clase
        public Controller_Solicitud() { }
        public int  ID_solicitud { get; set; }
        public int ID_cliente { get; set; }
        public int Estado_Solicitud { get; set; }
        public int ID_vehiculo { get; set; }
        public string Fecha_Inicio { get; set; }
        public string Fecha_Fin { get; set; }
        public string Hora_Inicio { get; set; }
        public string Hora_Fin { get; set; }

        public bool InsertData ()
        {
            return Modelo_Solicitud.InsertData(ID_cliente, Estado_Solicitud, ID_vehiculo, Fecha_Inicio, Fecha_Fin, Hora_Inicio, Hora_Fin);
        }

        public bool UpdateData() 
        {
            return Modelo_Solicitud.UpdateData(ID_cliente, Estado_Solicitud, ID_vehiculo, Fecha_Inicio, Fecha_Fin, Hora_Inicio, Hora_Fin, ID_solicitud);
        }

        public bool DeleteData()
        {
            return Modelo_Solicitud.DeleteData(ID_solicitud);
        }

        // Para nivel de Administrador
        public DataTable LoadGridData() 
        {
            return Modelo_Solicitud.LoadData();
        }

        // Para nivel de Cliente
        public DataTable LoadGridDataCliente()
        {
            return Modelo_Solicitud.LoadDataClient();
        }
        public DataTable ShowUserFromLogin() 
        {
            return Modelo_Solicitud.LoadUserFromLogin();
        }

        // METODOS PARA ACTUALIZAR LOS DATOS
        public DataTable LoadUserInnerController(string User)
        {
            return Modelo_Solicitud.LoadUsersInner(User);
        }

        public DataTable LoadVehicleInnerController(string Vehicle)
        {
            return Modelo_Solicitud.LoadVehiculoInner(Vehicle);
        }

        public DataTable LoadEstadoSolicituddInnerController(string Solicitud)
        {
            return Modelo_Solicitud.LoadEstadoSolicitudInner(Solicitud);
        }
    }
}
