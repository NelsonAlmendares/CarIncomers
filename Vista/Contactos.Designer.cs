
namespace Vista
{
    partial class Contactos
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
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.Register_User = new Guna.UI.WinForms.GunaButton();
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_telefono = new Guna.UI.WinForms.GunaLineTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Apellido = new Guna.UI.WinForms.GunaLineTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Nombre = new Guna.UI.WinForms.GunaLineTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.CmbUser = new Guna.UI.WinForms.GunaComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Email = new Guna.UI.WinForms.GunaLineTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Btn_Actualizar = new Guna.UI.WinForms.GunaButton();
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
            this.label3.Location = new System.Drawing.Point(12, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(458, 29);
            this.label3.TabIndex = 29;
            this.label3.Text = "Registro de contactos de los Usuarios:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_Exit);
            this.panel1.Location = new System.Drawing.Point(1224, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 40);
            this.panel1.TabIndex = 28;
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(51)))), ((int)(((byte)(52)))));
            this.Btn_Exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Exit.FlatAppearance.BorderSize = 0;
            this.Btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Exit.Image = global::Vista.Properties.Resources.minimizar_signo1;
            this.Btn_Exit.Location = new System.Drawing.Point(60, 0);
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
            this.dataGridView.Location = new System.Drawing.Point(12, 514);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(1301, 314);
            this.dataGridView.TabIndex = 69;
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
            this.gunaButton1.Location = new System.Drawing.Point(1173, 444);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 10;
            this.gunaButton1.Size = new System.Drawing.Size(140, 45);
            this.gunaButton1.TabIndex = 71;
            this.gunaButton1.Text = "Eliminar";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.Register_User.Location = new System.Drawing.Point(794, 444);
            this.Register_User.Name = "Register_User";
            this.Register_User.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.Register_User.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Register_User.OnHoverForeColor = System.Drawing.Color.White;
            this.Register_User.OnHoverImage = null;
            this.Register_User.OnPressedColor = System.Drawing.Color.Black;
            this.Register_User.Radius = 10;
            this.Register_User.Size = new System.Drawing.Size(227, 45);
            this.Register_User.TabIndex = 70;
            this.Register_User.Text = "Registrar";
            this.Register_User.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Register_User.Click += new System.EventHandler(this.Register_User_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(30, 470);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(168, 19);
            this.label14.TabIndex = 73;
            this.label14.Text = "Clientes registrados:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(476, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 18);
            this.label5.TabIndex = 79;
            this.label5.Text = "Teléfono:";
            // 
            // Txt_telefono
            // 
            this.Txt_telefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Txt_telefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_telefono.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Txt_telefono.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_telefono.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Txt_telefono.LineColor = System.Drawing.Color.Gainsboro;
            this.Txt_telefono.Location = new System.Drawing.Point(479, 261);
            this.Txt_telefono.Name = "Txt_telefono";
            this.Txt_telefono.PasswordChar = '\0';
            this.Txt_telefono.SelectedText = "";
            this.Txt_telefono.Size = new System.Drawing.Size(393, 35);
            this.Txt_telefono.TabIndex = 78;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(42, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 18);
            this.label1.TabIndex = 77;
            this.label1.Text = "Apellido del Contacto:";
            // 
            // Txt_Apellido
            // 
            this.Txt_Apellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Txt_Apellido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Apellido.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Txt_Apellido.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Apellido.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Txt_Apellido.LineColor = System.Drawing.Color.Gainsboro;
            this.Txt_Apellido.Location = new System.Drawing.Point(34, 261);
            this.Txt_Apellido.Name = "Txt_Apellido";
            this.Txt_Apellido.PasswordChar = '\0';
            this.Txt_Apellido.SelectedText = "";
            this.Txt_Apellido.Size = new System.Drawing.Size(389, 35);
            this.Txt_Apellido.TabIndex = 76;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(487, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 18);
            this.label2.TabIndex = 75;
            this.label2.Text = "Nombre del Contacto:";
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Txt_Nombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Nombre.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Txt_Nombre.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Nombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Txt_Nombre.LineColor = System.Drawing.Color.Gainsboro;
            this.Txt_Nombre.Location = new System.Drawing.Point(479, 122);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.PasswordChar = '\0';
            this.Txt_Nombre.SelectedText = "";
            this.Txt_Nombre.Size = new System.Drawing.Size(389, 35);
            this.Txt_Nombre.TabIndex = 74;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(41, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(153, 18);
            this.label12.TabIndex = 81;
            this.label12.Text = "Agregar contactos a:";
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
            this.CmbUser.Location = new System.Drawing.Point(34, 122);
            this.CmbUser.Name = "CmbUser";
            this.CmbUser.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CmbUser.OnHoverItemForeColor = System.Drawing.Color.White;
            this.CmbUser.Radius = 5;
            this.CmbUser.Size = new System.Drawing.Size(389, 27);
            this.CmbUser.TabIndex = 80;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(917, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 18);
            this.label4.TabIndex = 83;
            this.label4.Text = "Email del Contacto:";
            // 
            // Txt_Email
            // 
            this.Txt_Email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Txt_Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Email.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Txt_Email.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Email.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Txt_Email.LineColor = System.Drawing.Color.Gainsboro;
            this.Txt_Email.Location = new System.Drawing.Point(920, 122);
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.PasswordChar = '\0';
            this.Txt_Email.SelectedText = "";
            this.Txt_Email.Size = new System.Drawing.Size(393, 35);
            this.Txt_Email.TabIndex = 82;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(30, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 19);
            this.label6.TabIndex = 84;
            this.label6.Text = "Recomendaciones:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(194, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(336, 72);
            this.label7.TabIndex = 85;
            this.label7.Text = "Se debe llevar un registro de por lo menos 3\r\nnúmeros de contactos con los cuales" +
    " se pueda \r\nrealizar cualquier tipo de comunicación en \r\ncaso de una emergencia";
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
            this.Btn_Actualizar.Location = new System.Drawing.Point(1027, 444);
            this.Btn_Actualizar.Name = "Btn_Actualizar";
            this.Btn_Actualizar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.Btn_Actualizar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Btn_Actualizar.OnHoverForeColor = System.Drawing.Color.White;
            this.Btn_Actualizar.OnHoverImage = null;
            this.Btn_Actualizar.OnPressedColor = System.Drawing.Color.Black;
            this.Btn_Actualizar.Radius = 10;
            this.Btn_Actualizar.Size = new System.Drawing.Size(140, 45);
            this.Btn_Actualizar.TabIndex = 86;
            this.Btn_Actualizar.Text = "Actualizar";
            this.Btn_Actualizar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Btn_Actualizar.Click += new System.EventHandler(this.Btn_Actualizar_Click);
            // 
            // Contactos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1325, 840);
            this.Controls.Add(this.Btn_Actualizar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txt_Email);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.CmbUser);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txt_telefono);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_Apellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_Nombre);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.Register_User);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Contactos";
            this.Text = "Contactos";
            this.Load += new System.EventHandler(this.Contactos_Load);
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
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaButton Register_User;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaLineTextBox Txt_telefono;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaLineTextBox Txt_Apellido;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaLineTextBox Txt_Nombre;
        private System.Windows.Forms.Label label12;
        private Guna.UI.WinForms.GunaComboBox CmbUser;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaLineTextBox Txt_Email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaButton Btn_Actualizar;
    }
}