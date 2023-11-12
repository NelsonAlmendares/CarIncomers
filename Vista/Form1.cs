using Common.cache;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using Controller;

namespace Vista
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void User_Rol()
        {
            // Controlamos las acciones que se pueden realizar por cada usuario

            if (UserLoginCache.TipoUsuario == "Root")
            {
                // Todos los permisos para controlar el sistema
            }
            else if (UserLoginCache.TipoUsuario == "Administrador")
            {
                Btn_Vehiculo.Visible = false;
            }
            else if (UserLoginCache.TipoUsuario == "Cliente")
            {
                Btn_registroUsuario.Visible = false;
                Btn_registroVehiculo.Visible = false;
                Btn_Facturacion.Visible = false;
                Btn_Contactos.Visible = false;
                Btn_Reingreso.Visible = false;
            }
        }


        private void SaludarSegunHora()
        {
            // Obtener la hora actual
            DateTime horaActual = DateTime.Now;
            int hora = horaActual.Hour;

            // Mostrar mensaje según la hora del día
            if (hora >= 6 && hora < 12)
            {
                Lbl_Saludo.Text = "Buenos días!";
            }
            else if (hora >= 12 && hora < 18)
            {
                Lbl_Saludo.Text = "¡Buenas tardes!";
            }
            else
            {
                Lbl_Saludo.Text = "¡Buenas noches!";
            }
        }

        // Método para cargar los gráficos del Dashboard:
        void LoadCharts() 
        {
            // Conexión de datos
            SqlConnection GetConnect = Controller_Conexion.ConnectModel();
            string Query = "SELECT COUNT(ID_usuario) AS Registrados, CONVERT(varchar, Fecha_Registro,9) as Fecha FROM [dbo].[Usuario] GROUP BY Fecha_Registro;";

            SqlCommand command = new SqlCommand(Query, GetConnect);
            SqlDataAdapter ADP = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            ADP.Fill(dataTable);

            // Creamos los datos del gráfico
            SeriesCollection series = new SeriesCollection();
            ColumnSeries columnSeries = new ColumnSeries
            {
                Title = "Registros",
                Values = new ChartValues<int>(dataTable.AsEnumerable().Select(row => Convert.ToInt32(row["Registrados"]))
                ),
                DataLabels = true
            };

            Axis axisX = new Axis
            { 
                Title = "Fechas de registro",
                Labels = dataTable.AsEnumerable().Select(row => row["Fecha"].ToString()).ToList()
            };

            cartesianChart1.Series = new SeriesCollection { columnSeries };
            cartesianChart1.AxisX.Add(axisX);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            User_Rol();
            LblNombre.Text = UserLoginCache.Nombre + ".";
            LblRol.Text = UserLoginCache.TipoUsuario.ToString();
            LoadCharts();
            SaludarSegunHora();
        }

        private void Btn_Solicitud_Click(object sender, EventArgs e)
        {
            Solicitudes Add_Solicitud = new Solicitudes();
            Add_Solicitud.TopLevel = false;
            MainPanel.Controls.Add(Add_Solicitud);
            Add_Solicitud.Dock = DockStyle.Fill;
            Add_Solicitud.Show();
            PanelStatsMain.SendToBack();
        }

        private void Btn_Contactos_Click(object sender, EventArgs e)
        {
            Contactos Add_Contact = new Contactos();
            Add_Contact.TopLevel = false;
            MainPanel.Controls.Add(Add_Contact);
            Add_Contact.Dock = DockStyle.Fill;
            Add_Contact.Show();
            PanelStatsMain.SendToBack();
        }

        private void Btn_registroVehiculo_Click(object sender, EventArgs e)
        {
            Registro_Vehiculos Add_Vehiculo = new Registro_Vehiculos();
            Add_Vehiculo.TopLevel = false;
            MainPanel.Controls.Add(Add_Vehiculo);
            Add_Vehiculo.Dock = DockStyle.Fill;
            Add_Vehiculo.Show();
            PanelStatsMain.SendToBack();
        }

        private void Btn_registroUsuario_Click(object sender, EventArgs e)
        {
            Usuarios Add_User = new Usuarios();
            Add_User.TopLevel = false;
            MainPanel.Controls.Add(Add_User);
            Add_User.Dock = DockStyle.Fill;
            Add_User.Show();
            PanelStatsMain.SendToBack();
        }

        private void Btn_Vehiculo_Click(object sender, EventArgs e)
        {
            Vehiculos Add_Vehiculo = new Vehiculos();
            Add_Vehiculo.TopLevel = false;
            MainPanel.Controls.Add(Add_Vehiculo);
            Add_Vehiculo.Dock = DockStyle.Fill;
            Add_Vehiculo.Show();
            PanelStatsMain.SendToBack();
        }

        private void Btn_Facturacion_Click(object sender, EventArgs e)
        {
            Facturacion Add_Factura = new Facturacion();
            Add_Factura.TopLevel = false;
            MainPanel.Controls.Add(Add_Factura);
            Add_Factura.Dock = DockStyle.Fill;
            Add_Factura.Show();
            PanelStatsMain.SendToBack();
        }
        private void Btn_Reingreso_Click(object sender, EventArgs e)
        {
            Reingreso Add_Reingreso = new Reingreso();
            Add_Reingreso.TopLevel = false;
            MainPanel.Controls.Add(Add_Reingreso);
            Add_Reingreso.Dock = DockStyle.Fill;
            Add_Reingreso.Show();
            PanelStatsMain.SendToBack();
        }

        private void BtnSession_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir del Sistema?", "TERMINAR SESIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login BackSession = new Login();
                this.Hide();
                BackSession.Show();
            }
            else 
            {
                MessageBox.Show("Continúe con la sesión actual", "Car Income System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
