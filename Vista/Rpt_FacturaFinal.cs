using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.DSTableAdapters;

namespace Vista
{
    public partial class Rpt_FacturaFinal : Form
    {
        public Rpt_FacturaFinal()
        {
            InitializeComponent();
        }

        private void Rpt_FacturaFinal_Load(object sender, EventArgs e)
        {
        }

        private void Btn_Factura_Click(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DS.Factura_Final' Puede moverla o quitarla según sea necesario.
            int Valor;
            Valor = Convert.ToInt32(textBox1.Text);
            this.Factura_FinalTableAdapter.Fill(this.DS.Factura_Final, Valor);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
