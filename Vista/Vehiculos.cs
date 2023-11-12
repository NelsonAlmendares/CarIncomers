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
    public partial class Vehiculos : Form
    {
        public Vehiculos()
        {
            InitializeComponent();
        }

        // Acceso al form principal
        readonly Form1 Main = new Form1();

        private void FillCard() 
        {
            Fill_Cards Add_Cards = new Fill_Cards();
            Add_Cards.FillData(flowLayoutPanel1);
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main.PanelStatsMain.BringToFront();
        }

        private void Vehiculos_Load(object sender, EventArgs e)
        {
            FillCard();
        }
    }
}
