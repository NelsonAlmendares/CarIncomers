
namespace Vista
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnSession = new Guna.UI.WinForms.GunaButton();
            this.Btn_Reingreso = new Guna.UI.WinForms.GunaButton();
            this.Btn_Contactos = new Guna.UI.WinForms.GunaButton();
            this.LblRol = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.Btn_registroVehiculo = new Guna.UI.WinForms.GunaButton();
            this.Btn_Facturacion = new Guna.UI.WinForms.GunaButton();
            this.Btn_Vehiculo = new Guna.UI.WinForms.GunaButton();
            this.Btn_Solicitud = new Guna.UI.WinForms.GunaButton();
            this.Btn_registroUsuario = new Guna.UI.WinForms.GunaButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.PanelStatsMain = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.cartesianChart1 = new LiveCharts.Wpf.CartesianChart();
            this.gunaElipsePanel2 = new Guna.UI.WinForms.GunaElipsePanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Lbl_Saludo = new System.Windows.Forms.Label();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.gunaElipsePanel3 = new Guna.UI.WinForms.GunaElipsePanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.PanelStatsMain.SuspendLayout();
            this.gunaElipsePanel2.SuspendLayout();
            this.gunaElipsePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.gunaElipsePanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Btn_Exit);
            this.panel1.Location = new System.Drawing.Point(1483, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(132, 40);
            this.panel1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Image = global::Vista.Properties.Resources.minimizar_signo1;
            this.button2.Location = new System.Drawing.Point(12, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 40);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = global::Vista.Properties.Resources.maximizar1;
            this.button1.Location = new System.Drawing.Point(52, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(51)))), ((int)(((byte)(52)))));
            this.Btn_Exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Exit.FlatAppearance.BorderSize = 0;
            this.Btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Exit.Image = global::Vista.Properties.Resources.close;
            this.Btn_Exit.Location = new System.Drawing.Point(92, 0);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(40, 40);
            this.Btn_Exit.TabIndex = 1;
            this.Btn_Exit.UseVisualStyleBackColor = false;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnSession);
            this.panel2.Controls.Add(this.Btn_Reingreso);
            this.panel2.Controls.Add(this.Btn_Contactos);
            this.panel2.Controls.Add(this.LblRol);
            this.panel2.Controls.Add(this.LblNombre);
            this.panel2.Controls.Add(this.Btn_registroVehiculo);
            this.panel2.Controls.Add(this.Btn_Facturacion);
            this.panel2.Controls.Add(this.Btn_Vehiculo);
            this.panel2.Controls.Add(this.Btn_Solicitud);
            this.panel2.Controls.Add(this.Btn_registroUsuario);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(264, 924);
            this.panel2.TabIndex = 3;
            // 
            // BtnSession
            // 
            this.BtnSession.AnimationHoverSpeed = 0.07F;
            this.BtnSession.AnimationSpeed = 0.03F;
            this.BtnSession.BackColor = System.Drawing.Color.Transparent;
            this.BtnSession.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.BtnSession.BorderColor = System.Drawing.Color.Black;
            this.BtnSession.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnSession.FocusedColor = System.Drawing.Color.Empty;
            this.BtnSession.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSession.ForeColor = System.Drawing.Color.White;
            this.BtnSession.Image = global::Vista.Properties.Resources.cerrar_sesion;
            this.BtnSession.ImageSize = new System.Drawing.Size(24, 24);
            this.BtnSession.Location = new System.Drawing.Point(33, 846);
            this.BtnSession.Name = "BtnSession";
            this.BtnSession.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BtnSession.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BtnSession.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnSession.OnHoverImage = null;
            this.BtnSession.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.BtnSession.Size = new System.Drawing.Size(203, 50);
            this.BtnSession.TabIndex = 24;
            this.BtnSession.Text = "Cerrar Sesión";
            this.BtnSession.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnSession.Click += new System.EventHandler(this.BtnSession_Click);
            // 
            // Btn_Reingreso
            // 
            this.Btn_Reingreso.AnimationHoverSpeed = 0.07F;
            this.Btn_Reingreso.AnimationSpeed = 0.03F;
            this.Btn_Reingreso.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Reingreso.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Btn_Reingreso.BorderColor = System.Drawing.Color.Black;
            this.Btn_Reingreso.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Btn_Reingreso.FocusedColor = System.Drawing.Color.Empty;
            this.Btn_Reingreso.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Reingreso.ForeColor = System.Drawing.Color.White;
            this.Btn_Reingreso.Image = global::Vista.Properties.Resources.Payment1;
            this.Btn_Reingreso.ImageSize = new System.Drawing.Size(20, 20);
            this.Btn_Reingreso.Location = new System.Drawing.Point(12, 495);
            this.Btn_Reingreso.Name = "Btn_Reingreso";
            this.Btn_Reingreso.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Btn_Reingreso.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Btn_Reingreso.OnHoverForeColor = System.Drawing.Color.White;
            this.Btn_Reingreso.OnHoverImage = null;
            this.Btn_Reingreso.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.Btn_Reingreso.Size = new System.Drawing.Size(239, 50);
            this.Btn_Reingreso.TabIndex = 23;
            this.Btn_Reingreso.Text = "Reingreso";
            this.Btn_Reingreso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Btn_Reingreso.Click += new System.EventHandler(this.Btn_Reingreso_Click);
            // 
            // Btn_Contactos
            // 
            this.Btn_Contactos.AnimationHoverSpeed = 0.07F;
            this.Btn_Contactos.AnimationSpeed = 0.03F;
            this.Btn_Contactos.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Contactos.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Btn_Contactos.BorderColor = System.Drawing.Color.Black;
            this.Btn_Contactos.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Btn_Contactos.FocusedColor = System.Drawing.Color.Empty;
            this.Btn_Contactos.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Contactos.ForeColor = System.Drawing.Color.White;
            this.Btn_Contactos.Image = global::Vista.Properties.Resources.User;
            this.Btn_Contactos.ImageSize = new System.Drawing.Size(20, 20);
            this.Btn_Contactos.Location = new System.Drawing.Point(12, 383);
            this.Btn_Contactos.Name = "Btn_Contactos";
            this.Btn_Contactos.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Btn_Contactos.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Btn_Contactos.OnHoverForeColor = System.Drawing.Color.White;
            this.Btn_Contactos.OnHoverImage = null;
            this.Btn_Contactos.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.Btn_Contactos.Size = new System.Drawing.Size(239, 50);
            this.Btn_Contactos.TabIndex = 22;
            this.Btn_Contactos.Text = "Contactos";
            this.Btn_Contactos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Btn_Contactos.Click += new System.EventHandler(this.Btn_Contactos_Click);
            // 
            // LblRol
            // 
            this.LblRol.AutoSize = true;
            this.LblRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.LblRol.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRol.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LblRol.Location = new System.Drawing.Point(30, 790);
            this.LblRol.Name = "LblRol";
            this.LblRol.Size = new System.Drawing.Size(68, 18);
            this.LblRol.TabIndex = 21;
            this.LblRol.Text = "User Rol";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.LblNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LblNombre.Location = new System.Drawing.Point(29, 767);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(93, 19);
            this.LblNombre.TabIndex = 20;
            this.LblNombre.Text = "User Name";
            // 
            // Btn_registroVehiculo
            // 
            this.Btn_registroVehiculo.AnimationHoverSpeed = 0.07F;
            this.Btn_registroVehiculo.AnimationSpeed = 0.03F;
            this.Btn_registroVehiculo.BackColor = System.Drawing.Color.Transparent;
            this.Btn_registroVehiculo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Btn_registroVehiculo.BorderColor = System.Drawing.Color.Black;
            this.Btn_registroVehiculo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Btn_registroVehiculo.FocusedColor = System.Drawing.Color.Empty;
            this.Btn_registroVehiculo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_registroVehiculo.ForeColor = System.Drawing.Color.White;
            this.Btn_registroVehiculo.Image = global::Vista.Properties.Resources.Icon1;
            this.Btn_registroVehiculo.ImageSize = new System.Drawing.Size(20, 20);
            this.Btn_registroVehiculo.Location = new System.Drawing.Point(12, 271);
            this.Btn_registroVehiculo.Name = "Btn_registroVehiculo";
            this.Btn_registroVehiculo.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Btn_registroVehiculo.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Btn_registroVehiculo.OnHoverForeColor = System.Drawing.Color.White;
            this.Btn_registroVehiculo.OnHoverImage = null;
            this.Btn_registroVehiculo.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.Btn_registroVehiculo.Size = new System.Drawing.Size(239, 50);
            this.Btn_registroVehiculo.TabIndex = 19;
            this.Btn_registroVehiculo.Text = "Registro de Vehiculos";
            this.Btn_registroVehiculo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Btn_registroVehiculo.Click += new System.EventHandler(this.Btn_registroVehiculo_Click);
            // 
            // Btn_Facturacion
            // 
            this.Btn_Facturacion.AnimationHoverSpeed = 0.07F;
            this.Btn_Facturacion.AnimationSpeed = 0.03F;
            this.Btn_Facturacion.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Facturacion.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Btn_Facturacion.BorderColor = System.Drawing.Color.Black;
            this.Btn_Facturacion.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Btn_Facturacion.FocusedColor = System.Drawing.Color.Empty;
            this.Btn_Facturacion.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Facturacion.ForeColor = System.Drawing.Color.White;
            this.Btn_Facturacion.Image = global::Vista.Properties.Resources.Payment1;
            this.Btn_Facturacion.ImageSize = new System.Drawing.Size(20, 20);
            this.Btn_Facturacion.Location = new System.Drawing.Point(12, 439);
            this.Btn_Facturacion.Name = "Btn_Facturacion";
            this.Btn_Facturacion.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Btn_Facturacion.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Btn_Facturacion.OnHoverForeColor = System.Drawing.Color.White;
            this.Btn_Facturacion.OnHoverImage = null;
            this.Btn_Facturacion.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.Btn_Facturacion.Size = new System.Drawing.Size(239, 50);
            this.Btn_Facturacion.TabIndex = 18;
            this.Btn_Facturacion.Text = "Facturación";
            this.Btn_Facturacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Btn_Facturacion.Click += new System.EventHandler(this.Btn_Facturacion_Click);
            // 
            // Btn_Vehiculo
            // 
            this.Btn_Vehiculo.AnimationHoverSpeed = 0.07F;
            this.Btn_Vehiculo.AnimationSpeed = 0.03F;
            this.Btn_Vehiculo.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Vehiculo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Btn_Vehiculo.BorderColor = System.Drawing.Color.Black;
            this.Btn_Vehiculo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Btn_Vehiculo.FocusedColor = System.Drawing.Color.Empty;
            this.Btn_Vehiculo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Vehiculo.ForeColor = System.Drawing.Color.White;
            this.Btn_Vehiculo.Image = global::Vista.Properties.Resources.List1;
            this.Btn_Vehiculo.ImageSize = new System.Drawing.Size(20, 20);
            this.Btn_Vehiculo.Location = new System.Drawing.Point(12, 215);
            this.Btn_Vehiculo.Name = "Btn_Vehiculo";
            this.Btn_Vehiculo.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Btn_Vehiculo.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Btn_Vehiculo.OnHoverForeColor = System.Drawing.Color.White;
            this.Btn_Vehiculo.OnHoverImage = null;
            this.Btn_Vehiculo.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.Btn_Vehiculo.Size = new System.Drawing.Size(239, 50);
            this.Btn_Vehiculo.TabIndex = 17;
            this.Btn_Vehiculo.Text = "Mis vehículos";
            this.Btn_Vehiculo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Btn_Vehiculo.Click += new System.EventHandler(this.Btn_Vehiculo_Click);
            // 
            // Btn_Solicitud
            // 
            this.Btn_Solicitud.AnimationHoverSpeed = 0.07F;
            this.Btn_Solicitud.AnimationSpeed = 0.03F;
            this.Btn_Solicitud.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Solicitud.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Btn_Solicitud.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Btn_Solicitud.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Btn_Solicitud.FocusedColor = System.Drawing.Color.Empty;
            this.Btn_Solicitud.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Solicitud.ForeColor = System.Drawing.Color.White;
            this.Btn_Solicitud.Image = global::Vista.Properties.Resources.Calendar1;
            this.Btn_Solicitud.ImageSize = new System.Drawing.Size(20, 20);
            this.Btn_Solicitud.Location = new System.Drawing.Point(12, 159);
            this.Btn_Solicitud.Name = "Btn_Solicitud";
            this.Btn_Solicitud.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Btn_Solicitud.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Btn_Solicitud.OnHoverForeColor = System.Drawing.Color.White;
            this.Btn_Solicitud.OnHoverImage = null;
            this.Btn_Solicitud.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.Btn_Solicitud.Size = new System.Drawing.Size(239, 50);
            this.Btn_Solicitud.TabIndex = 16;
            this.Btn_Solicitud.Text = "Registrar una solicitud";
            this.Btn_Solicitud.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Btn_Solicitud.Click += new System.EventHandler(this.Btn_Solicitud_Click);
            // 
            // Btn_registroUsuario
            // 
            this.Btn_registroUsuario.AnimationHoverSpeed = 0.07F;
            this.Btn_registroUsuario.AnimationSpeed = 0.03F;
            this.Btn_registroUsuario.BackColor = System.Drawing.Color.Transparent;
            this.Btn_registroUsuario.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Btn_registroUsuario.BorderColor = System.Drawing.Color.Black;
            this.Btn_registroUsuario.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Btn_registroUsuario.FocusedColor = System.Drawing.Color.Empty;
            this.Btn_registroUsuario.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_registroUsuario.ForeColor = System.Drawing.Color.White;
            this.Btn_registroUsuario.Image = global::Vista.Properties.Resources.User;
            this.Btn_registroUsuario.ImageSize = new System.Drawing.Size(20, 20);
            this.Btn_registroUsuario.Location = new System.Drawing.Point(12, 327);
            this.Btn_registroUsuario.Name = "Btn_registroUsuario";
            this.Btn_registroUsuario.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Btn_registroUsuario.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Btn_registroUsuario.OnHoverForeColor = System.Drawing.Color.White;
            this.Btn_registroUsuario.OnHoverImage = null;
            this.Btn_registroUsuario.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.Btn_registroUsuario.Size = new System.Drawing.Size(239, 50);
            this.Btn_registroUsuario.TabIndex = 15;
            this.Btn_registroUsuario.Text = "Registro de Usuarios";
            this.Btn_registroUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Btn_registroUsuario.Click += new System.EventHandler(this.Btn_registroUsuario_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Vista.Properties.Resources.NewLogo;
            this.pictureBox3.Location = new System.Drawing.Point(12, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(239, 110);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Vista.Properties.Resources.Background;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 924);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.label3.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.label3.Location = new System.Drawing.Point(10, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 34);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dashboard";
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.gunaTextBox1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.gunaTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.gunaTextBox1.Location = new System.Drawing.Point(309, 19);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.SelectedText = "";
            this.gunaTextBox1.Size = new System.Drawing.Size(473, 37);
            this.gunaTextBox1.TabIndex = 7;
            this.gunaTextBox1.Text = "Search";
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Transparent;
            this.MainPanel.Controls.Add(this.PanelStatsMain);
            this.MainPanel.Location = new System.Drawing.Point(281, 72);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1325, 840);
            this.MainPanel.TabIndex = 15;
            // 
            // PanelStatsMain
            // 
            this.PanelStatsMain.Controls.Add(this.label1);
            this.PanelStatsMain.Controls.Add(this.elementHost1);
            this.PanelStatsMain.Controls.Add(this.gunaElipsePanel2);
            this.PanelStatsMain.Controls.Add(this.gunaElipsePanel1);
            this.PanelStatsMain.Controls.Add(this.label3);
            this.PanelStatsMain.Location = new System.Drawing.Point(12, 1);
            this.PanelStatsMain.Name = "PanelStatsMain";
            this.PanelStatsMain.Size = new System.Drawing.Size(1313, 834);
            this.PanelStatsMain.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.label1.Location = new System.Drawing.Point(25, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Cantidad de registros de usuarios por mes:";
            // 
            // elementHost1
            // 
            this.elementHost1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.elementHost1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.elementHost1.Location = new System.Drawing.Point(16, 299);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(525, 262);
            this.elementHost1.TabIndex = 18;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.cartesianChart1;
            // 
            // gunaElipsePanel2
            // 
            this.gunaElipsePanel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.gunaElipsePanel2.Controls.Add(this.label2);
            this.gunaElipsePanel2.Controls.Add(this.label4);
            this.gunaElipsePanel2.Controls.Add(this.Lbl_Saludo);
            this.gunaElipsePanel2.Location = new System.Drawing.Point(16, 71);
            this.gunaElipsePanel2.Name = "gunaElipsePanel2";
            this.gunaElipsePanel2.Size = new System.Drawing.Size(992, 158);
            this.gunaElipsePanel2.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.label2.Location = new System.Drawing.Point(26, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(557, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Si tienes problemas con la aplicación puedes comunicarte con el administrador";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label4.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(23, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(564, 33);
            this.label4.TabIndex = 20;
            this.label4.Text = "No hay tareas pendientes por el momento!";
            // 
            // Lbl_Saludo
            // 
            this.Lbl_Saludo.AutoSize = true;
            this.Lbl_Saludo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Lbl_Saludo.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Saludo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(155)))), ((int)(((byte)(43)))));
            this.Lbl_Saludo.Location = new System.Drawing.Point(23, 25);
            this.Lbl_Saludo.Name = "Lbl_Saludo";
            this.Lbl_Saludo.Size = new System.Drawing.Size(112, 34);
            this.Lbl_Saludo.TabIndex = 19;
            this.Lbl_Saludo.Text = "Saludo";
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(29)))));
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.gunaElipsePanel1.Controls.Add(this.gunaElipsePanel3);
            this.gunaElipsePanel1.Controls.Add(this.pictureBox2);
            this.gunaElipsePanel1.Controls.Add(this.label5);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(1034, 13);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Size = new System.Drawing.Size(268, 810);
            this.gunaElipsePanel1.TabIndex = 16;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.pictureBox4.Image = global::Vista.Properties.Resources.rayo;
            this.pictureBox4.Location = new System.Drawing.Point(44, 41);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(34, 34);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 23;
            this.pictureBox4.TabStop = false;
            // 
            // gunaElipsePanel3
            // 
            this.gunaElipsePanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.gunaElipsePanel3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.gunaElipsePanel3.Controls.Add(this.pictureBox4);
            this.gunaElipsePanel3.Controls.Add(this.label6);
            this.gunaElipsePanel3.Controls.Add(this.label8);
            this.gunaElipsePanel3.Location = new System.Drawing.Point(13, 301);
            this.gunaElipsePanel3.Name = "gunaElipsePanel3";
            this.gunaElipsePanel3.Size = new System.Drawing.Size(242, 102);
            this.gunaElipsePanel3.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.label6.Location = new System.Drawing.Point(20, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 19);
            this.label6.TabIndex = 23;
            this.label6.Text = "Program Status:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label8.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(12)))));
            this.label8.Location = new System.Drawing.Point(84, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 37);
            this.label8.TabIndex = 19;
            this.label8.Text = "Good!";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.pictureBox2.Image = global::Vista.Properties.Resources.Car1;
            this.pictureBox2.Location = new System.Drawing.Point(3, 37);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(265, 254);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.label5.Location = new System.Drawing.Point(13, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Requests Status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(1618, 924);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.gunaTextBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.PanelStatsMain.ResumeLayout(false);
            this.PanelStatsMain.PerformLayout();
            this.gunaElipsePanel2.ResumeLayout(false);
            this.gunaElipsePanel2.PerformLayout();
            this.gunaElipsePanel1.ResumeLayout(false);
            this.gunaElipsePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.gunaElipsePanel3.ResumeLayout(false);
            this.gunaElipsePanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private LiveCharts.WinForms.CartesianChart cartesianChart;
        private Guna.UI.WinForms.GunaButton Btn_registroUsuario;
        private Guna.UI.WinForms.GunaButton Btn_Solicitud;
        private Guna.UI.WinForms.GunaButton Btn_Vehiculo;
        private Guna.UI.WinForms.GunaButton Btn_Facturacion;
        private Guna.UI.WinForms.GunaButton Btn_registroVehiculo;
        private System.Windows.Forms.Label LblRol;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Panel MainPanel;
        private Guna.UI.WinForms.GunaButton Btn_Contactos;
        public System.Windows.Forms.Panel PanelStatsMain;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaButton Btn_Reingreso;
        private Guna.UI.WinForms.GunaButton BtnSession;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel2;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private LiveCharts.Wpf.CartesianChart cartesianChart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_Saludo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

