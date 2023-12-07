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
using System.Net;
using System.Net.Mail;

namespace Vista
{
    public partial class RestorePassword : Form
    {
        public RestorePassword()
        {
            InitializeComponent();
        }
        // Correo: carincomes@gmail.com
        // Contraseña: CarIncomersDotNet

        // Guardaremos el código que se génere en una variable global con un nivel de acceso de solo lectura:
        string RandomCode;
        public static string to;

        // Instancia de acceso para el controlador de contraseñas
        readonly Controller_Restore_Password RestoreProcess = new Controller_Restore_Password();

        // Método para generar el código de acceso aleatorio
        void Code() 
        {
            string From, Pass, MessageBody;
            Random rand = new Random();
            RandomCode = (rand.Next(999999)).ToString();

            // Enviamos el manesaje con el correo de la empresa
            MailMessage Message = new MailMessage();
            to = (Txt_Buscar.Text).ToString();
            From = "carincomes@gmail.com";
            Pass = "nkeh jmex gumu jfkt";
            MessageBody = "This is your reset code: " + RandomCode + "\t this code expires is 5 hours.";
            Message.To.Add(to);
            Message.From = new MailAddress(From);
            Message.Body = MessageBody;
            Message.Subject = "Password reseting code generate from App.";

            // Es necesario tener libre el puerto de comunicación 587
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(From, Pass);
            try
            {
                smtp.Send(Message);
                MessageBox.Show("Se ha enviado un token de verificación a tu correo Electrónico :) ", "TOKEN GENERADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No ha sido posible generar el Token {ex.Message}", "TOKEN NO GENERADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login OpenLogin = new Login();
            OpenLogin.Show();
        }

        void VerifyEmail() 
        {
            string email = Txt_Buscar.Text;
            RestoreProcess.Correo = Txt_Buscar.Text;

            bool response = RestoreProcess.GetEmail(email);
            if (response)
            {                
                Txt_Pin.Enabled = true;
                BtnVerificar.Enabled = true;
                Btn_Buscar.Enabled = false;
                Code();
            }
            else 
            {
                MessageBox.Show("No se ha registrado este correo electrónico.", "Correo no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            VerifyEmail();
        }

        private void RestorePassword_Load(object sender, EventArgs e)
        {
            Txt_Pin.Enabled = false;
            BtnVerificar.Enabled = false;
        }

        private void BtnVerificar_Click(object sender, EventArgs e)
        {
            if (RandomCode == (Txt_Pin.Text))
            {
                MessageBox.Show("Verificación completada, puedes cambiar tu contraseña.", "VERIFICACIÓN EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ChangePassword change = new ChangePassword();
                this.Hide();
                change.Show();
                to = Txt_Buscar.Text;
            }
            else 
            {
                MessageBox.Show("Verifica tú código de acceso.", "VERIFICACIÓN FALLIDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
