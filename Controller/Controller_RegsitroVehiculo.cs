using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data;

namespace Controller
{
    public class Controller_RegsitroVehiculo
    {
        public Controller_RegsitroVehiculo() { }
        public int ID_vehiculo { get; set; }
        public string Num_Motor { get; set; }
        public string Num_Chasis { get; set; }
        public string Capacidad { get; set; }
        public double Kilometraje { get; set; }
        public string Trasmision { get; set; }
        public string Fecha_Ingreso { get; set; }
        public double Valor_Unidad { get; set; }
        public string Puertas { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Anio { get; set; }
        public string Descripcion { get; set; }
        public string Equipaje { get; set; }
        public string Placas { get; set; }
        public int ID_tipoVehiculo { get; set; }

        // Cargamos los datos
        public DataTable LoadTable() 
        {
            return Modelo_RegistroVehiculo.LoadData();
        }

        public bool InsertData ()
        {
            return Modelo_RegistroVehiculo.InsertData(Num_Motor, Num_Chasis, Capacidad, Kilometraje, Trasmision, Fecha_Ingreso, Valor_Unidad, Puertas, Marca, Modelo, Anio, Descripcion, Equipaje, Placas, ID_tipoVehiculo);
        }
    }
}
