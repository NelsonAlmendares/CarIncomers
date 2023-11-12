
namespace Vista
{
    partial class Facturacion
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
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.CmbSollicitud = new Guna.UI.WinForms.GunaComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Kilometraje = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.datePickerSalida = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CmbPoliza = new Guna.UI.WinForms.GunaComboBox();
            this.CmbTipoTarjeta = new Guna.UI.WinForms.GunaComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaGroupBox2 = new Guna.UI.WinForms.GunaGroupBox();
            this.Pin_Tarjeta = new Guna.UI.WinForms.GunaLineTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DatePickerInicio = new Guna.UI.WinForms.GunaDateTimePicker();
            this.CmbEquipamentos = new Guna.UI.WinForms.GunaComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Nun_Tarjeta = new Guna.UI.WinForms.GunaLineTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Txt_Descripcion = new System.Windows.Forms.RichTextBox();
            this.Actualizar = new Guna.UI.WinForms.GunaButton();
            this.Add_Factura = new Guna.UI.WinForms.GunaButton();
            this.label14 = new System.Windows.Forms.Label();
            this.Open_Factura = new Guna.UI.WinForms.GunaButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.gunaGroupBox1.SuspendLayout();
            this.gunaGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_Exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1325, 40);
            this.panel1.TabIndex = 5;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.label3.Location = new System.Drawing.Point(12, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(327, 29);
            this.label3.TabIndex = 29;
            this.label3.Text = "Facturación de Solicitudes:";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 588);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(1301, 240);
            this.dataGridView.TabIndex = 71;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(35, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(164, 18);
            this.label12.TabIndex = 73;
            this.label12.Text = "Solicitud a nombre de:";
            // 
            // CmbSollicitud
            // 
            this.CmbSollicitud.BackColor = System.Drawing.Color.Transparent;
            this.CmbSollicitud.BaseColor = System.Drawing.Color.White;
            this.CmbSollicitud.BorderColor = System.Drawing.Color.Silver;
            this.CmbSollicitud.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbSollicitud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSollicitud.FocusedColor = System.Drawing.Color.Empty;
            this.CmbSollicitud.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbSollicitud.ForeColor = System.Drawing.Color.Black;
            this.CmbSollicitud.FormattingEnabled = true;
            this.CmbSollicitud.Location = new System.Drawing.Point(29, 113);
            this.CmbSollicitud.Name = "CmbSollicitud";
            this.CmbSollicitud.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CmbSollicitud.OnHoverItemForeColor = System.Drawing.Color.White;
            this.CmbSollicitud.Radius = 5;
            this.CmbSollicitud.Size = new System.Drawing.Size(366, 27);
            this.CmbSollicitud.TabIndex = 72;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(44, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 18);
            this.label2.TabIndex = 77;
            this.label2.Text = "Kilometraje registrado:";
            // 
            // Txt_Kilometraje
            // 
            this.Txt_Kilometraje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.Txt_Kilometraje.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Kilometraje.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Txt_Kilometraje.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Kilometraje.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Txt_Kilometraje.LineColor = System.Drawing.Color.Gainsboro;
            this.Txt_Kilometraje.Location = new System.Drawing.Point(36, 359);
            this.Txt_Kilometraje.Name = "Txt_Kilometraje";
            this.Txt_Kilometraje.PasswordChar = '\0';
            this.Txt_Kilometraje.SelectedText = "";
            this.Txt_Kilometraje.Size = new System.Drawing.Size(351, 35);
            this.Txt_Kilometraje.TabIndex = 76;
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.gunaGroupBox1.Controls.Add(this.datePickerSalida);
            this.gunaGroupBox1.Controls.Add(this.label4);
            this.gunaGroupBox1.Controls.Add(this.label10);
            this.gunaGroupBox1.Controls.Add(this.CmbPoliza);
            this.gunaGroupBox1.Controls.Add(this.CmbTipoTarjeta);
            this.gunaGroupBox1.Controls.Add(this.label1);
            this.gunaGroupBox1.Controls.Add(this.Txt_Kilometraje);
            this.gunaGroupBox1.Controls.Add(this.label2);
            this.gunaGroupBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaGroupBox1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.gunaGroupBox1.Location = new System.Drawing.Point(427, 66);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Radius = 5;
            this.gunaGroupBox1.Size = new System.Drawing.Size(429, 436);
            this.gunaGroupBox1.TabIndex = 78;
            this.gunaGroupBox1.Text = "Horario de Registro";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // datePickerSalida
            // 
            this.datePickerSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.datePickerSalida.Location = new System.Drawing.Point(36, 83);
            this.datePickerSalida.Name = "datePickerSalida";
            this.datePickerSalida.Size = new System.Drawing.Size(349, 25);
            this.datePickerSalida.TabIndex = 80;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(33, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 18);
            this.label4.TabIndex = 77;
            this.label4.Text = "Hora de Salida:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(44, 232);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 18);
            this.label10.TabIndex = 113;
            this.label10.Text = "Tipo de Tarjeta:";
            // 
            // CmbPoliza
            // 
            this.CmbPoliza.BackColor = System.Drawing.Color.Transparent;
            this.CmbPoliza.BaseColor = System.Drawing.Color.White;
            this.CmbPoliza.BorderColor = System.Drawing.Color.Silver;
            this.CmbPoliza.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbPoliza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbPoliza.FocusedColor = System.Drawing.Color.Empty;
            this.CmbPoliza.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbPoliza.ForeColor = System.Drawing.Color.Black;
            this.CmbPoliza.FormattingEnabled = true;
            this.CmbPoliza.Location = new System.Drawing.Point(36, 170);
            this.CmbPoliza.Name = "CmbPoliza";
            this.CmbPoliza.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CmbPoliza.OnHoverItemForeColor = System.Drawing.Color.White;
            this.CmbPoliza.Radius = 5;
            this.CmbPoliza.Size = new System.Drawing.Size(351, 27);
            this.CmbPoliza.TabIndex = 100;
            // 
            // CmbTipoTarjeta
            // 
            this.CmbTipoTarjeta.BackColor = System.Drawing.Color.Transparent;
            this.CmbTipoTarjeta.BaseColor = System.Drawing.Color.White;
            this.CmbTipoTarjeta.BorderColor = System.Drawing.Color.Silver;
            this.CmbTipoTarjeta.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbTipoTarjeta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipoTarjeta.FocusedColor = System.Drawing.Color.Empty;
            this.CmbTipoTarjeta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbTipoTarjeta.ForeColor = System.Drawing.Color.Black;
            this.CmbTipoTarjeta.FormattingEnabled = true;
            this.CmbTipoTarjeta.Location = new System.Drawing.Point(36, 264);
            this.CmbTipoTarjeta.Name = "CmbTipoTarjeta";
            this.CmbTipoTarjeta.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CmbTipoTarjeta.OnHoverItemForeColor = System.Drawing.Color.White;
            this.CmbTipoTarjeta.Radius = 5;
            this.CmbTipoTarjeta.Size = new System.Drawing.Size(351, 27);
            this.CmbTipoTarjeta.TabIndex = 112;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(44, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 18);
            this.label1.TabIndex = 101;
            this.label1.Text = "Poliza de Seguro:";
            // 
            // gunaGroupBox2
            // 
            this.gunaGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.gunaGroupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.gunaGroupBox2.Controls.Add(this.Open_Factura);
            this.gunaGroupBox2.Controls.Add(this.Pin_Tarjeta);
            this.gunaGroupBox2.Controls.Add(this.label8);
            this.gunaGroupBox2.Controls.Add(this.label7);
            this.gunaGroupBox2.Controls.Add(this.DatePickerInicio);
            this.gunaGroupBox2.Controls.Add(this.CmbEquipamentos);
            this.gunaGroupBox2.Controls.Add(this.label5);
            this.gunaGroupBox2.Controls.Add(this.Nun_Tarjeta);
            this.gunaGroupBox2.Controls.Add(this.label6);
            this.gunaGroupBox2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaGroupBox2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.gunaGroupBox2.Location = new System.Drawing.Point(881, 66);
            this.gunaGroupBox2.Name = "gunaGroupBox2";
            this.gunaGroupBox2.Radius = 5;
            this.gunaGroupBox2.Size = new System.Drawing.Size(432, 436);
            this.gunaGroupBox2.TabIndex = 79;
            this.gunaGroupBox2.Text = "Fechas de Registro";
            this.gunaGroupBox2.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // Pin_Tarjeta
            // 
            this.Pin_Tarjeta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.Pin_Tarjeta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Pin_Tarjeta.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Pin_Tarjeta.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin_Tarjeta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Pin_Tarjeta.LineColor = System.Drawing.Color.Gainsboro;
            this.Pin_Tarjeta.Location = new System.Drawing.Point(42, 359);
            this.Pin_Tarjeta.Name = "Pin_Tarjeta";
            this.Pin_Tarjeta.PasswordChar = '\0';
            this.Pin_Tarjeta.SelectedText = "";
            this.Pin_Tarjeta.Size = new System.Drawing.Size(122, 35);
            this.Pin_Tarjeta.TabIndex = 109;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(48, 327);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 18);
            this.label8.TabIndex = 110;
            this.label8.Text = "Pin de Tarjeta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(49, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 18);
            this.label7.TabIndex = 79;
            this.label7.Text = "Fecha de inicio:";
            // 
            // DatePickerInicio
            // 
            this.DatePickerInicio.BaseColor = System.Drawing.Color.White;
            this.DatePickerInicio.BorderColor = System.Drawing.Color.Silver;
            this.DatePickerInicio.CustomFormat = "yyyy-MM-dd";
            this.DatePickerInicio.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DatePickerInicio.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DatePickerInicio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DatePickerInicio.ForeColor = System.Drawing.Color.Black;
            this.DatePickerInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePickerInicio.Location = new System.Drawing.Point(42, 78);
            this.DatePickerInicio.MaxDate = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            this.DatePickerInicio.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.DatePickerInicio.Name = "DatePickerInicio";
            this.DatePickerInicio.OnHoverBaseColor = System.Drawing.Color.White;
            this.DatePickerInicio.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DatePickerInicio.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DatePickerInicio.OnPressedColor = System.Drawing.Color.Black;
            this.DatePickerInicio.Size = new System.Drawing.Size(355, 30);
            this.DatePickerInicio.TabIndex = 71;
            this.DatePickerInicio.Text = "2023-11-04";
            this.DatePickerInicio.Value = new System.DateTime(2023, 11, 4, 20, 23, 40, 839);
            // 
            // CmbEquipamentos
            // 
            this.CmbEquipamentos.BackColor = System.Drawing.Color.Transparent;
            this.CmbEquipamentos.BaseColor = System.Drawing.Color.White;
            this.CmbEquipamentos.BorderColor = System.Drawing.Color.Silver;
            this.CmbEquipamentos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbEquipamentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEquipamentos.FocusedColor = System.Drawing.Color.Empty;
            this.CmbEquipamentos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbEquipamentos.ForeColor = System.Drawing.Color.Black;
            this.CmbEquipamentos.FormattingEnabled = true;
            this.CmbEquipamentos.Location = new System.Drawing.Point(42, 170);
            this.CmbEquipamentos.Name = "CmbEquipamentos";
            this.CmbEquipamentos.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CmbEquipamentos.OnHoverItemForeColor = System.Drawing.Color.White;
            this.CmbEquipamentos.Radius = 5;
            this.CmbEquipamentos.Size = new System.Drawing.Size(351, 27);
            this.CmbEquipamentos.TabIndex = 102;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(48, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 18);
            this.label5.TabIndex = 103;
            this.label5.Text = "Equipamentos del vehículo";
            // 
            // Nun_Tarjeta
            // 
            this.Nun_Tarjeta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.Nun_Tarjeta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Nun_Tarjeta.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Nun_Tarjeta.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nun_Tarjeta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Nun_Tarjeta.LineColor = System.Drawing.Color.Gainsboro;
            this.Nun_Tarjeta.Location = new System.Drawing.Point(42, 256);
            this.Nun_Tarjeta.Name = "Nun_Tarjeta";
            this.Nun_Tarjeta.PasswordChar = '\0';
            this.Nun_Tarjeta.SelectedText = "";
            this.Nun_Tarjeta.Size = new System.Drawing.Size(351, 35);
            this.Nun_Tarjeta.TabIndex = 107;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(50, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 18);
            this.label6.TabIndex = 108;
            this.label6.Text = "Número de Tarjeta";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label15.Location = new System.Drawing.Point(35, 339);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(183, 18);
            this.label15.TabIndex = 99;
            this.label15.Text = "Descripción del Vehículo:";
            // 
            // Txt_Descripcion
            // 
            this.Txt_Descripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Txt_Descripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Descripcion.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Descripcion.ForeColor = System.Drawing.SystemColors.Info;
            this.Txt_Descripcion.Location = new System.Drawing.Point(29, 371);
            this.Txt_Descripcion.Name = "Txt_Descripcion";
            this.Txt_Descripcion.Size = new System.Drawing.Size(366, 131);
            this.Txt_Descripcion.TabIndex = 98;
            this.Txt_Descripcion.Text = "";
            // 
            // Actualizar
            // 
            this.Actualizar.AnimationHoverSpeed = 0.07F;
            this.Actualizar.AnimationSpeed = 0.03F;
            this.Actualizar.BackColor = System.Drawing.Color.Transparent;
            this.Actualizar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Actualizar.BorderColor = System.Drawing.Color.Black;
            this.Actualizar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Actualizar.FocusedColor = System.Drawing.Color.Empty;
            this.Actualizar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Actualizar.ForeColor = System.Drawing.Color.White;
            this.Actualizar.Image = null;
            this.Actualizar.ImageSize = new System.Drawing.Size(20, 20);
            this.Actualizar.Location = new System.Drawing.Point(1167, 526);
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.Actualizar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Actualizar.OnHoverForeColor = System.Drawing.Color.White;
            this.Actualizar.OnHoverImage = null;
            this.Actualizar.OnPressedColor = System.Drawing.Color.Black;
            this.Actualizar.Radius = 10;
            this.Actualizar.Size = new System.Drawing.Size(140, 45);
            this.Actualizar.TabIndex = 106;
            this.Actualizar.Text = "Actualizar";
            this.Actualizar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Actualizar.Click += new System.EventHandler(this.Actualizar_Click);
            // 
            // Add_Factura
            // 
            this.Add_Factura.AnimationHoverSpeed = 0.07F;
            this.Add_Factura.AnimationSpeed = 0.03F;
            this.Add_Factura.BackColor = System.Drawing.Color.Transparent;
            this.Add_Factura.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Add_Factura.BorderColor = System.Drawing.Color.Black;
            this.Add_Factura.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Add_Factura.FocusedColor = System.Drawing.Color.Empty;
            this.Add_Factura.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Factura.ForeColor = System.Drawing.Color.White;
            this.Add_Factura.Image = null;
            this.Add_Factura.ImageSize = new System.Drawing.Size(20, 20);
            this.Add_Factura.Location = new System.Drawing.Point(934, 526);
            this.Add_Factura.Name = "Add_Factura";
            this.Add_Factura.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.Add_Factura.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Add_Factura.OnHoverForeColor = System.Drawing.Color.White;
            this.Add_Factura.OnHoverImage = null;
            this.Add_Factura.OnPressedColor = System.Drawing.Color.Black;
            this.Add_Factura.Radius = 10;
            this.Add_Factura.Size = new System.Drawing.Size(227, 45);
            this.Add_Factura.TabIndex = 104;
            this.Add_Factura.Text = "Registrar";
            this.Add_Factura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Add_Factura.Click += new System.EventHandler(this.Add_Factura_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(25, 552);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(164, 19);
            this.label14.TabIndex = 111;
            this.label14.Text = "Facturas realizadas:";
            // 
            // Open_Factura
            // 
            this.Open_Factura.AnimationHoverSpeed = 0.07F;
            this.Open_Factura.AnimationSpeed = 0.03F;
            this.Open_Factura.BackColor = System.Drawing.Color.Transparent;
            this.Open_Factura.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Open_Factura.BorderColor = System.Drawing.Color.Black;
            this.Open_Factura.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Open_Factura.FocusedColor = System.Drawing.Color.Empty;
            this.Open_Factura.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Open_Factura.ForeColor = System.Drawing.Color.White;
            this.Open_Factura.Image = null;
            this.Open_Factura.ImageSize = new System.Drawing.Size(20, 20);
            this.Open_Factura.Location = new System.Drawing.Point(216, 349);
            this.Open_Factura.Name = "Open_Factura";
            this.Open_Factura.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Open_Factura.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Open_Factura.OnHoverForeColor = System.Drawing.Color.White;
            this.Open_Factura.OnHoverImage = null;
            this.Open_Factura.OnPressedColor = System.Drawing.Color.Black;
            this.Open_Factura.Radius = 10;
            this.Open_Factura.Size = new System.Drawing.Size(177, 45);
            this.Open_Factura.TabIndex = 112;
            this.Open_Factura.Text = "Generar Factura:";
            this.Open_Factura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Open_Factura.Click += new System.EventHandler(this.Open_Factura_Click);
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1325, 840);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Actualizar);
            this.Controls.Add(this.Add_Factura);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Txt_Descripcion);
            this.Controls.Add(this.gunaGroupBox2);
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.CmbSollicitud);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Facturacion";
            this.Text = "Facturacion";
            this.Load += new System.EventHandler(this.Facturacion_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.gunaGroupBox2.ResumeLayout(false);
            this.gunaGroupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label12;
        private Guna.UI.WinForms.GunaComboBox CmbSollicitud;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaLineTextBox Txt_Kilometraje;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private System.Windows.Forms.DateTimePicker datePickerSalida;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox2;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaDateTimePicker DatePickerInicio;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RichTextBox Txt_Descripcion;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaComboBox CmbPoliza;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaComboBox CmbEquipamentos;
        private Guna.UI.WinForms.GunaButton Actualizar;
        private Guna.UI.WinForms.GunaButton Add_Factura;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaLineTextBox Nun_Tarjeta;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaLineTextBox Pin_Tarjeta;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private Guna.UI.WinForms.GunaComboBox CmbTipoTarjeta;
        private Guna.UI.WinForms.GunaButton Open_Factura;
    }
}