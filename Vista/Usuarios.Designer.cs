
namespace Vista
{
    partial class Usuarios
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
            this.label10 = new System.Windows.Forms.Label();
            this.Txt_Documento = new Guna.UI.WinForms.GunaLineTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Usuario = new Guna.UI.WinForms.GunaLineTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Apellido = new Guna.UI.WinForms.GunaLineTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Nombre = new Guna.UI.WinForms.GunaLineTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Txt_licencia = new Guna.UI.WinForms.GunaLineTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_celular = new Guna.UI.WinForms.GunaLineTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_correo = new Guna.UI.WinForms.GunaLineTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_password = new Guna.UI.WinForms.GunaLineTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.DateTimePicker = new Guna.UI.WinForms.GunaDateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.CmbTipoUser = new Guna.UI.WinForms.GunaComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CmbEstadoUser = new Guna.UI.WinForms.GunaComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_edad = new Guna.UI.WinForms.GunaLineTextBox();
            this.Register_User = new Guna.UI.WinForms.GunaButton();
            this.Btn_Eliminar = new Guna.UI.WinForms.GunaButton();
            this.Btn_Actualizar = new Guna.UI.WinForms.GunaButton();
            this.label14 = new System.Windows.Forms.Label();
            this.gunaLineTextBox1 = new Guna.UI.WinForms.GunaLineTextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.Txt_telefono = new Guna.UI.WinForms.GunaLineTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_Exit);
            this.panel1.Location = new System.Drawing.Point(1648, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(119, 49);
            this.panel1.TabIndex = 3;
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(51)))), ((int)(((byte)(52)))));
            this.Btn_Exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Exit.FlatAppearance.BorderSize = 0;
            this.Btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Exit.Image = global::Vista.Properties.Resources.minimizar_signo1;
            this.Btn_Exit.Location = new System.Drawing.Point(66, 0);
            this.Btn_Exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(53, 49);
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
            this.label3.Location = new System.Drawing.Point(16, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(327, 35);
            this.label3.TabIndex = 27;
            this.label3.Text = "Registro de Usuarios:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(25, 539);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 23);
            this.label10.TabIndex = 46;
            this.label10.Text = "DUI del Usuario";
            // 
            // Txt_Documento
            // 
            this.Txt_Documento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Txt_Documento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Documento.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Txt_Documento.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Documento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Txt_Documento.LineColor = System.Drawing.Color.Gainsboro;
            this.Txt_Documento.Location = new System.Drawing.Point(16, 577);
            this.Txt_Documento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_Documento.Name = "Txt_Documento";
            this.Txt_Documento.PasswordChar = '\0';
            this.Txt_Documento.SelectedText = "";
            this.Txt_Documento.Size = new System.Drawing.Size(240, 43);
            this.Txt_Documento.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(25, 384);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 23);
            this.label4.TabIndex = 44;
            this.label4.Text = "Usuario del Ususario:";
            // 
            // Txt_Usuario
            // 
            this.Txt_Usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Txt_Usuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Usuario.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Txt_Usuario.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Usuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Txt_Usuario.LineColor = System.Drawing.Color.Gainsboro;
            this.Txt_Usuario.Location = new System.Drawing.Point(16, 422);
            this.Txt_Usuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_Usuario.Name = "Txt_Usuario";
            this.Txt_Usuario.PasswordChar = '\0';
            this.Txt_Usuario.SelectedText = "";
            this.Txt_Usuario.Size = new System.Drawing.Size(524, 43);
            this.Txt_Usuario.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(27, 229);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 23);
            this.label1.TabIndex = 42;
            this.label1.Text = "Apellido:";
            // 
            // Txt_Apellido
            // 
            this.Txt_Apellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Txt_Apellido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Apellido.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Txt_Apellido.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Apellido.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Txt_Apellido.LineColor = System.Drawing.Color.Gainsboro;
            this.Txt_Apellido.Location = new System.Drawing.Point(16, 268);
            this.Txt_Apellido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_Apellido.Name = "Txt_Apellido";
            this.Txt_Apellido.PasswordChar = '\0';
            this.Txt_Apellido.SelectedText = "";
            this.Txt_Apellido.Size = new System.Drawing.Size(524, 43);
            this.Txt_Apellido.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(27, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 40;
            this.label2.Text = "Nombre:";
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Txt_Nombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Nombre.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Txt_Nombre.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Nombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Txt_Nombre.LineColor = System.Drawing.Color.Gainsboro;
            this.Txt_Nombre.Location = new System.Drawing.Point(16, 134);
            this.Txt_Nombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.PasswordChar = '\0';
            this.Txt_Nombre.SelectedText = "";
            this.Txt_Nombre.Size = new System.Drawing.Size(524, 43);
            this.Txt_Nombre.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(644, 539);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(198, 23);
            this.label9.TabIndex = 54;
            this.label9.Text = "Licencia de Conducir:";
            // 
            // Txt_licencia
            // 
            this.Txt_licencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Txt_licencia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_licencia.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Txt_licencia.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_licencia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Txt_licencia.LineColor = System.Drawing.Color.Gainsboro;
            this.Txt_licencia.Location = new System.Drawing.Point(648, 577);
            this.Txt_licencia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_licencia.Name = "Txt_licencia";
            this.Txt_licencia.PasswordChar = '\0';
            this.Txt_licencia.SelectedText = "";
            this.Txt_licencia.Size = new System.Drawing.Size(524, 43);
            this.Txt_licencia.TabIndex = 53;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(644, 384);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 23);
            this.label8.TabIndex = 52;
            this.label8.Text = "Celular del Usuario:";
            // 
            // Txt_celular
            // 
            this.Txt_celular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Txt_celular.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_celular.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Txt_celular.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_celular.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Txt_celular.LineColor = System.Drawing.Color.Gainsboro;
            this.Txt_celular.Location = new System.Drawing.Point(648, 422);
            this.Txt_celular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_celular.Name = "Txt_celular";
            this.Txt_celular.PasswordChar = '\0';
            this.Txt_celular.SelectedText = "";
            this.Txt_celular.Size = new System.Drawing.Size(524, 43);
            this.Txt_celular.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(644, 229);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(226, 29);
            this.label7.TabIndex = 50;
            this.label7.Text = "Correo del Usuario:";
            // 
            // Txt_correo
            // 
            this.Txt_correo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Txt_correo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_correo.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Txt_correo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_correo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Txt_correo.LineColor = System.Drawing.Color.Gainsboro;
            this.Txt_correo.Location = new System.Drawing.Point(648, 268);
            this.Txt_correo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_correo.Name = "Txt_correo";
            this.Txt_correo.PasswordChar = '\0';
            this.Txt_correo.SelectedText = "";
            this.Txt_correo.Size = new System.Drawing.Size(524, 43);
            this.Txt_correo.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(644, 96);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 23);
            this.label5.TabIndex = 48;
            this.label5.Text = "Contraseña:";
            // 
            // Txt_password
            // 
            this.Txt_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Txt_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_password.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Txt_password.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_password.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Txt_password.LineColor = System.Drawing.Color.Gainsboro;
            this.Txt_password.Location = new System.Drawing.Point(648, 134);
            this.Txt_password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_password.Name = "Txt_password";
            this.Txt_password.PasswordChar = '\0';
            this.Txt_password.SelectedText = "";
            this.Txt_password.Size = new System.Drawing.Size(524, 43);
            this.Txt_password.TabIndex = 47;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(1303, 229);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(335, 23);
            this.label13.TabIndex = 62;
            this.label13.Text = "Fecha de Vencimiento de la Licencia:";
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
            this.DateTimePicker.Location = new System.Drawing.Point(1293, 274);
            this.DateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.OnHoverBaseColor = System.Drawing.Color.White;
            this.DateTimePicker.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DateTimePicker.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DateTimePicker.OnPressedColor = System.Drawing.Color.Black;
            this.DateTimePicker.Radius = 5;
            this.DateTimePicker.Size = new System.Drawing.Size(455, 37);
            this.DateTimePicker.TabIndex = 61;
            this.DateTimePicker.Text = "2023-10-28";
            this.DateTimePicker.Value = new System.DateTime(2023, 10, 28, 21, 17, 7, 778);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(1303, 384);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(153, 23);
            this.label12.TabIndex = 60;
            this.label12.Text = "Tipo de Usuario:";
            // 
            // CmbTipoUser
            // 
            this.CmbTipoUser.BackColor = System.Drawing.Color.Transparent;
            this.CmbTipoUser.BaseColor = System.Drawing.Color.White;
            this.CmbTipoUser.BorderColor = System.Drawing.Color.Silver;
            this.CmbTipoUser.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbTipoUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipoUser.FocusedColor = System.Drawing.Color.Empty;
            this.CmbTipoUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbTipoUser.ForeColor = System.Drawing.Color.Black;
            this.CmbTipoUser.FormattingEnabled = true;
            this.CmbTipoUser.Location = new System.Drawing.Point(1293, 432);
            this.CmbTipoUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmbTipoUser.Name = "CmbTipoUser";
            this.CmbTipoUser.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CmbTipoUser.OnHoverItemForeColor = System.Drawing.Color.White;
            this.CmbTipoUser.Radius = 5;
            this.CmbTipoUser.Size = new System.Drawing.Size(453, 31);
            this.CmbTipoUser.TabIndex = 59;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(1303, 539);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(222, 23);
            this.label11.TabIndex = 58;
            this.label11.Text = "Estado de este Usuario:";
            // 
            // CmbEstadoUser
            // 
            this.CmbEstadoUser.BackColor = System.Drawing.Color.Transparent;
            this.CmbEstadoUser.BaseColor = System.Drawing.Color.White;
            this.CmbEstadoUser.BorderColor = System.Drawing.Color.Silver;
            this.CmbEstadoUser.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbEstadoUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEstadoUser.FocusedColor = System.Drawing.Color.Empty;
            this.CmbEstadoUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbEstadoUser.ForeColor = System.Drawing.Color.Black;
            this.CmbEstadoUser.FormattingEnabled = true;
            this.CmbEstadoUser.Location = new System.Drawing.Point(1293, 587);
            this.CmbEstadoUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmbEstadoUser.Name = "CmbEstadoUser";
            this.CmbEstadoUser.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CmbEstadoUser.OnHoverItemForeColor = System.Drawing.Color.White;
            this.CmbEstadoUser.Radius = 5;
            this.CmbEstadoUser.Size = new System.Drawing.Size(453, 31);
            this.CmbEstadoUser.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(1303, 96);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 23);
            this.label6.TabIndex = 56;
            this.label6.Text = "Mi edad es:";
            // 
            // Txt_edad
            // 
            this.Txt_edad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Txt_edad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_edad.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Txt_edad.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_edad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Txt_edad.LineColor = System.Drawing.Color.Gainsboro;
            this.Txt_edad.Location = new System.Drawing.Point(1293, 134);
            this.Txt_edad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_edad.Name = "Txt_edad";
            this.Txt_edad.PasswordChar = '\0';
            this.Txt_edad.SelectedText = "";
            this.Txt_edad.Size = new System.Drawing.Size(215, 43);
            this.Txt_edad.TabIndex = 55;
            // 
            // Register_User
            // 
            this.Register_User.AnimationHoverSpeed = 0.07F;
            this.Register_User.AnimationSpeed = 0.03F;
            this.Register_User.BackColor = System.Drawing.Color.Transparent;
            this.Register_User.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Register_User.BorderColor = System.Drawing.Color.Black;
            this.Register_User.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Register_User.FocusedColor = System.Drawing.Color.Empty;
            this.Register_User.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_User.ForeColor = System.Drawing.Color.White;
            this.Register_User.Image = null;
            this.Register_User.ImageSize = new System.Drawing.Size(20, 20);
            this.Register_User.Location = new System.Drawing.Point(1059, 663);
            this.Register_User.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Register_User.Name = "Register_User";
            this.Register_User.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.Register_User.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Register_User.OnHoverForeColor = System.Drawing.Color.White;
            this.Register_User.OnHoverImage = null;
            this.Register_User.OnPressedColor = System.Drawing.Color.Black;
            this.Register_User.Radius = 10;
            this.Register_User.Size = new System.Drawing.Size(303, 55);
            this.Register_User.TabIndex = 63;
            this.Register_User.Text = "Registrar";
            this.Register_User.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Register_User.Click += new System.EventHandler(this.Register_User_Click);
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
            this.Btn_Eliminar.Location = new System.Drawing.Point(1564, 663);
            this.Btn_Eliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.Btn_Eliminar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Btn_Eliminar.OnHoverForeColor = System.Drawing.Color.White;
            this.Btn_Eliminar.OnHoverImage = null;
            this.Btn_Eliminar.OnPressedColor = System.Drawing.Color.Black;
            this.Btn_Eliminar.Radius = 10;
            this.Btn_Eliminar.Size = new System.Drawing.Size(187, 55);
            this.Btn_Eliminar.TabIndex = 64;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Btn_Actualizar
            // 
            this.Btn_Actualizar.AnimationHoverSpeed = 0.07F;
            this.Btn_Actualizar.AnimationSpeed = 0.03F;
            this.Btn_Actualizar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Actualizar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Btn_Actualizar.BorderColor = System.Drawing.Color.Black;
            this.Btn_Actualizar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Btn_Actualizar.FocusedColor = System.Drawing.Color.Empty;
            this.Btn_Actualizar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Actualizar.ForeColor = System.Drawing.Color.White;
            this.Btn_Actualizar.Image = null;
            this.Btn_Actualizar.ImageSize = new System.Drawing.Size(20, 20);
            this.Btn_Actualizar.Location = new System.Drawing.Point(1369, 663);
            this.Btn_Actualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Actualizar.Name = "Btn_Actualizar";
            this.Btn_Actualizar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.Btn_Actualizar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Btn_Actualizar.OnHoverForeColor = System.Drawing.Color.White;
            this.Btn_Actualizar.OnHoverImage = null;
            this.Btn_Actualizar.OnPressedColor = System.Drawing.Color.Black;
            this.Btn_Actualizar.Radius = 10;
            this.Btn_Actualizar.Size = new System.Drawing.Size(187, 55);
            this.Btn_Actualizar.TabIndex = 65;
            this.Btn_Actualizar.Text = "Actualizar";
            this.Btn_Actualizar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Btn_Actualizar.Click += new System.EventHandler(this.Btn_Actualizar_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(25, 695);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(207, 24);
            this.label14.TabIndex = 66;
            this.label14.Text = "Clientes registrados:";
            // 
            // gunaLineTextBox1
            // 
            this.gunaLineTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.gunaLineTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaLineTextBox1.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaLineTextBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLineTextBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gunaLineTextBox1.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaLineTextBox1.Location = new System.Drawing.Point(1648, 134);
            this.gunaLineTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gunaLineTextBox1.Name = "gunaLineTextBox1";
            this.gunaLineTextBox1.PasswordChar = '\0';
            this.gunaLineTextBox1.SelectedText = "";
            this.gunaLineTextBox1.Size = new System.Drawing.Size(100, 43);
            this.gunaLineTextBox1.TabIndex = 67;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(16, 745);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.Size = new System.Drawing.Size(1735, 274);
            this.dataGridView.TabIndex = 68;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label15.Location = new System.Drawing.Point(297, 538);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(194, 23);
            this.label15.TabIndex = 70;
            this.label15.Text = "Teléfono del Usuario:";
            // 
            // Txt_telefono
            // 
            this.Txt_telefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Txt_telefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_telefono.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Txt_telefono.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_telefono.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Txt_telefono.LineColor = System.Drawing.Color.Gainsboro;
            this.Txt_telefono.Location = new System.Drawing.Point(301, 577);
            this.Txt_telefono.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_telefono.Name = "Txt_telefono";
            this.Txt_telefono.PasswordChar = '\0';
            this.Txt_telefono.SelectedText = "";
            this.Txt_telefono.Size = new System.Drawing.Size(239, 43);
            this.Txt_telefono.TabIndex = 69;
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1767, 1034);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Txt_telefono);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.gunaLineTextBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Btn_Actualizar);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Register_User);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.CmbTipoUser);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.CmbEstadoUser);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Txt_edad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Txt_licencia);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Txt_celular);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Txt_correo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txt_password);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Txt_Documento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txt_Usuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_Apellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_Nombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private Guna.UI.WinForms.GunaLineTextBox Txt_Documento;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaLineTextBox Txt_Usuario;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaLineTextBox Txt_Apellido;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaLineTextBox Txt_Nombre;
        private System.Windows.Forms.Label label9;
        private Guna.UI.WinForms.GunaLineTextBox Txt_licencia;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaLineTextBox Txt_celular;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaLineTextBox Txt_correo;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaLineTextBox Txt_password;
        private System.Windows.Forms.Label label13;
        private Guna.UI.WinForms.GunaDateTimePicker DateTimePicker;
        private System.Windows.Forms.Label label12;
        private Guna.UI.WinForms.GunaComboBox CmbTipoUser;
        private System.Windows.Forms.Label label11;
        private Guna.UI.WinForms.GunaComboBox CmbEstadoUser;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaLineTextBox Txt_edad;
        private Guna.UI.WinForms.GunaButton Register_User;
        private Guna.UI.WinForms.GunaButton Btn_Eliminar;
        private Guna.UI.WinForms.GunaButton Btn_Actualizar;
        private System.Windows.Forms.Label label14;
        private Guna.UI.WinForms.GunaLineTextBox gunaLineTextBox1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label15;
        private Guna.UI.WinForms.GunaLineTextBox Txt_telefono;
    }
}