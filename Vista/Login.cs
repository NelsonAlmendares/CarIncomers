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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        // Instancia de acceso para a los constructores
        readonly Controller_Login InitSession = new Controller_Login();

        // Si el login se realiza con éxito abrimos el formulario principal
        readonly Form1 Dashboard = new Form1();

        void StartSession() 
        {           
            if (Txt_User.Text == "" && Txt_password.Text == "")
            {
                MessageBox.Show("Llene todos los cambios para ingresar al sistema", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Txt_User.Text == "")
            {
                MessageBox.Show("Llene el campo de Usuario para ingresar al sistema", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Txt_password.Text == "")
            {
                MessageBox.Show("Llene el campo de Contraseña para ingresar al sistema", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Llamamos a los textbox correspondientes:
                string User = Txt_User.Text;
                string Pwd = Txt_password.Text;

                InitSession.User = Txt_User.Text;
                InitSession.Pwd = Txt_password.Text;
                bool respone = InitSession.VerifyData(User, Pwd);

                if (respone == true)
                {
                    MessageBox.Show("Acceso conseguido! Bienvenido al sistema.", "LOGIN COMPROBADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.notifyIcon1.ShowBalloonTip(500, "Car Incomes S.A de C.V", "Nuevo inicio de sesión. \t Bienvenido al sistema", ToolTipIcon.Info);
                    this.Hide();
                    Dashboard.Show();                    
                    // CleanData();
                }
                else
                {
                    MessageBox.Show("Credenciales no válidas, vuelva a intentarlo.", "LOGIN FALLIDO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            StartSession();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LinkPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RestorePassword NewPassword = new RestorePassword();
            NewPassword.Show();
        }
        private void Login_KeyPress(object sender, KeyPressEventArgs e) { /*  Sin Uso :/  */  }

        private void Txt_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) 
            {
                StartSession();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
