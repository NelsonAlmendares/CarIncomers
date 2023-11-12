using Common.cache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Controller;

namespace Vista
{
    public class Fill_Cards
    {
        private int ID;
        private string vehiculo;
        private string tipoVehiculo;
        private string transmicion;
        private string anio;
        private string fechaFinalizacion;
        private string horaFinalizacion;

        public int Id
        { get => ID; set => ID = value; }

        public string Vehiculo
        { get => vehiculo; set => vehiculo = value; }

        public string TipoVehiculo
        { get => tipoVehiculo; set => tipoVehiculo = value; }

        public string Transmicion
        { get => transmicion; set => transmicion = value; }

        public string Anio
        { get => anio; set => anio = value; }

        public string FechaFinalizacion
        { get => fechaFinalizacion; set => fechaFinalizacion = value; }

        public string HoraFinalizacion
        { get => horaFinalizacion; set => horaFinalizacion = value; }


        public void FillData(FlowLayoutPanel Container)
        {
            int ID = UserLoginCache.ID;
            string TransacSql = "SELECT * FROM Vehiculo WHERE estado_solicitud = 'Aprobada' AND id_cliente = @ID;";

            SqlConnection GetConnet = Controller_Conexion.ConnectModel();
            SqlCommand RunQuery = new SqlCommand(TransacSql, GetConnet);

            // Agregamos el parámetro del ID con el que se inicia sesión
            RunQuery.Parameters.AddWithValue("@ID", ID);
            SqlDataReader reader = RunQuery.ExecuteReader();

            while (reader.Read())
            {
                vehiculo = reader[2].ToString();
                tipoVehiculo = reader[3].ToString();
                transmicion = reader[4].ToString();
                anio = reader[5].ToString();
                fechaFinalizacion = reader[7].ToString();
                HoraFinalizacion = reader[9].ToString();

                CardVehiculo Card = new CardVehiculo();
                Card.Vehiculo = vehiculo;
                Card.TipoVehiculo = tipoVehiculo;
                Card.Transmicion = transmicion;
                Card.Anio = anio;
                Card.FechaFinalizacion = fechaFinalizacion;
                Card.HoraFinalizacion = horaFinalizacion;

                Container.Controls.Add(Card);
            }
        }
    }
}
