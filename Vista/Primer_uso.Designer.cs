
namespace Vista
{
    partial class Primer_uso
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Login = new Guna.UI.WinForms.GunaButton();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelLoader = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.gunaProgressBar1 = new Guna.UI.WinForms.GunaProgressBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(746, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 430);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Vista.Properties.Resources.Primer_Uso;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(460, 430);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Vista.Properties.Resources.LogoBlack;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(232, 122);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(140, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 55);
            this.label1.TabIndex = 4;
            this.label1.Text = "Getting Started!";
            // 
            // Btn_Login
            // 
            this.Btn_Login.AnimationHoverSpeed = 0.07F;
            this.Btn_Login.AnimationSpeed = 0.03F;
            this.Btn_Login.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Login.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Btn_Login.BorderColor = System.Drawing.Color.Black;
            this.Btn_Login.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Btn_Login.FocusedColor = System.Drawing.Color.Empty;
            this.Btn_Login.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Login.ForeColor = System.Drawing.Color.White;
            this.Btn_Login.Image = null;
            this.Btn_Login.ImageSize = new System.Drawing.Size(20, 20);
            this.Btn_Login.Location = new System.Drawing.Point(175, 318);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.Btn_Login.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Btn_Login.OnHoverForeColor = System.Drawing.Color.White;
            this.Btn_Login.OnHoverImage = null;
            this.Btn_Login.OnPressedColor = System.Drawing.Color.Black;
            this.Btn_Login.Radius = 10;
            this.Btn_Login.Size = new System.Drawing.Size(292, 49);
            this.Btn_Login.TabIndex = 20;
            this.Btn_Login.Text = "Ir al sistema";
            this.Btn_Login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(530, 494);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "Creando sesión en el Sistema...";
            // 
            // LabelLoader
            // 
            this.LabelLoader.AutoSize = true;
            this.LabelLoader.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLoader.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelLoader.Location = new System.Drawing.Point(1185, 494);
            this.LabelLoader.Name = "LabelLoader";
            this.LabelLoader.Size = new System.Drawing.Size(31, 18);
            this.LabelLoader.TabIndex = 23;
            this.LabelLoader.Text = "0%";
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // gunaProgressBar1
            // 
            this.gunaProgressBar1.BorderColor = System.Drawing.Color.Black;
            this.gunaProgressBar1.ColorStyle = Guna.UI.WinForms.ColorStyle.Default;
            this.gunaProgressBar1.IdleColor = System.Drawing.Color.Gainsboro;
            this.gunaProgressBar1.Location = new System.Drawing.Point(55, 526);
            this.gunaProgressBar1.Name = "gunaProgressBar1";
            this.gunaProgressBar1.ProgressMaxColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaProgressBar1.ProgressMinColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaProgressBar1.Size = new System.Drawing.Size(1178, 23);
            this.gunaProgressBar1.TabIndex = 24;
            // 
            // Primer_uso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(1260, 580);
            this.Controls.Add(this.gunaProgressBar1);
            this.Controls.Add(this.LabelLoader);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_Login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Primer_uso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Primer_uso";
            this.Load += new System.EventHandler(this.Primer_uso_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton Btn_Login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabelLoader;
        private System.Windows.Forms.Timer Timer;
        private Guna.UI.WinForms.GunaProgressBar gunaProgressBar1;
    }
}