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
    public partial class Rentas : UserControl
    {
        public Rentas()
        {
            InitializeComponent();
        }

        public string Vehiculo 
        {
            get { return Lbl_Vehiculo.Text; }
            set { Lbl_Vehiculo.Text = value; }
        }

        public string Renta
        {
            get { return Lbl_renta.Text; }
            set { Lbl_renta.Text = value; }
        }

        public string Entregado
        {
            get { return Lbl_Entrega.Text; }
            set { Lbl_Entrega.Text = value; }
        }

        public string Estado
        {
            get { return Lbl_Estado.Text; }
            set { Lbl_Estado.Text = value; }
        }

        public string Total
        {
            get { return Lbl_precio.Text; }
            set { Lbl_precio.Text = value; }
        }
    }
}
