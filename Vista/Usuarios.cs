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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        // Instancia para llenar los combo box
        readonly Data_Controller LoadDataUser = new Data_Controller();
        // Acceso para cargar los datos en el Grid
        readonly Controller_Usuario ShowData = new Controller_Usuario();
        // Acceso para cargar los datos en el Grid
        readonly Controller_Usuario Insert_User = new Controller_Usuario();
        // Acceso al form principal
        readonly Form1 Main = new Form1();

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main.PanelStatsMain.BringToFront();
        }
        void LoadTipoUser()
        {
            CmbTipoUser.DataSource = LoadDataUser.LoadTipoUsers();
            CmbTipoUser.DisplayMember = ("tipo_Usuario");
            CmbTipoUser.ValueMember = ("ID_tipoUsuario");
        }
        void LoadEstadoUser()
        {
            CmbEstadoUser.DataSource = LoadDataUser.LoadEstadoUser();
            CmbEstadoUser.DisplayMember = ("estado_usuario");
            CmbEstadoUser.ValueMember = ("ID_estadoUsuario");
        }

        void CleanData() 
        {
            Txt_Nombre.ResetText();
            Txt_Apellido.ResetText();
            Txt_Usuario.ResetText();
            Txt_Documento.ResetText();
            Txt_password.ResetText();
            Txt_edad.ResetText();
            Txt_telefono.ResetText();
            Txt_celular.ResetText();
            Txt_licencia.ResetText();
        }

        void LoadUser() 
        {
            dataGridView.DataSource = ShowData.ShowData();
        }

        void InsertData()
        {
            if (Txt_Nombre.Text == "" || Txt_Apellido.Text == "" || Txt_Usuario.Text == "" || Txt_password.Text == "" || Txt_telefono.Text == "" || Txt_celular.Text == "" || Txt_Documento.Text == "" || Txt_edad.Text == "" || Txt_licencia.Text == "")
            {
                MessageBox.Show("Todos los campos deben estar llenos", "CAMPOS VACÍOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DateTime fecha = DateTimePicker.Value;
                string DateFormat = fecha.ToString("yyyy-MM-dd");
                Insert_User.Nombre = Txt_Nombre.Text;
                Insert_User.Apellido = Txt_Apellido.Text;
                Insert_User.Documento = Txt_Documento.Text;
                Insert_User.Password = Txt_password.Text;
                Insert_User.Edad = Convert.ToInt32(Txt_edad.Text);
                Insert_User.Telefono = Txt_telefono.Text;
                Insert_User.Celular = Txt_celular.Text;
                Insert_User.Licencia = Txt_licencia.Text;
                Insert_User.Fecha = DateFormat;
                Insert_User.EstadoUsuario = Convert.ToInt32(CmbEstadoUser.SelectedValue);
                Insert_User.TipoUsuario = Convert.ToInt32(CmbTipoUser.SelectedValue);
                Insert_User.Usuario = Txt_Usuario.Text;
                int response = Insert_User.Add_Data();
                if (response > 0)
                {
                    MessageBox.Show("El usuario fue agregado correctamente", "Redirigiendo a Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUser();
                }
                else
                {
                    MessageBox.Show("Algo fallo", "Revisa el codigo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            LoadUser();
            LoadTipoUser();
            LoadEstadoUser();
            Txt_telefono.MaxLength = 12;
            Txt_celular.MaxLength = 12;
            Txt_Documento.MaxLength = 10;
            Txt_licencia.MaxLength = 10;
            Txt_edad.MaxLength = 2;
        }

        private void Register_User_Click(object sender, EventArgs e)
        {
            InsertData();
            CleanData();
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No disponible por el momento", "HABILITADO PRÓXIMAMENTE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No disponible por el momento", "HABILITADO PRÓXIMAMENTE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
