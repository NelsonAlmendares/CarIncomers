
namespace Vista
{
    partial class ChangePassword
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Pass = new Guna.UI.WinForms.GunaTextBox();
            this.Btn_Cambiar = new Guna.UI.WinForms.GunaButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_ConfPass = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_Exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(891, 44);
            this.panel1.TabIndex = 31;
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(51)))), ((int)(((byte)(52)))));
            this.Btn_Exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Exit.FlatAppearance.BorderSize = 0;
            this.Btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Exit.Image = global::Vista.Properties.Resources.minimizar_signo1;
            this.Btn_Exit.Location = new System.Drawing.Point(844, 0);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(47, 44);
            this.Btn_Exit.TabIndex = 1;
            this.Btn_Exit.UseVisualStyleBackColor = false;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(313, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 18);
            this.label2.TabIndex = 94;
            this.label2.Text = "Ingresa tu nueva contraseña";
            // 
            // Txt_Pass
            // 
            this.Txt_Pass.BackColor = System.Drawing.Color.Transparent;
            this.Txt_Pass.BaseColor = System.Drawing.Color.White;
            this.Txt_Pass.BorderColor = System.Drawing.Color.Silver;
            this.Txt_Pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Pass.FocusedBaseColor = System.Drawing.Color.White;
            this.Txt_Pass.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Txt_Pass.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.Txt_Pass.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Pass.Location = new System.Drawing.Point(255, 176);
            this.Txt_Pass.Name = "Txt_Pass";
            this.Txt_Pass.PasswordChar = '\0';
            this.Txt_Pass.Radius = 5;
            this.Txt_Pass.SelectedText = "";
            this.Txt_Pass.Size = new System.Drawing.Size(313, 36);
            this.Txt_Pass.TabIndex = 93;
            // 
            // Btn_Cambiar
            // 
            this.Btn_Cambiar.AnimationHoverSpeed = 0.07F;
            this.Btn_Cambiar.AnimationSpeed = 0.03F;
            this.Btn_Cambiar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Cambiar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Btn_Cambiar.BorderColor = System.Drawing.Color.Black;
            this.Btn_Cambiar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Btn_Cambiar.FocusedColor = System.Drawing.Color.Empty;
            this.Btn_Cambiar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cambiar.ForeColor = System.Drawing.Color.White;
            this.Btn_Cambiar.Image = null;
            this.Btn_Cambiar.ImageSize = new System.Drawing.Size(20, 20);
            this.Btn_Cambiar.Location = new System.Drawing.Point(655, 384);
            this.Btn_Cambiar.Name = "Btn_Cambiar";
            this.Btn_Cambiar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.Btn_Cambiar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Btn_Cambiar.OnHoverForeColor = System.Drawing.Color.White;
            this.Btn_Cambiar.OnHoverImage = null;
            this.Btn_Cambiar.OnPressedColor = System.Drawing.Color.Black;
            this.Btn_Cambiar.Radius = 10;
            this.Btn_Cambiar.Size = new System.Drawing.Size(191, 45);
            this.Btn_Cambiar.TabIndex = 95;
            this.Btn_Cambiar.Text = "Cambiar";
            this.Btn_Cambiar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Btn_Cambiar.Click += new System.EventHandler(this.Btn_Cambiar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(339, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 18);
            this.label1.TabIndex = 97;
            this.label1.Text = "Confirmar contraseña";
            // 
            // Txt_ConfPass
            // 
            this.Txt_ConfPass.BackColor = System.Drawing.Color.Transparent;
            this.Txt_ConfPass.BaseColor = System.Drawing.Color.White;
            this.Txt_ConfPass.BorderColor = System.Drawing.Color.Silver;
            this.Txt_ConfPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_ConfPass.FocusedBaseColor = System.Drawing.Color.White;
            this.Txt_ConfPass.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Txt_ConfPass.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.Txt_ConfPass.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_ConfPass.Location = new System.Drawing.Point(255, 294);
            this.Txt_ConfPass.Name = "Txt_ConfPass";
            this.Txt_ConfPass.PasswordChar = '\0';
            this.Txt_ConfPass.Radius = 5;
            this.Txt_ConfPass.SelectedText = "";
            this.Txt_ConfPass.Size = new System.Drawing.Size(313, 36);
            this.Txt_ConfPass.TabIndex = 96;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.label3.Location = new System.Drawing.Point(29, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 29);
            this.label3.TabIndex = 98;
            this.label3.Text = "Cambio de Contraseña:";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(891, 476);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_ConfPass);
            this.Controls.Add(this.Btn_Cambiar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_Pass);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePassword";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTextBox Txt_Pass;
        private Guna.UI.WinForms.GunaButton Btn_Cambiar;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox Txt_ConfPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}