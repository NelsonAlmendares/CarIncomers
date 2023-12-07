using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.cache;

namespace Vista
{
    public partial class Perfil : Form
    {
        public Perfil()
        {
            InitializeComponent();
        }

        // Acceso al form principal
        readonly Form1 Main = new Form1();

        private void Perfil_Load(object sender, EventArgs e)
        {
            ColorTipoUser();
            LoadData();
        }

        void ColorTipoUser() 
        {
            if (UserLoginCache.TipoUsuario == "Root")
            {
                LblTipo.ForeColor = Color.Green;
            }
        }

        void LoadData() 
        {
            // LblRol.Text = UserLoginCache.TipoUsuario.ToString();
            LblUser.Text = UserLoginCache.Usuario.ToString();
            LblNombre.Text = UserLoginCache.Nombre.ToString();
            LblTipo.Text = UserLoginCache.TipoUsuario.ToString();
            LblEstado.Text = UserLoginCache.EstadoUsuario.ToString();
            LblCel.Text = UserLoginCache.Celular.ToString();
            LblTel.Text = UserLoginCache.Telefono.ToString();
            LblEmail.Text = UserLoginCache.Correo.ToString();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main.PanelStatsMain.BringToFront();
        }
    }
}
