using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class CardVehiculo : UserControl
    {
        private int ID = 0;

        public CardVehiculo()
        {
            InitializeComponent();
        }

        // Asignamos y creamos las instancias para cargar en los Labels datos desde la base

        private void CardVehiculo_Load(object sender, EventArgs e)
        {

        }

        // Métodos públicos
        public int Id
        {
            get { return ID; }
            set { ID = value; }
        }

        public string Vehiculo 
        {
            get { return Lbl_Vehiculo.Text; }
            set { Lbl_Vehiculo.Text = value; }
        }

        public string TipoVehiculo
        {
            get { return Lbl_Tipo.Text; }
            set { Lbl_Tipo.Text = value; }
        }

        public string Transmicion 
        {
            get { return Lbl_Transmicion.Text; }
            set { Lbl_Transmicion.Text = value; }
        }

        public string Anio 
        {
            get { return Lbl_anio.Text; }
            set { Lbl_anio.Text = value; }
        }

        public string FechaFinalizacion 
        {
            get { return Lbl_fecha.Text; }
            set { Lbl_fecha.Text = value; }
        }

        public string HoraFinalizacion 
        {
            get { return Lbl_hora.Text; }
            set { Lbl_hora.Text = value; }
        }

    }
}
