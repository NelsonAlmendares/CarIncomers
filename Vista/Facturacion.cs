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
    public partial class Facturacion : Form
    {
        public Facturacion()
        {
            InitializeComponent();
        }

        // Acceso al form principal
        readonly Form1 Main = new Form1();

        // Instancias para llenar los ComboBox desde la Base
        readonly Data_Controller LoadSolicitud = new Data_Controller();
        readonly Data_Controller LoadPoliza = new Data_Controller();
        readonly Data_Controller LoadTipoTarjeta = new Data_Controller();
        readonly Data_Controller LoadEquipamento = new Data_Controller();

        // Instancia para llenar la base de datos
        readonly Controller_Facturacion InsertData = new Controller_Facturacion();

        // Instancia para cargar el Grid de Datos
        readonly Controller_Facturacion Show_Data = new Controller_Facturacion();

        void ShowSolilcitudes ()
        {
            CmbSollicitud.DataSource = LoadSolicitud.LoadSolicitud();
            CmbSollicitud.DisplayMember = ("Solicitud");
            CmbSollicitud.ValueMember = ("ID");
        }

        void ShowPoliza ()
        {
            CmbPoliza.DataSource = LoadPoliza.LoadPoliza();
            CmbPoliza.DisplayMember = ("Poliza");
            CmbPoliza.ValueMember = ("ID_tipoSeguro");
        }

        void ShowTipoTarjeta () 
        {
            CmbTipoTarjeta.DataSource = LoadTipoTarjeta.LoadTipoTarjeta();
            CmbTipoTarjeta.DisplayMember = ("tipo_tarjeta");
            CmbTipoTarjeta.ValueMember = ("ID_tipoTarjeta");
        }

        void ShowEquipamento ()
        {
            CmbEquipamentos.DataSource = LoadEquipamento.LoadEquipamento();
            CmbEquipamentos.DisplayMember = ("Equipamento");
            CmbEquipamentos.ValueMember = ("ID_equipamento");
        }

        void LoadGrid()
        {
            dataGridView.DataSource = Show_Data.ShowGridData();
        }

        void AddFactura()
        {
            DateTime Fecha = DatePickerInicio.Value;
            string DateFormat = Fecha.ToString("yyyy-MM-dd");
            InsertData.ID_solicitud = Convert.ToInt32(CmbSollicitud.SelectedValue);
            InsertData.Kilometraje = Convert.ToDouble(Txt_Kilometraje.Text);
            InsertData.Hora_Salida = datePickerSalida.Value.ToString();
            InsertData.Fecha_Salida = DateFormat;
            InsertData.Detalles = Txt_Descripcion.Text;
            InsertData.Num_Tarjeta = Nun_Tarjeta.Text;
            InsertData.Pin_Tarjeta = Pin_Tarjeta.Text;
            InsertData.Polilza_Seguro = Convert.ToInt32(CmbPoliza.SelectedValue);
            InsertData.TipoTarjeta = Convert.ToInt32(CmbTipoTarjeta.SelectedValue);
            InsertData.Equipamento = Convert.ToInt32(CmbEquipamentos.SelectedValue);

            bool InsertToDatabase = InsertData.Add_Data();
            if (InsertToDatabase == true)
            {
                MessageBox.Show("Los datos se insertacon correctamente", "DATOS REGISTRADOS EN LA BASE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGrid();
            }
            else 
            {
                MessageBox.Show("Algo fallo, los datos no se insertacon", "DATOS DENEGADOS, NO FUERON INSERTADOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Add_Factura_Click(object sender, EventArgs e)
        {
            AddFactura();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main.PanelStatsMain.BringToFront();
        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            ShowSolilcitudes();
            ShowPoliza();
            ShowTipoTarjeta();
            ShowEquipamento();
            LoadGrid();
        }

        private void Open_Factura_Click(object sender, EventArgs e)
        {
            Rpt_FacturaFinal OpenFactura = new Rpt_FacturaFinal();
            OpenFactura.Show();
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No disponible por el momento", "HABILITADO PRÓXIMAMENTE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
