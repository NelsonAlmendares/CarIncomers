using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Common.cache;
using Controller;
using System.Data.SqlClient;

namespace Vista
{
    public partial class s : Form
    {
        public s()
        {
            InitializeComponent();
        }

        // Definimos conrtroles de acceso en el caso de se haga un login con nivel de usuario Cliente
        private void User_Rol()
        {
            // Controlamos las acciones que se pueden realizar por cada usuario

            if (UserLoginCache.TipoUsuario == "Root")
            {
                // Todos los permisos para controlar el sistema
                dataGridView1.Hide();
                CmbUser.Enabled = true;
            }
            else if (UserLoginCache.TipoUsuario == "Administrador")
            {
                CmbUser.Enabled = true;
            }
            else if (UserLoginCache.TipoUsuario == "Cliente")
            {
                Lbl_Estado.Visible = false;
                CmbEstadoSolicitud.Visible = false;
                LoadGridCliente();
                dataGridView.Hide();

                // Deshabilitamos las busquedas de los datos a este nivel de Usuario
                TxtBusqueda.Visible = false;
                BtnSeacrh.Visible = false;
                ReloadGrid.Visible = false;

                // Cargamos el ComboBox de Usuario con el dato que se toma desde el Login
                ShowUserClienteLogin();
                CmbUser.Enabled = false;
            }
        }

        // Acceso al form principal
        readonly Form1 Main = new Form1();
        // Instancia para cargar los datos en los ComboBox
        readonly Data_Controller LoadData = new Data_Controller();
        readonly Data_Controller LoadVehicle = new Data_Controller();
        readonly Data_Controller LoadEstado = new Data_Controller();
        // Instancia para llenar los datos en la Base
        readonly Controller_Solicitud ShowData = new Controller_Solicitud();
        // Instancia para borrar los datos en la Base
        readonly Controller_Solicitud DeleteData = new Controller_Solicitud();
        // Instancia para ingresar los datos a la base
        readonly Controller_Solicitud AddtData = new Controller_Solicitud();

        void ShowUserClienteLogin() 
        {
            try
            {
                CmbUser.DataSource = ShowData.ShowUserFromLogin();
                CmbUser.DisplayMember = "Usuario";
                CmbUser.ValueMember = "ID_usuario";
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error at: " + ex);
            }
        }

        void ShowUser()
        {
            try
            {
                CmbUser.DataSource = LoadData.LoadSolicirudUser();
                CmbUser.DisplayMember = "Usuario";
                CmbUser.ValueMember = "ID_usuario";
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error at: " + ex);
            }
        }

        void ShowVehicle()
        {
            try
            {
                CmbVehicle.DataSource = LoadVehicle.LoadVehiculo();
                CmbVehicle.DisplayMember = "Vehiculo";
                CmbVehicle.ValueMember = "ID_vehiculo";
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error at: " + ex);
            }
        }

        void ShowEstado()
        {
            try
            {
                CmbEstadoSolicitud.DataSource = LoadEstado.LoadEstadoSolicitud();
                CmbEstadoSolicitud.DisplayMember = "estado_solicitud";
                CmbEstadoSolicitud.ValueMember = "ID_estadoSolicitud";
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error at: " + ex);
            }
        }

        void LoadGridCliente()
        {
            dataGridView1.DataSource = ShowData.LoadGridDataCliente();
        }

        void ShowGrid()
        {
            dataGridView.DataSource = ShowData.LoadGridData();
        }

        void InsertData()
        {
            DateTime FechaInicio = DatePickerInicio.Value;
            string DateInicioFormat = FechaInicio.ToString("yyyy-MM-dd");
            DateTime FechaFin = DatePickerIngreso.Value;
            string DateFinFormat = FechaFin.ToString("yyyy-MM-dd");

            AddtData.ID_cliente = Convert.ToInt32(CmbUser.SelectedValue);
            AddtData.Estado_Solicitud = Convert.ToInt32(CmbEstadoSolicitud.SelectedValue);
            AddtData.ID_vehiculo = Convert.ToInt32(CmbVehicle.SelectedValue);
            AddtData.Fecha_Inicio = DateInicioFormat;
            AddtData.Fecha_Fin = DateFinFormat;
            AddtData.Hora_Inicio = datePickerSalida.Value.ToString();
            AddtData.Hora_Fin = datePickerLlegada.Value.ToString();

            bool response = AddtData.InsertData();
            if (response == true)
            {
                MessageBox.Show("Datos agregados correctamente", "DATOS REGISTRADOS EN LA BASE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CleanData();
                ShowGrid();
                LoadGridCliente();
            }
            else
            {
                MessageBox.Show("Algo fallo, no se pudo registrar en la base", "DATOS DENEGADOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void UpdateData()
        {
            DateTime FechaInicio = DatePickerInicio.Value;
            string DateInicioFormat = FechaInicio.ToString("yyyy-MM-dd");
            DateTime FechaFin = DatePickerIngreso.Value;
            string DateFinFormat = FechaFin.ToString("yyyy-MM-dd");

            AddtData.ID_solicitud = Convert.ToInt32(Txt_ID.Text);
            AddtData.ID_cliente = Convert.ToInt32(CmbUser.SelectedValue);
            AddtData.Estado_Solicitud = Convert.ToInt32(CmbEstadoSolicitud.SelectedValue);
            AddtData.ID_vehiculo = Convert.ToInt32(CmbVehicle.SelectedValue);
            AddtData.Fecha_Inicio = DateInicioFormat;
            AddtData.Fecha_Fin = DateFinFormat;
            AddtData.Hora_Inicio = datePickerSalida.Value.ToString();
            AddtData.Hora_Fin = datePickerLlegada.Value.ToString();

            bool response = AddtData.UpdateData();
            if (response == true)
            {
                MessageBox.Show("Datos actualizados correctamente", "DATOS REGISTRADOS EN LA BASE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CleanData();
                ShowGrid();
                LoadGridCliente();
                Btn_Solicitud.Enabled = false;
                Btn_Eliminar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Algo fallo, no se pudieron actualizar los datos en la base", "DATOS DENEGADOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Delete_Data()
        {
            if (MessageBox.Show("Está seguro de eliminar esta solicitud?", "ELIMINAR SOLICITUD", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DeleteData.ID_solicitud = Convert.ToInt32(Txt_ID.Text);
                bool response = DeleteData.DeleteData();
                if (response == true)
                {
                    MessageBox.Show("Datos fueron eliminados de la base", "DATOS ELIMIADOS DE LA BASE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CleanData();
                    ShowGrid();
                    LoadGridCliente();
                    Btn_Solicitud.Enabled = false;
                    Btn_Eliminar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Algo fallo, no se pudieron eliminar los datos en la base", "DATOS NO ELIMINADOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else 
            {
                MessageBox.Show("Puede continuar navegando en la sesión", "SESIÓN ACTIVA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void CleanData() 
        {
            Txt_ID.ResetText();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main.PanelStatsMain.BringToFront();
        }

        private void Register_Solicitud_Click(object sender, EventArgs e)
        {
            InsertData();
        }

        private void Solicitudes_Load(object sender, EventArgs e)
        {
            // ShowUser();
            ShowVehicle();
            ShowEstado();
            ShowGrid();
            // Método para realizar los niveles de usuario
            User_Rol();
            // Aseguramos la integridad del CRUD para realizar las acciones
            Btn_Solicitud.Enabled = false;
            Btn_Eliminar.Enabled = false;
        }

        private void Solicitud_Admin(object sender, DataGridViewCellEventArgs e)
        {
            int Posicion = dataGridView.CurrentRow.Index;
            Txt_ID.Text = dataGridView[0, Posicion].Value.ToString();
            // Cargamos los datos en el ComboBox:
            string UserPosition = dataGridView[1, Posicion].Value.ToString();
            string VehiclePosition = dataGridView[2, Posicion].Value.ToString();
            string SolicitudPosition = dataGridView[3, Posicion].Value.ToString();
            // Los demás campos
            DatePickerInicio.Text = dataGridView[4, Posicion].Value.ToString();
            DatePickerIngreso.Text = dataGridView[5, Posicion].Value.ToString();
            datePickerSalida.Text = dataGridView[6, Posicion].Value.ToString();
            datePickerLlegada.Text = dataGridView[7, Posicion].Value.ToString();

            // Para los usuarios:
            CmbUser.DataSource = ShowData.LoadUserInnerController(UserPosition);
            CmbUser.DisplayMember = "Usuario";
            CmbUser.ValueMember = "ID_usuario";
            // Para los vehículos
            CmbVehicle.DataSource = ShowData.LoadVehicleInnerController(VehiclePosition);
            CmbVehicle.DisplayMember = "Vehiculo";
            CmbVehicle.ValueMember = "ID_vehiculo";
            // Para los Estados de Solicitudes
            CmbEstadoSolicitud.DataSource = ShowData.LoadEstadoSolicituddInnerController(SolicitudPosition);
            CmbEstadoSolicitud.DisplayMember = "estado_solicitud";
            CmbEstadoSolicitud.ValueMember = "ID_estadoSolicitud";

            Register_Solicitud.Enabled = false;
            Btn_Solicitud.Enabled = true;
            Btn_Eliminar.Enabled = true;
        }

        private void CmbUser_Click(object sender, EventArgs e)
        {
            ShowUser();
        }

        private void CmbVehicle_Click(object sender, EventArgs e)
        {
            ShowVehicle();
        }

        private void CmbEstadoSolicitud_Click(object sender, EventArgs e)
        {
            ShowEstado();
        }

        private void Btn_Solicitud_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            Delete_Data();
        }

        private void GridCliente(object sender, DataGridViewCellEventArgs e)
        {
            int Posicion = dataGridView.CurrentRow.Index;
            Txt_ID.Text = dataGridView[0, Posicion].Value.ToString();
            // Cargamos los datos en el ComboBox:
            string UserPosition = dataGridView[1, Posicion].Value.ToString();
            string VehiclePosition = dataGridView[2, Posicion].Value.ToString();
            string SolicitudPosition = dataGridView[3, Posicion].Value.ToString();
            // Los demás campos
            DatePickerInicio.Text = dataGridView[4, Posicion].Value.ToString();
            DatePickerIngreso.Text = dataGridView[5, Posicion].Value.ToString();
            datePickerSalida.Text = dataGridView[6, Posicion].Value.ToString();
            datePickerLlegada.Text = dataGridView[7, Posicion].Value.ToString();

            // Para los vehículos
            CmbVehicle.DataSource = ShowData.LoadVehicleInnerController(VehiclePosition);
            CmbVehicle.DisplayMember = "Vehiculo";
            CmbVehicle.ValueMember = "ID_vehiculo";

            Register_Solicitud.Enabled = false;
            Btn_Solicitud.Enabled = true;
            Btn_Eliminar.Enabled = true;
        }

        void SearchData()
        {
            string Search = TxtBusqueda.Text;
            ShowData.Busqueda = TxtBusqueda.Text;
            int match = ShowData.CheckingMatch(Search);

            if (match != 0)
            {
                dataGridView.DataSource = ShowData.SearchData(Search);
            }            
            else if (match == 0)
            {
                MessageBox.Show("No se encontratron coincidencias en los registros", "DATOS NO ENCONTRADOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ShowGrid();
            }
            else if (TxtBusqueda.Text == "")
            {
                MessageBox.Show("Debes ingresar datos en la barra de busqueda", "INGRESAR DATOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowGrid();
            }
            else
            {
                dataGridView.DataSource = ShowData.SearchData(Search);
            }

            
        }

        private void TxtBusqueda_Enter(object sender, EventArgs e)
        {
            // Maneja el evento GotFocus para limpiar el texto predeterminado cuando el usuario hace clic en el TextBox
            if (TxtBusqueda.Text == "Search...")
            {
                TxtBusqueda.Text = string.Empty;
                TxtBusqueda.ForeColor = SystemColors.WindowText; // Restaura el color del texto
            }
        }

        private void TxtBusqueda_Leave(object sender, EventArgs e)
        {
            // Maneja el evento LostFocus para restaurar el texto predeterminado si el usuario no ha ingresado nada
            if (string.IsNullOrWhiteSpace(TxtBusqueda.Text))
            {
                TxtBusqueda.Text = "Search...";
                TxtBusqueda.ForeColor = SystemColors.GrayText; // Cambia el color del texto predeterminado
            }
        }

        private void BtnSeacrh_Click(object sender, EventArgs e)
        {
            SearchData();
        }

        private void ReloadGrid_Click(object sender, EventArgs e)
        {
            ShowGrid();
            TxtBusqueda.ResetText();
        }
    }
}
