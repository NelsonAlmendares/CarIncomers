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
    public partial class Contactos : Form
    {
        public Contactos()
        {
            InitializeComponent();
        }

        // Acceso al form principal
        Form1 Main = new Form1();
        // Instancia para llenar los datos de el ComboBox
        readonly Data_Controller FillUser = new Data_Controller();
        // Instancia insertar los datos que se capturens
        readonly Controller_Contactos InsertContact = new Controller_Contactos();
        // Instancia insertar los datos que se capturens
        readonly Controller_Contactos ShowContact = new Controller_Contactos();


        void FillData()
        {
            CmbUser.DataSource = FillUser.LoadUser();
            CmbUser.DisplayMember = ("Usuario");
            CmbUser.ValueMember = ("ID_usuario");
        }

        void ShowData ()
        {
            dataGridView.DataSource = ShowContact.ShowContacts();
        }

        void CleanData() 
        {
            Txt_Nombre.ResetText();
            Txt_Apellido.ResetText();
            Txt_telefono.ResetText();
            Txt_Email.ResetText();
        }

        void InsertData() 
        {
            if (Txt_Nombre.Text == "" && Txt_Apellido.Text == "" && Txt_telefono.Text == "" && Txt_Email.Text == "")
            {
                MessageBox.Show("Campos vacíos", "Por favor llena todos los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                InsertContact.ID_usuario = Convert.ToInt32(CmbUser.SelectedValue);
                InsertContact.Nombre = Txt_Nombre.Text;
                InsertContact.Apellido = Txt_Apellido.Text;
                InsertContact.Celular = Txt_telefono.Text;
                InsertContact.Email = Txt_Email.Text;
                bool response = InsertContact.InsertDataContact();
                if (response == true)
                {
                    MessageBox.Show("Los datos fueron agregados correctamente", "DATOS INSERTADOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowData();
                    CleanData();
                } 
                else 
                {
                    MessageBox.Show("Los datos NO pudieron ser agregados", "DATOS DENEGADOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main.PanelStatsMain.BringToFront();
        }

        private void Contactos_Load(object sender, EventArgs e)
        {
            FillData();
            ShowData();
        }

        private void Register_User_Click(object sender, EventArgs e)
        {
            InsertData();
        }

        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
