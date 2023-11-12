
namespace Vista
{
    partial class Registro_Vehiculos
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
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_NumeroMotor = new Guna.UI.WinForms.GunaLineTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_NumeroChasis = new Guna.UI.WinForms.GunaLineTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Capacidad = new Guna.UI.WinForms.GunaLineTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_kilometraje = new Guna.UI.WinForms.GunaLineTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_Transmision = new Guna.UI.WinForms.GunaLineTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.DateTimePicker = new Guna.UI.WinForms.GunaDateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_ValorUnidad = new Guna.UI.WinForms.GunaLineTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_puertas = new Guna.UI.WinForms.GunaLineTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Txt_Modelo = new Guna.UI.WinForms.GunaLineTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Txt_Marca = new Guna.UI.WinForms.GunaLineTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Txt_Placa = new Guna.UI.WinForms.GunaLineTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Txt_Anio = new Guna.UI.WinForms.GunaLineTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Txt_CapacidadVehiculo = new Guna.UI.WinForms.GunaLineTextBox();
            this.Txt_Descripcion = new System.Windows.Forms.RichTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.Register_Vehiculo = new Guna.UI.WinForms.GunaButton();
            this.label16 = new System.Windows.Forms.Label();
            this.CmbTipoVehiculo = new Guna.UI.WinForms.GunaComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.label3.Location = new System.Drawing.Point(12, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 29);
            this.label3.TabIndex = 29;
            this.label3.Text = "Registro de Vehiculos:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_Exit);
            this.panel1.Location = new System.Drawing.Point(1232, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(94, 40);
            this.panel1.TabIndex = 28;
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(51)))), ((int)(((byte)(52)))));
            this.Btn_Exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Exit.FlatAppearance.BorderSize = 0;
            this.Btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Exit.Image = global::Vista.Properties.Resources.minimizar_signo1;
            this.Btn_Exit.Location = new System.Drawing.Point(54, 0);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(40, 40);
            this.Btn_Exit.TabIndex = 1;
            this.Btn_Exit.UseVisualStyleBackColor = false;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 609);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(1301, 219);
            this.dataGridView.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(34, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 18);
            this.label2.TabIndex = 71;
            this.label2.Text = "Número de Motor:";
            // 
            // Txt_NumeroMotor
            // 
            this.Txt_NumeroMotor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Txt_NumeroMotor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_NumeroMotor.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Txt_NumeroMotor.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NumeroMotor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Txt_NumeroMotor.LineColor = System.Drawing.Color.Gainsboro;
            this.Txt_NumeroMotor.Location = new System.Drawing.Point(26, 104);
            this.Txt_NumeroMotor.Name = "Txt_NumeroMotor";
            this.Txt_NumeroMotor.PasswordChar = '\0';
            this.Txt_NumeroMotor.SelectedText = "";
            this.Txt_NumeroMotor.Size = new System.Drawing.Size(361, 35);
            this.Txt_NumeroMotor.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(455, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 18);
            this.label1.TabIndex = 73;
            this.label1.Text = "Número de Chasis:";
            // 
            // Txt_NumeroChasis
            // 
            this.Txt_NumeroChasis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Txt_NumeroChasis.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_NumeroChasis.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Txt_NumeroChasis.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NumeroChasis.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Txt_NumeroChasis.LineColor = System.Drawing.Color.Gainsboro;
            this.Txt_NumeroChasis.Location = new System.Drawing.Point(448, 104);
            this.Txt_NumeroChasis.Name = "Txt_NumeroChasis";
            this.Txt_NumeroChasis.PasswordChar = '\0';
            this.Txt_NumeroChasis.SelectedText = "";
            this.Txt_NumeroChasis.Size = new System.Drawing.Size(353, 35);
            this.Txt_NumeroChasis.TabIndex = 72;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(34, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 18);
            this.label4.TabIndex = 75;
            this.label4.Text = "Capacidad de Pasajeros:";
            // 
            // Txt_Capacidad
            // 
            this.Txt_Capacidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Txt_Capacidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Capacidad.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Txt_Capacidad.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Capacidad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Txt_Capacidad.LineColor = System.Drawing.Color.Gainsboro;
            this.Txt_Capacidad.Location = new System.Drawing.Point(26, 261);
            this.Txt_Capacidad.Name = "Txt_Capacidad";
            this.Txt_Capacidad.PasswordChar = '\0';
            this.Txt_Capacidad.SelectedText = "";
            this.Txt_Capacidad.Size = new System.Drawing.Size(224, 35);
            this.Txt_Capacidad.TabIndex = 74;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(34, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 18);
            this.label5.TabIndex = 77;
            this.label5.Text = "Kilometraje del Vehículo:";
            // 
            // Txt_kilometraje
            // 
            this.Txt_kilometraje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Txt_kilometraje.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_kilometraje.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Txt_kilometraje.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_kilometraje.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Txt_kilometraje.LineColor = System.Drawing.Color.Gainsboro;
            this.Txt_kilometraje.Location = new System.Drawing.Point(26, 377);
            this.Txt_kilometraje.Name = "Txt_kilometraje";
            this.Txt_kilometraje.PasswordChar = '\0';
            this.Txt_kilometraje.SelectedText = "";
            this.Txt_kilometraje.Size = new System.Drawing.Size(224, 35);
            this.Txt_kilometraje.TabIndex = 76;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(310, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 18);
            this.label6.TabIndex = 79;
            this.label6.Text = "Transmición del Vehículo:";
            // 
            // Txt_Transmision
            // 
            this.Txt_Transmision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Txt_Transmision.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Transmision.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Txt_Transmision.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Transmision.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Txt_Transmision.LineColor = System.Drawing.Color.Gainsboro;
            this.Txt_Transmision.Location = new System.Drawing.Point(302, 261);
            this.Txt_Transmision.Name = "Txt_Transmision";
            this.Txt_Transmision.PasswordChar = '\0';
            this.Txt_Transmision.SelectedText = "";
            this.Txt_Transmision.Size = new System.Drawing.Size(227, 35);
            this.Txt_Transmision.TabIndex = 78;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(309, 345);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(220, 18);
            this.label13.TabIndex = 81;
            this.label13.Text = "Fecha de Ingreso del Vehículo:";
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.BackColor = System.Drawing.Color.Transparent;
            this.DateTimePicker.BaseColor = System.Drawing.Color.White;
            this.DateTimePicker.BorderColor = System.Drawing.Color.Silver;
            this.DateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.DateTimePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DateTimePicker.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DateTimePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateTimePicker.ForeColor = System.Drawing.Color.Black;
            this.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePicker.Location = new System.Drawing.Point(302, 382);
            this.DateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.OnHoverBaseColor = System.Drawing.Color.White;
            this.DateTimePicker.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DateTimePicker.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DateTimePicker.OnPressedColor = System.Drawing.Color.Black;
            this.DateTimePicker.Radius = 5;
            this.DateTimePicker.Size = new System.Drawing.Size(227, 30);
            this.DateTimePicker.TabIndex = 80;
            this.DateTimePicker.Text = "2023-10-28";
            this.DateTimePicker.Value = new System.DateTime(2023, 10, 28, 21, 17, 7, 778);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(590, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 18);
            this.label7.TabIndex = 83;
            this.label7.Text = "Valor de la Unidad:";
            // 
            // Txt_ValorUnidad
            // 
            this.Txt_ValorUnidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Txt_ValorUnidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_ValorUnidad.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Txt_ValorUnidad.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_ValorUnidad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Txt_ValorUnidad.LineColor = System.Drawing.Color.Gainsboro;
            this.Txt_ValorUnidad.Location = new System.Drawing.Point(582, 261);
            this.Txt_ValorUnidad.Name = "Txt_ValorUnidad";
            this.Txt_ValorUnidad.PasswordChar = '\0';
            this.Txt_ValorUnidad.SelectedText = "";
            this.Txt_ValorUnidad.Size = new System.Drawing.Size(219, 35);
            this.Txt_ValorUnidad.TabIndex = 82;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(590, 345);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 18);
            this.label8.TabIndex = 85;
            this.label8.Text = "Puertas del Vehículo:";
            // 
            // Txt_puertas
            // 
            this.Txt_puertas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Txt_puertas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_puertas.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Txt_puertas.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_puertas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Txt_puertas.LineColor = System.Drawing.Color.Gainsboro;
            this.Txt_puertas.Location = new System.Drawing.Point(582, 377);
            this.Txt_puertas.Name = "Txt_puertas";
            this.Txt_puertas.PasswordChar = '\0';
            this.Txt_puertas.SelectedText = "";
            this.Txt_puertas.Size = new System.Drawing.Size(219, 35);
            this.Txt_puertas.TabIndex = 84;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(857, 345);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 18);
            this.label9.TabIndex = 89;
            this.label9.Text = "Modelo del Vehículo:";
            // 
            // Txt_Modelo
            // 
            this.Txt_Modelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Txt_Modelo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Modelo.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Txt_Modelo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Modelo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Txt_Modelo.LineColor = System.Drawing.Color.Gainsboro;
            this.Txt_Modelo.Location = new System.Drawing.Point(849, 377);
            this.Txt_Modelo.Name = "Txt_Modelo";
            this.Txt_Modelo.PasswordChar = '\0';
            this.Txt_Modelo.SelectedText = "";
            this.Txt_Modelo.Size = new System.Drawing.Size(202, 35);
            this.Txt_Modelo.TabIndex = 88;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(857, 229);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 18);
            this.label10.TabIndex = 87;
            this.label10.Text = "Marca del Vehículo:";
            // 
            // Txt_Marca
            // 
            this.Txt_Marca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Txt_Marca.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Marca.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Txt_Marca.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Marca.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Txt_Marca.LineColor = System.Drawing.Color.Gainsboro;
            this.Txt_Marca.Location = new System.Drawing.Point(849, 261);
            this.Txt_Marca.Name = "Txt_Marca";
            this.Txt_Marca.PasswordChar = '\0';
            this.Txt_Marca.SelectedText = "";
            this.Txt_Marca.Size = new System.Drawing.Size(202, 35);
            this.Txt_Marca.TabIndex = 86;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(1116, 345);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 18);
            this.label11.TabIndex = 93;
            this.label11.Text = "Placa del Vehículo:";
            // 
            // Txt_Placa
            // 
            this.Txt_Placa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Txt_Placa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Placa.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Txt_Placa.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Placa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Txt_Placa.LineColor = System.Drawing.Color.Gainsboro;
            this.Txt_Placa.Location = new System.Drawing.Point(1106, 377);
            this.Txt_Placa.Name = "Txt_Placa";
            this.Txt_Placa.PasswordChar = '\0';
            this.Txt_Placa.SelectedText = "";
            this.Txt_Placa.Size = new System.Drawing.Size(191, 35);
            this.Txt_Placa.TabIndex = 92;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(1116, 229);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 18);
            this.label12.TabIndex = 91;
            this.label12.Text = "Año del Vehículo:";
            // 
            // Txt_Anio
            // 
            this.Txt_Anio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Txt_Anio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Anio.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Txt_Anio.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Anio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Txt_Anio.LineColor = System.Drawing.Color.Gainsboro;
            this.Txt_Anio.Location = new System.Drawing.Point(1106, 261);
            this.Txt_Anio.Name = "Txt_Anio";
            this.Txt_Anio.PasswordChar = '\0';
            this.Txt_Anio.SelectedText = "";
            this.Txt_Anio.Size = new System.Drawing.Size(191, 35);
            this.Txt_Anio.TabIndex = 90;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(34, 449);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(192, 36);
            this.label14.TabIndex = 95;
            this.label14.Text = "Capacida de equipaje del \r\nVehículo:";
            // 
            // Txt_CapacidadVehiculo
            // 
            this.Txt_CapacidadVehiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Txt_CapacidadVehiculo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_CapacidadVehiculo.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Txt_CapacidadVehiculo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_CapacidadVehiculo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Txt_CapacidadVehiculo.LineColor = System.Drawing.Color.Gainsboro;
            this.Txt_CapacidadVehiculo.Location = new System.Drawing.Point(26, 500);
            this.Txt_CapacidadVehiculo.Name = "Txt_CapacidadVehiculo";
            this.Txt_CapacidadVehiculo.PasswordChar = '\0';
            this.Txt_CapacidadVehiculo.SelectedText = "";
            this.Txt_CapacidadVehiculo.Size = new System.Drawing.Size(224, 35);
            this.Txt_CapacidadVehiculo.TabIndex = 94;
            // 
            // Txt_Descripcion
            // 
            this.Txt_Descripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Txt_Descripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Descripcion.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Descripcion.ForeColor = System.Drawing.SystemColors.Info;
            this.Txt_Descripcion.Location = new System.Drawing.Point(849, 104);
            this.Txt_Descripcion.Name = "Txt_Descripcion";
            this.Txt_Descripcion.Size = new System.Drawing.Size(448, 88);
            this.Txt_Descripcion.TabIndex = 96;
            this.Txt_Descripcion.Text = "";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label15.Location = new System.Drawing.Point(857, 72);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(183, 18);
            this.label15.TabIndex = 97;
            this.label15.Text = "Descripción del Vehículo:";
            // 
            // gunaButton2
            // 
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton2.ForeColor = System.Drawing.Color.White;
            this.gunaButton2.Image = null;
            this.gunaButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton2.Location = new System.Drawing.Point(1027, 546);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Radius = 10;
            this.gunaButton2.Size = new System.Drawing.Size(140, 45);
            this.gunaButton2.TabIndex = 100;
            this.gunaButton2.Text = "Actualizar";
            this.gunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(1173, 546);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 10;
            this.gunaButton1.Size = new System.Drawing.Size(140, 45);
            this.gunaButton1.TabIndex = 99;
            this.gunaButton1.Text = "Eliminar";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Register_Vehiculo
            // 
            this.Register_Vehiculo.AnimationHoverSpeed = 0.07F;
            this.Register_Vehiculo.AnimationSpeed = 0.03F;
            this.Register_Vehiculo.BackColor = System.Drawing.Color.Transparent;
            this.Register_Vehiculo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Register_Vehiculo.BorderColor = System.Drawing.Color.Black;
            this.Register_Vehiculo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Register_Vehiculo.FocusedColor = System.Drawing.Color.Empty;
            this.Register_Vehiculo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_Vehiculo.ForeColor = System.Drawing.Color.White;
            this.Register_Vehiculo.Image = null;
            this.Register_Vehiculo.ImageSize = new System.Drawing.Size(20, 20);
            this.Register_Vehiculo.Location = new System.Drawing.Point(794, 546);
            this.Register_Vehiculo.Name = "Register_Vehiculo";
            this.Register_Vehiculo.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.Register_Vehiculo.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Register_Vehiculo.OnHoverForeColor = System.Drawing.Color.White;
            this.Register_Vehiculo.OnHoverImage = null;
            this.Register_Vehiculo.OnPressedColor = System.Drawing.Color.Black;
            this.Register_Vehiculo.Radius = 10;
            this.Register_Vehiculo.Size = new System.Drawing.Size(227, 45);
            this.Register_Vehiculo.TabIndex = 98;
            this.Register_Vehiculo.Text = "Registrar";
            this.Register_Vehiculo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Register_Vehiculo.Click += new System.EventHandler(this.Register_Vehiculo_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label16.Location = new System.Drawing.Point(22, 572);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(181, 19);
            this.label16.TabIndex = 101;
            this.label16.Text = "Vehiculos registrados:";
            // 
            // CmbTipoVehiculo
            // 
            this.CmbTipoVehiculo.BackColor = System.Drawing.Color.Transparent;
            this.CmbTipoVehiculo.BaseColor = System.Drawing.Color.White;
            this.CmbTipoVehiculo.BorderColor = System.Drawing.Color.Silver;
            this.CmbTipoVehiculo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbTipoVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipoVehiculo.FocusedColor = System.Drawing.Color.Empty;
            this.CmbTipoVehiculo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbTipoVehiculo.ForeColor = System.Drawing.Color.Black;
            this.CmbTipoVehiculo.FormattingEnabled = true;
            this.CmbTipoVehiculo.Location = new System.Drawing.Point(302, 508);
            this.CmbTipoVehiculo.Name = "CmbTipoVehiculo";
            this.CmbTipoVehiculo.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CmbTipoVehiculo.OnHoverItemForeColor = System.Drawing.Color.White;
            this.CmbTipoVehiculo.Radius = 5;
            this.CmbTipoVehiculo.Size = new System.Drawing.Size(227, 27);
            this.CmbTipoVehiculo.TabIndex = 102;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label17.Location = new System.Drawing.Point(309, 467);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(126, 18);
            this.label17.TabIndex = 103;
            this.label17.Text = "Tipo de Vehículo:";
            // 
            // Registro_Vehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1325, 840);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.CmbTipoVehiculo);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.gunaButton2);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.Register_Vehiculo);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Txt_Descripcion);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Txt_CapacidadVehiculo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Txt_Placa);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Txt_Anio);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Txt_Modelo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Txt_Marca);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Txt_puertas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Txt_ValorUnidad);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Txt_Transmision);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txt_kilometraje);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txt_Capacidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_NumeroChasis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_NumeroMotor);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registro_Vehiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro_Vehiculos";
            this.Load += new System.EventHandler(this.Registro_Vehiculos_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaLineTextBox Txt_NumeroMotor;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaLineTextBox Txt_NumeroChasis;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaLineTextBox Txt_Capacidad;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaLineTextBox Txt_kilometraje;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaLineTextBox Txt_Transmision;
        private System.Windows.Forms.Label label13;
        private Guna.UI.WinForms.GunaDateTimePicker DateTimePicker;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaLineTextBox Txt_ValorUnidad;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaLineTextBox Txt_puertas;
        private System.Windows.Forms.Label label9;
        private Guna.UI.WinForms.GunaLineTextBox Txt_Modelo;
        private System.Windows.Forms.Label label10;
        private Guna.UI.WinForms.GunaLineTextBox Txt_Marca;
        private System.Windows.Forms.Label label11;
        private Guna.UI.WinForms.GunaLineTextBox Txt_Placa;
        private System.Windows.Forms.Label label12;
        private Guna.UI.WinForms.GunaLineTextBox Txt_Anio;
        private System.Windows.Forms.Label label14;
        private Guna.UI.WinForms.GunaLineTextBox Txt_CapacidadVehiculo;
        private System.Windows.Forms.RichTextBox Txt_Descripcion;
        private System.Windows.Forms.Label label15;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaButton Register_Vehiculo;
        private System.Windows.Forms.Label label16;
        private Guna.UI.WinForms.GunaComboBox CmbTipoVehiculo;
        private System.Windows.Forms.Label label17;
    }
}