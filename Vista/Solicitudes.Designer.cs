
namespace Vista
{
    partial class Solicitudes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.CmbUser = new Guna.UI.WinForms.GunaComboBox();
            this.Lbl_Estado = new System.Windows.Forms.Label();
            this.CmbEstadoSolicitud = new Guna.UI.WinForms.GunaComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbVehicle = new Guna.UI.WinForms.GunaComboBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.datePickerLlegada = new System.Windows.Forms.DateTimePicker();
            this.datePickerSalida = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gunaGroupBox2 = new Guna.UI.WinForms.GunaGroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Btn_Solicitud = new Guna.UI.WinForms.GunaButton();
            this.Btn_Eliminar = new Guna.UI.WinForms.GunaButton();
            this.Register_Solicitud = new Guna.UI.WinForms.GunaButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Txt_ID = new Guna.UI.WinForms.GunaTextBox();
            this.DatePickerInicio = new System.Windows.Forms.DateTimePicker();
            this.DatePickerIngreso = new System.Windows.Forms.DateTimePicker();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.gunaGroupBox1.SuspendLayout();
            this.gunaGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_Exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1325, 40);
            this.panel1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.label3.Location = new System.Drawing.Point(12, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(288, 29);
            this.label3.TabIndex = 28;
            this.label3.Text = "Registro de Solicitudes:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(36, 92);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 18);
            this.label12.TabIndex = 62;
            this.label12.Text = "Cliente solicitante:";
            // 
            // CmbUser
            // 
            this.CmbUser.BackColor = System.Drawing.Color.Transparent;
            this.CmbUser.BaseColor = System.Drawing.Color.White;
            this.CmbUser.BorderColor = System.Drawing.Color.Silver;
            this.CmbUser.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbUser.FocusedColor = System.Drawing.Color.Empty;
            this.CmbUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbUser.ForeColor = System.Drawing.Color.Black;
            this.CmbUser.FormattingEnabled = true;
            this.CmbUser.Location = new System.Drawing.Point(29, 126);
            this.CmbUser.Name = "CmbUser";
            this.CmbUser.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CmbUser.OnHoverItemForeColor = System.Drawing.Color.White;
            this.CmbUser.Radius = 5;
            this.CmbUser.Size = new System.Drawing.Size(341, 27);
            this.CmbUser.TabIndex = 61;
            this.CmbUser.Click += new System.EventHandler(this.CmbUser_Click);
            // 
            // Lbl_Estado
            // 
            this.Lbl_Estado.AutoSize = true;
            this.Lbl_Estado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Estado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_Estado.Location = new System.Drawing.Point(36, 397);
            this.Lbl_Estado.Name = "Lbl_Estado";
            this.Lbl_Estado.Size = new System.Drawing.Size(164, 18);
            this.Lbl_Estado.TabIndex = 64;
            this.Lbl_Estado.Text = "Estado de la Solicitud:";
            // 
            // CmbEstadoSolicitud
            // 
            this.CmbEstadoSolicitud.BackColor = System.Drawing.Color.Transparent;
            this.CmbEstadoSolicitud.BaseColor = System.Drawing.Color.White;
            this.CmbEstadoSolicitud.BorderColor = System.Drawing.Color.Silver;
            this.CmbEstadoSolicitud.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbEstadoSolicitud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEstadoSolicitud.FocusedColor = System.Drawing.Color.Empty;
            this.CmbEstadoSolicitud.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbEstadoSolicitud.ForeColor = System.Drawing.Color.Black;
            this.CmbEstadoSolicitud.FormattingEnabled = true;
            this.CmbEstadoSolicitud.Location = new System.Drawing.Point(29, 432);
            this.CmbEstadoSolicitud.Name = "CmbEstadoSolicitud";
            this.CmbEstadoSolicitud.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CmbEstadoSolicitud.OnHoverItemForeColor = System.Drawing.Color.White;
            this.CmbEstadoSolicitud.Radius = 5;
            this.CmbEstadoSolicitud.Size = new System.Drawing.Size(341, 27);
            this.CmbEstadoSolicitud.TabIndex = 63;
            this.CmbEstadoSolicitud.Click += new System.EventHandler(this.CmbEstadoSolicitud_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(36, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 18);
            this.label2.TabIndex = 66;
            this.label2.Text = "Vehículos Solicitado:";
            // 
            // CmbVehicle
            // 
            this.CmbVehicle.BackColor = System.Drawing.Color.Transparent;
            this.CmbVehicle.BaseColor = System.Drawing.Color.White;
            this.CmbVehicle.BorderColor = System.Drawing.Color.Silver;
            this.CmbVehicle.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbVehicle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbVehicle.FocusedColor = System.Drawing.Color.Empty;
            this.CmbVehicle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbVehicle.ForeColor = System.Drawing.Color.Black;
            this.CmbVehicle.FormattingEnabled = true;
            this.CmbVehicle.Location = new System.Drawing.Point(29, 245);
            this.CmbVehicle.Name = "CmbVehicle";
            this.CmbVehicle.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CmbVehicle.OnHoverItemForeColor = System.Drawing.Color.White;
            this.CmbVehicle.Radius = 5;
            this.CmbVehicle.Size = new System.Drawing.Size(341, 27);
            this.CmbVehicle.TabIndex = 65;
            this.CmbVehicle.Click += new System.EventHandler(this.CmbVehicle_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 561);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(1301, 267);
            this.dataGridView.TabIndex = 70;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Solicitud_Admin);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(25, 526);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(190, 19);
            this.label14.TabIndex = 69;
            this.label14.Text = "Solicitudes registradas:";
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.gunaGroupBox1.Controls.Add(this.datePickerLlegada);
            this.gunaGroupBox1.Controls.Add(this.datePickerSalida);
            this.gunaGroupBox1.Controls.Add(this.label5);
            this.gunaGroupBox1.Controls.Add(this.label4);
            this.gunaGroupBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaGroupBox1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.gunaGroupBox1.Location = new System.Drawing.Point(407, 93);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Radius = 5;
            this.gunaGroupBox1.Size = new System.Drawing.Size(429, 265);
            this.gunaGroupBox1.TabIndex = 75;
            this.gunaGroupBox1.Text = "Horario de Registro";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // datePickerLlegada
            // 
            this.datePickerLlegada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.datePickerLlegada.Location = new System.Drawing.Point(37, 194);
            this.datePickerLlegada.Name = "datePickerLlegada";
            this.datePickerLlegada.Size = new System.Drawing.Size(349, 25);
            this.datePickerLlegada.TabIndex = 81;
            // 
            // datePickerSalida
            // 
            this.datePickerSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.datePickerSalida.Location = new System.Drawing.Point(37, 99);
            this.datePickerSalida.Name = "datePickerSalida";
            this.datePickerSalida.Size = new System.Drawing.Size(349, 25);
            this.datePickerSalida.TabIndex = 80;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(34, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 18);
            this.label5.TabIndex = 78;
            this.label5.Text = "Hora de llegada:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(34, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 18);
            this.label4.TabIndex = 77;
            this.label4.Text = "Hora de Salida:";
            // 
            // gunaGroupBox2
            // 
            this.gunaGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.gunaGroupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.gunaGroupBox2.Controls.Add(this.DatePickerIngreso);
            this.gunaGroupBox2.Controls.Add(this.DatePickerInicio);
            this.gunaGroupBox2.Controls.Add(this.label7);
            this.gunaGroupBox2.Controls.Add(this.label6);
            this.gunaGroupBox2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaGroupBox2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.gunaGroupBox2.Location = new System.Drawing.Point(860, 93);
            this.gunaGroupBox2.Name = "gunaGroupBox2";
            this.gunaGroupBox2.Radius = 5;
            this.gunaGroupBox2.Size = new System.Drawing.Size(433, 265);
            this.gunaGroupBox2.TabIndex = 76;
            this.gunaGroupBox2.Text = "Fechas de Registro";
            this.gunaGroupBox2.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(39, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 18);
            this.label7.TabIndex = 79;
            this.label7.Text = "Fecha de inicio:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(39, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 18);
            this.label6.TabIndex = 79;
            this.label6.Text = "Fecha de Ingreso:";
            // 
            // Btn_Solicitud
            // 
            this.Btn_Solicitud.AnimationHoverSpeed = 0.07F;
            this.Btn_Solicitud.AnimationSpeed = 0.03F;
            this.Btn_Solicitud.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Solicitud.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Btn_Solicitud.BorderColor = System.Drawing.Color.Black;
            this.Btn_Solicitud.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Btn_Solicitud.FocusedColor = System.Drawing.Color.Empty;
            this.Btn_Solicitud.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Solicitud.ForeColor = System.Drawing.Color.White;
            this.Btn_Solicitud.Image = null;
            this.Btn_Solicitud.ImageSize = new System.Drawing.Size(20, 20);
            this.Btn_Solicitud.Location = new System.Drawing.Point(1026, 500);
            this.Btn_Solicitud.Name = "Btn_Solicitud";
            this.Btn_Solicitud.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.Btn_Solicitud.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Btn_Solicitud.OnHoverForeColor = System.Drawing.Color.White;
            this.Btn_Solicitud.OnHoverImage = null;
            this.Btn_Solicitud.OnPressedColor = System.Drawing.Color.Black;
            this.Btn_Solicitud.Radius = 10;
            this.Btn_Solicitud.Size = new System.Drawing.Size(140, 45);
            this.Btn_Solicitud.TabIndex = 79;
            this.Btn_Solicitud.Text = "Actualizar";
            this.Btn_Solicitud.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Btn_Solicitud.Click += new System.EventHandler(this.Btn_Solicitud_Click);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.AnimationHoverSpeed = 0.07F;
            this.Btn_Eliminar.AnimationSpeed = 0.03F;
            this.Btn_Eliminar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Eliminar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Btn_Eliminar.BorderColor = System.Drawing.Color.Black;
            this.Btn_Eliminar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Btn_Eliminar.FocusedColor = System.Drawing.Color.Empty;
            this.Btn_Eliminar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Eliminar.ForeColor = System.Drawing.Color.White;
            this.Btn_Eliminar.Image = null;
            this.Btn_Eliminar.ImageSize = new System.Drawing.Size(20, 20);
            this.Btn_Eliminar.Location = new System.Drawing.Point(1172, 500);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.Btn_Eliminar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Btn_Eliminar.OnHoverForeColor = System.Drawing.Color.White;
            this.Btn_Eliminar.OnHoverImage = null;
            this.Btn_Eliminar.OnPressedColor = System.Drawing.Color.Black;
            this.Btn_Eliminar.Radius = 10;
            this.Btn_Eliminar.Size = new System.Drawing.Size(140, 45);
            this.Btn_Eliminar.TabIndex = 78;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Register_Solicitud
            // 
            this.Register_Solicitud.AnimationHoverSpeed = 0.07F;
            this.Register_Solicitud.AnimationSpeed = 0.03F;
            this.Register_Solicitud.BackColor = System.Drawing.Color.Transparent;
            this.Register_Solicitud.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Register_Solicitud.BorderColor = System.Drawing.Color.Black;
            this.Register_Solicitud.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Register_Solicitud.FocusedColor = System.Drawing.Color.Empty;
            this.Register_Solicitud.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_Solicitud.ForeColor = System.Drawing.Color.White;
            this.Register_Solicitud.Image = null;
            this.Register_Solicitud.ImageSize = new System.Drawing.Size(20, 20);
            this.Register_Solicitud.Location = new System.Drawing.Point(793, 500);
            this.Register_Solicitud.Name = "Register_Solicitud";
            this.Register_Solicitud.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.Register_Solicitud.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Register_Solicitud.OnHoverForeColor = System.Drawing.Color.White;
            this.Register_Solicitud.OnHoverImage = null;
            this.Register_Solicitud.OnPressedColor = System.Drawing.Color.Black;
            this.Register_Solicitud.Radius = 10;
            this.Register_Solicitud.Size = new System.Drawing.Size(227, 45);
            this.Register_Solicitud.TabIndex = 77;
            this.Register_Solicitud.Text = "Registrar";
            this.Register_Solicitud.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Register_Solicitud.Click += new System.EventHandler(this.Register_Solicitud_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 571);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1301, 202);
            this.dataGridView1.TabIndex = 80;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridCliente);
            // 
            // Txt_ID
            // 
            this.Txt_ID.BackColor = System.Drawing.Color.Transparent;
            this.Txt_ID.BaseColor = System.Drawing.Color.White;
            this.Txt_ID.BorderColor = System.Drawing.Color.Silver;
            this.Txt_ID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_ID.FocusedBaseColor = System.Drawing.Color.White;
            this.Txt_ID.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Txt_ID.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.Txt_ID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Txt_ID.Location = new System.Drawing.Point(29, 328);
            this.Txt_ID.Name = "Txt_ID";
            this.Txt_ID.PasswordChar = '\0';
            this.Txt_ID.Radius = 5;
            this.Txt_ID.SelectedText = "";
            this.Txt_ID.Size = new System.Drawing.Size(96, 30);
            this.Txt_ID.TabIndex = 81;
            this.Txt_ID.Visible = false;
            // 
            // DatePickerInicio
            // 
            this.DatePickerInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePickerInicio.Location = new System.Drawing.Point(42, 99);
            this.DatePickerInicio.MaxDate = new System.DateTime(2026, 12, 31, 0, 0, 0, 0);
            this.DatePickerInicio.MinDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.DatePickerInicio.Name = "DatePickerInicio";
            this.DatePickerInicio.Size = new System.Drawing.Size(338, 25);
            this.DatePickerInicio.TabIndex = 82;
            // 
            // DatePickerIngreso
            // 
            this.DatePickerIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePickerIngreso.Location = new System.Drawing.Point(42, 194);
            this.DatePickerIngreso.MaxDate = new System.DateTime(2026, 12, 31, 0, 0, 0, 0);
            this.DatePickerIngreso.MinDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.DatePickerIngreso.Name = "DatePickerIngreso";
            this.DatePickerIngreso.Size = new System.Drawing.Size(338, 25);
            this.DatePickerIngreso.TabIndex = 83;
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(51)))), ((int)(((byte)(52)))));
            this.Btn_Exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Exit.FlatAppearance.BorderSize = 0;
            this.Btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Exit.Image = global::Vista.Properties.Resources.minimizar_signo1;
            this.Btn_Exit.Location = new System.Drawing.Point(1285, 0);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(40, 40);
            this.Btn_Exit.TabIndex = 1;
            this.Btn_Exit.UseVisualStyleBackColor = false;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Solicitudes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1325, 840);
            this.Controls.Add(this.Txt_ID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Btn_Solicitud);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Register_Solicitud);
            this.Controls.Add(this.gunaGroupBox2);
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CmbVehicle);
            this.Controls.Add(this.Lbl_Estado);
            this.Controls.Add(this.CmbEstadoSolicitud);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.CmbUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Solicitudes";
            this.Text = "Solicitueds";
            this.Load += new System.EventHandler(this.Solicitudes_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.gunaGroupBox2.ResumeLayout(false);
            this.gunaGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private Guna.UI.WinForms.GunaComboBox CmbUser;
        private System.Windows.Forms.Label Lbl_Estado;
        private Guna.UI.WinForms.GunaComboBox CmbEstadoSolicitud;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaComboBox CmbVehicle;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label14;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox2;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaButton Btn_Solicitud;
        private Guna.UI.WinForms.GunaButton Btn_Eliminar;
        private Guna.UI.WinForms.GunaButton Register_Solicitud;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker datePickerSalida;
        private System.Windows.Forms.DateTimePicker datePickerLlegada;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI.WinForms.GunaTextBox Txt_ID;
        private System.Windows.Forms.DateTimePicker DatePickerInicio;
        private System.Windows.Forms.DateTimePicker DatePickerIngreso;
    }
}