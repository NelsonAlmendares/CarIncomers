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
using System.IO;

namespace Vista
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        // Instancia para mandar los datos que se toman del form y que vienen desde el form anterior
        readonly Controller_ChangePassword ChangePass = new Controller_ChangePassword();

        void VerifyPasswords() 
        {

            string UserEmail = RestorePassword.to;
            string Pass = Txt_Pass.Text;

            // Mandamos los datos:
            ChangePass.Email = UserEmail.ToString();
            ChangePass.Password = Txt_Pass.Text;            

            if (Txt_Pass.Text == "" || Txt_ConfPass.Text == "")
            {
                MessageBox.Show("Asegurate de llenar ambos campos del formulario!", "CAMPOS VACÍOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
            {
                if (Txt_Pass.Text != Txt_ConfPass.Text)
                {
                    MessageBox.Show("Las contraeñas no coinciden!", "CONTRASEÑAS DIFERENTES", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bool reponse = ChangePass.ChangePassword(UserEmail, Pass);
                    if (reponse == true)
                    {
                        MessageBox.Show("Cambio de contraseña realizado exitosamente!", "CAMBIO REALIZADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Login OpenLogin = new Login();
                        this.Hide();
                        OpenLogin.Show();
                        this.notifyIcon1.ShowBalloonTip(500, "Equipo de Seguridad Car Incomes", "Cambio de contraseña realizado, puedes iniciar sesión nuevamente", ToolTipIcon.Info);
                    }
                    else
                    {
                        MessageBox.Show("Cambio de contraseña no pudo ser realizado!", "CAMBIO FALLIDO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }            
        }

        private void Btn_Cambiar_Click(object sender, EventArgs e)
        {
            VerifyPasswords();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
