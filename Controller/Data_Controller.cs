using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Modelo;

namespace Controller
{
    public class Data_Controller
    {
        public DataTable LoadTipoUsers()
        {
            return Data_Modelo.LoadTipoUser();
        }

        public DataTable LoadEstadoUser()
        {
            return Data_Modelo.LoadEstadoUser();
        }

        public DataTable LoadUser()
        {
            return Data_Modelo.LoadoUsers();
        }

        public DataTable LoadVehicle()
        {
            return Data_Modelo.LoadoTypeVehicle();
        }

        public DataTable LoadSolicirudUser()
        {
            return Data_Modelo.LoadSolicitudUser();
        }

        public DataTable LoadVehiculo()
        {
            return Data_Modelo.LoadVehicle();
        }


        public DataTable LoadEstadoSolicitud() 
        {
            return Data_Modelo.LoadEstadoSolicitud();
        }

        public DataTable LoadSolicitud() 
        {
            return Data_Modelo.LoadSolicitud();
        }

        public DataTable LoadPoliza()
        {
            return Data_Modelo.LoadPoliza();
        }

        public DataTable LoadTipoTarjeta()
        {
            return Data_Modelo.LoadTipoTarjeta();
        }

        public DataTable LoadEquipamento()
        {
            return Data_Modelo.LoadEquipamentos();
        }

        public DataTable LoadFactura()
        {
            return Data_Modelo.LoadFactura();
        }
    }
}
