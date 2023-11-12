using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Modelo;

namespace Controller
{
    public class Controller_Reingreso
    {
        public Controller_Reingreso() { }

        public int ID_factura { get; set; }
        public double Kilometraje { get; set; }
        public string Hora_Entrada { get; set; }
        public string Fecha_Entreada { get; set; }
        public string Detalles { get; set; }

        public bool InsertDataController()
        {
            return Modelo_Reingreso.InsertDataQuery(ID_factura, Kilometraje, Hora_Entrada, Fecha_Entreada, Detalles);
        }

        public DataTable LoadData() 
        {
            return Modelo_Reingreso.LoadData();
        }
    }
}
