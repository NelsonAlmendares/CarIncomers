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
    public partial class Registro_Vehiculos : Form
    {
        public Registro_Vehiculos()
        {
            InitializeComponent();
        }

        // Acceso al form principal
        readonly Form1 Main = new Form1();
        // Instancia para llenar los datos del Grid
        readonly Controller_RegsitroVehiculo LoadData = new Controller_RegsitroVehiculo();
        // Instancia para agregar los datos a la base
        readonly Controller_RegsitroVehiculo InsertData = new Controller_RegsitroVehiculo();
        // Instancia para llenar los datos de un ComboBox con los tipos de vehiculos registrados
        readonly Data_Controller LoadTypes = new Data_Controller();

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main.PanelStatsMain.BringToFront();
        }

        void LoadGrid ()
        {
            dataGridView.DataSource = LoadData.LoadTable();
        }

        void FillData ()
        {
            CmbTipoVehiculo.DataSource = LoadTypes.LoadVehicle();
            CmbTipoVehiculo.ValueMember = ("ID_tipoVehiculo");
            CmbTipoVehiculo.DisplayMember = ("tipo_vehiculo");
        }

        void CleanData()
        {
            Txt_NumeroMotor.ResetText();
            Txt_NumeroChasis.ResetText();
            Txt_Descripcion.ResetText();
            Txt_Capacidad.ResetText();
            Txt_Transmision.ResetText();
            Txt_ValorUnidad.ResetText();
            Txt_Marca.ResetText();
            Txt_Anio.ResetText();
            Txt_kilometraje.ResetText();
            Txt_puertas.ResetText();
            Txt_Modelo.ResetText();
            Txt_Placa.ResetText();
            Txt_CapacidadVehiculo.ResetText();
        }

        void InsertDatos()
        {
            if (Txt_NumeroMotor.Text == "" && Txt_NumeroChasis.Text == "" && Txt_Descripcion.Text == ""
                && Txt_Capacidad.Text == "" && Txt_Transmision.Text == "" && Txt_ValorUnidad.Text == ""
                && Txt_Marca.Text == "" && Txt_Anio.Text == "" && Txt_kilometraje.Text == "" && Txt_puertas.Text == ""
                && Txt_Modelo.Text == "" && Txt_Placa.Text == "" && Txt_CapacidadVehiculo.Text == "")
            {
                MessageBox.Show("Campos vacíos, revisa que todos los campos han sido llenamdos correctamente", "Por favor llena todos los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                DateTime Fecha = DateTimePicker.Value;
                string DateFormat = Fecha.ToString("yyyy-MM-dd");
                InsertData.Num_Motor = Txt_NumeroMotor.Text;
                InsertData.Num_Chasis = Txt_NumeroChasis.Text;
                InsertData.Descripcion = Txt_Descripcion.Text;
                InsertData.Capacidad = Txt_Capacidad.Text;
                InsertData.Trasmision = Txt_Transmision.Text;
                InsertData.Fecha_Ingreso = DateFormat;
                InsertData.Valor_Unidad = Convert.ToDouble(Txt_ValorUnidad.Text);
                InsertData.Marca = Txt_Marca.Text;
                InsertData.Anio = Txt_Anio.Text;
                InsertData.Kilometraje = Convert.ToDouble(Txt_kilometraje.Text);
                InsertData.Puertas = Txt_puertas.Text;
                InsertData.Modelo = Txt_Modelo.Text;
                InsertData.Placas = Txt_Placa.Text;
                InsertData.Equipaje = Txt_CapacidadVehiculo.Text;
                InsertData.ID_tipoVehiculo = Convert.ToInt32(CmbTipoVehiculo.SelectedValue);
                bool response = InsertData.InsertData();
                if (response == true)
                {
                    MessageBox.Show("Datos agregados Correctamente", "DATOS REGISTRADOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadGrid();
                    CleanData();
                }
                else 
                {
                    MessageBox.Show("Ocurrío un error, no pudo ser registrado", "DATOS DENEGADOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Register_Vehiculo_Click(object sender, EventArgs e)
        {
            InsertDatos();
        }
        
        private void Registro_Vehiculos_Load(object sender, EventArgs e)
        {
            LoadGrid();
            FillData();
            Txt_NumeroMotor.MaxLength = 12;
            Txt_NumeroChasis.MaxLength = 18;
        }
    }
}
