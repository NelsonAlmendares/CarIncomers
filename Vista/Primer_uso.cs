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
    public partial class Primer_uso : Form
    {
        public Primer_uso()
        {
            InitializeComponent();
        }

        private void Primer_uso_Load(object sender, EventArgs e)
        {
            Timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (gunaProgressBar1.Value < 100)
            {
                gunaProgressBar1.Value += 1;
                LabelLoader.Text = gunaProgressBar1.Value.ToString() + "%";
                Btn_Login.Enabled = false;
            }
            else 
            {
                Timer.Stop();
                Controller_PrimerUso CheckUser = new Controller_PrimerUso();
                int response = CheckUser.VerifyUser();

                if (response != 0)
                {
                    MessageBox.Show("Sesión creada correctamente \n Continúa con tus tareas", "REDIRECCIONANDO A PRIMER LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Btn_Login.Enabled = true;
                }
                else 
                {
                    MessageBox.Show("No existen usuarios registrados en la base de datos \n Crea el usuario administrador!", "REDIRECCIONANDO A PRIMER REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Primer_registro New_User = new Primer_registro();
                    this.Hide();
                    New_User.Show();
                }
            }
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            Login OpenLogin = new Login();
            this.Hide();
            OpenLogin.Show();
        }
    }
}
