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
    public partial class Primer_registro : Form
    {
        public Primer_registro()
        {
            InitializeComponent();
        }

        // Instancia de Acceso para llenar los ComboBox
        readonly Data_Controller LoadUser = new Data_Controller();
        // Instancia para Acceso de datos para al momento de Insertar los datos
        readonly Controller_Usuario Insert_User = new Controller_Usuario();

        void LoadTipoUser ()
        {
            CmbTipoUser.DataSource = LoadUser.LoadTipoUsers();
            CmbTipoUser.DisplayMember = ("tipo_Usuario");
            CmbTipoUser.ValueMember = ("ID_tipoUsuario");
        }
        void LoadEstadoUser ()
        {
            CmbEstadoUser.DataSource = LoadUser.LoadEstadoUser();
            CmbEstadoUser.DisplayMember = ("estado_usuario");
            CmbEstadoUser.ValueMember = ("ID_estadoUsuario");
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
                Insert_User.Usuario = Txt_Usuario.Text;
                Insert_User.Documento = Txt_Documento.Text;
                Insert_User.Password = Txt_password.Text;
                Insert_User.Edad = Convert.ToInt32(Txt_edad.Text);
                Insert_User.Telefono = Txt_telefono.Text;
                Insert_User.Celular = Txt_celular.Text;
                Insert_User.Licencia = Txt_licencia.Text;
                Insert_User.Fecha = DateFormat;
                Insert_User.TipoUsuario = Convert.ToInt32(CmbTipoUser.SelectedValue);
                Insert_User.EstadoUsuario = Convert.ToInt32(CmbEstadoUser.SelectedValue);
                int response = Insert_User.Add_Data();
                if (response > 0)
                {
                    MessageBox.Show("Primer usuario fue agregado correctamente", "Redirigiendo a Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Login StartSession = new Login();
                    this.Hide();
                    StartSession.Show();
                }
                else 
                {
                    MessageBox.Show("Algo fallo", "Revisa el codigo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Register_User_Click(object sender, EventArgs e)
        {
            InsertData();
        }

        private void Primer_registro_Load(object sender, EventArgs e)
        {
            LoadTipoUser();
            LoadEstadoUser();

            // Límite de carácteres en los campos
            Txt_Documento.MaxLength = 9;
            Txt_telefono.MaxLength = 8;
            Txt_celular.MaxLength = 8;
            Txt_edad.MaxLength = 2;
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Validaciones de los campos
        private void Nombre(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar <= 91 && e.KeyChar >= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Se detéctaron caáretes no válidos \n Los carácteres especiales no son permitidos", "CARÁCTERES NO VÁLIDOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void Apellido(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar <= 91 && e.KeyChar >= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Se detéctaron caáretes no válidos \n Los carácteres especiales no son permitidos", "CARÁCTERES NO VÁLIDOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void Usuario(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar <= 07 && e.KeyChar >= 09) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Se detéctaron caáretes no válidos \n Los carácteres especiales no son permitidos", "CARÁCTERES NO VÁLIDOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void Documento(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                MessageBox.Show("Se detéctaron caáretes no válidos \n Letras no son permitidas para este campo", "CARÁCTERES NO VÁLIDOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void Password(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar <= 07 && e.KeyChar >= 09) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Se detéctaron caáretes no válidos \n Los carácteres especiales no son permitidos", "CARÁCTERES NO VÁLIDOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void Telefono(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                MessageBox.Show("Se detéctaron caáretes no válidos \n Letras no son permitidas para este campo", "CARÁCTERES NO VÁLIDOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void Celular(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                MessageBox.Show("Se detéctaron caáretes no válidos \n Letras no son permitidas para este campo", "CARÁCTERES NO VÁLIDOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void Licencia(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                MessageBox.Show("Se detéctaron caáretes no válidos \n Letras no son permitidas para este campo", "CARÁCTERES NO VÁLIDOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void Edad(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                MessageBox.Show("Se detéctaron caáretes no válidos \n Letras no son permitidas para este campo", "CARÁCTERES NO VÁLIDOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }
    }
}
