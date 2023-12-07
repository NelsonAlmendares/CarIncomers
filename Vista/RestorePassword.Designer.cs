
namespace Vista
{
    partial class RestorePassword
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
            this.Txt_Buscar = new Guna.UI.WinForms.GunaTextBox();
            this.Btn_Buscar = new Guna.UI.WinForms.GunaButton();
            this.LinkPassword = new System.Windows.Forms.LinkLabel();
            this.Txt_Pin = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnVerificar = new Guna.UI.WinForms.GunaButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_Exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1107, 44);
            this.panel1.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.label3.Location = new System.Drawing.Point(24, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(351, 29);
            this.label3.TabIndex = 31;
            this.label3.Text = "Recuperación de Contraseña:";
            // 
            // Txt_Buscar
            // 
            this.Txt_Buscar.BackColor = System.Drawing.Color.Transparent;
            this.Txt_Buscar.BaseColor = System.Drawing.Color.White;
            this.Txt_Buscar.BorderColor = System.Drawing.Color.Silver;
            this.Txt_Buscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Buscar.FocusedBaseColor = System.Drawing.Color.White;
            this.Txt_Buscar.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Txt_Buscar.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.Txt_Buscar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Buscar.Location = new System.Drawing.Point(202, 144);
            this.Txt_Buscar.Name = "Txt_Buscar";
            this.Txt_Buscar.PasswordChar = '\0';
            this.Txt_Buscar.Radius = 5;
            this.Txt_Buscar.SelectedText = "";
            this.Txt_Buscar.Size = new System.Drawing.Size(665, 34);
            this.Txt_Buscar.TabIndex = 88;
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.AnimationHoverSpeed = 0.07F;
            this.Btn_Buscar.AnimationSpeed = 0.03F;
            this.Btn_Buscar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Buscar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Btn_Buscar.BorderColor = System.Drawing.Color.Black;
            this.Btn_Buscar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Btn_Buscar.FocusedColor = System.Drawing.Color.Empty;
            this.Btn_Buscar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Buscar.ForeColor = System.Drawing.Color.White;
            this.Btn_Buscar.Image = null;
            this.Btn_Buscar.ImageSize = new System.Drawing.Size(20, 20);
            this.Btn_Buscar.Location = new System.Drawing.Point(456, 197);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.Btn_Buscar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Btn_Buscar.OnHoverForeColor = System.Drawing.Color.White;
            this.Btn_Buscar.OnHoverImage = null;
            this.Btn_Buscar.OnPressedColor = System.Drawing.Color.Black;
            this.Btn_Buscar.Radius = 10;
            this.Btn_Buscar.Size = new System.Drawing.Size(143, 41);
            this.Btn_Buscar.TabIndex = 87;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // LinkPassword
            // 
            this.LinkPassword.AutoSize = true;
            this.LinkPassword.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkPassword.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(86)))), ((int)(((byte)(242)))));
            this.LinkPassword.Location = new System.Drawing.Point(453, 254);
            this.LinkPassword.Name = "LinkPassword";
            this.LinkPassword.Size = new System.Drawing.Size(146, 17);
            this.LinkPassword.TabIndex = 90;
            this.LinkPassword.TabStop = true;
            this.LinkPassword.Text = "I forgot my username";
            // 
            // Txt_Pin
            // 
            this.Txt_Pin.BackColor = System.Drawing.Color.Transparent;
            this.Txt_Pin.BaseColor = System.Drawing.Color.White;
            this.Txt_Pin.BorderColor = System.Drawing.Color.Silver;
            this.Txt_Pin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Pin.FocusedBaseColor = System.Drawing.Color.White;
            this.Txt_Pin.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Txt_Pin.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.Txt_Pin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Pin.Location = new System.Drawing.Point(378, 363);
            this.Txt_Pin.Name = "Txt_Pin";
            this.Txt_Pin.PasswordChar = '\0';
            this.Txt_Pin.Radius = 5;
            this.Txt_Pin.SelectedText = "";
            this.Txt_Pin.Size = new System.Drawing.Size(287, 36);
            this.Txt_Pin.TabIndex = 91;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(436, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 18);
            this.label2.TabIndex = 92;
            this.label2.Text = "Ingresa el pin generado:";
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(51)))), ((int)(((byte)(52)))));
            this.Btn_Exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Exit.FlatAppearance.BorderSize = 0;
            this.Btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Exit.Image = global::Vista.Properties.Resources.minimizar_signo1;
            this.Btn_Exit.Location = new System.Drawing.Point(1060, 0);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(47, 44);
            this.Btn_Exit.TabIndex = 1;
            this.Btn_Exit.UseVisualStyleBackColor = false;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(424, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 18);
            this.label4.TabIndex = 93;
            this.label4.Text = "Ingresa tu correo electrónico";
            // 
            // BtnVerificar
            // 
            this.BtnVerificar.AnimationHoverSpeed = 0.07F;
            this.BtnVerificar.AnimationSpeed = 0.03F;
            this.BtnVerificar.BackColor = System.Drawing.Color.Transparent;
            this.BtnVerificar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.BtnVerificar.BorderColor = System.Drawing.Color.Black;
            this.BtnVerificar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnVerificar.FocusedColor = System.Drawing.Color.Empty;
            this.BtnVerificar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVerificar.ForeColor = System.Drawing.Color.Black;
            this.BtnVerificar.Image = null;
            this.BtnVerificar.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnVerificar.Location = new System.Drawing.Point(456, 415);
            this.BtnVerificar.Name = "BtnVerificar";
            this.BtnVerificar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.BtnVerificar.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.BtnVerificar.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnVerificar.OnHoverImage = null;
            this.BtnVerificar.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.BtnVerificar.Radius = 10;
            this.BtnVerificar.Size = new System.Drawing.Size(143, 41);
            this.BtnVerificar.TabIndex = 94;
            this.BtnVerificar.Text = "Verificar";
            this.BtnVerificar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnVerificar.Click += new System.EventHandler(this.BtnVerificar_Click);
            // 
            // RestorePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1107, 505);
            this.Controls.Add(this.BtnVerificar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_Pin);
            this.Controls.Add(this.LinkPassword);
            this.Controls.Add(this.Txt_Buscar);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Symbol", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RestorePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RestorePassword";
            this.Load += new System.EventHandler(this.RestorePassword_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaTextBox Txt_Buscar;
        private Guna.UI.WinForms.GunaButton Btn_Buscar;
        private System.Windows.Forms.LinkLabel LinkPassword;
        private Guna.UI.WinForms.GunaTextBox Txt_Pin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaButton BtnVerificar;
    }
}