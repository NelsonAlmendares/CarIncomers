using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;

namespace Vista
{
    public partial class Reingreso : Form
    {
        public Reingreso()
        {
            InitializeComponent();
        }

        // Acceso al form principal
        readonly Form1 Main = new Form1();
        // Instancia para llenar los datos en la Base
        readonly Controller_Reingreso Add_Data = new Controller_Reingreso();
        // Instancia para llenar los datos en la Base
        readonly Data_Controller ShowData = new Data_Controller();

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main.PanelStatsMain.BringToFront();
        }

        void ShowGrid() 
        {
            dataGridView.DataSource = Add_Data.LoadData();
        }

        void ClenaData() 
        {
            Txt_Detalles.ResetText();
            Txt_Reingreso.ResetText();
        }

        void LoadCmb() 
        {
            try
            {
                ComboBox.DataSource = ShowData.LoadFactura();
                ComboBox.DisplayMember = ("Carro");
                ComboBox.ValueMember = ("Codigo");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error at: " + ex);
            }
        }

        void InsertReingreso ()
        { 
            DateTime FechaInicio = DatePickerIngreso.Value;
            string DateFormat = FechaInicio.ToString("yyyy-MM-dd");

            Add_Data.ID_factura = Convert.ToInt32(ComboBox.SelectedValue);
            Add_Data.Kilometraje = Convert.ToDouble(Txt_Reingreso.Text);
            Add_Data.Hora_Entrada = datePickerLlegada.Value.ToString();
            Add_Data.Fecha_Entreada = DateFormat;
            Add_Data.Detalles = Txt_Detalles.Text;

            bool reposnse = Add_Data.InsertDataController();
            if (reposnse == true)
            {
                MessageBox.Show("Los datos fueron agregados correctamente", "DATOS REGISTRADOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowGrid();
                ClenaData();
            }
            else 
            {
                MessageBox.Show("Oops, algo salió mal, los datos no fueron agregados", "DATOS DENEGADOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Reingreso_Click(object sender, EventArgs e)
        {
            InsertReingreso();
        }

        private void Reingreso_Load(object sender, EventArgs e)
        {
            LoadCmb();
            ShowGrid();
        }
    }
}
