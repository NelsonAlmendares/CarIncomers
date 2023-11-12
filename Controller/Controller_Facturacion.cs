using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data;

namespace Controller
{
    public class Controller_Facturacion
    {
        // Constructor de la clase
        public Controller_Facturacion() { }
        public int ID_Factura { get; set; }
        public int ID_solicitud { get; set; }
        public double Kilometraje { get; set; }
        public string Hora_Salida { get; set; }
        public string Fecha_Salida { get; set; }
        public string Detalles { get; set; }
        public string Num_Tarjeta { get; set; }
        public string Pin_Tarjeta { get; set; }
        public int Polilza_Seguro { get; set; }
        public int TipoTarjeta { get; set; }
        public int Equipamento { get; set; }

        public bool Add_Data()
        {
            return Modelo_Facturacion.InsertData(ID_solicitud, Kilometraje, Hora_Salida, Fecha_Salida, Detalles, Num_Tarjeta, Pin_Tarjeta, Polilza_Seguro, TipoTarjeta, Equipamento);
        }

        public DataTable ShowGridData() 
        {
            return Modelo_Facturacion.LoadData();
        }

    }
}
