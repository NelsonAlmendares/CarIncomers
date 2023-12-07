
namespace Vista
{
    partial class Rentas
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Lbl_renta = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Label = new System.Windows.Forms.Label();
            this.Lbl_Vehiculo = new System.Windows.Forms.Label();
            this.Lbl_Entrega = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Lbl_Estado = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Lbl_precio = new System.Windows.Forms.Label();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaElipsePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.gunaElipsePanel1.Controls.Add(this.gunaButton1);
            this.gunaElipsePanel1.Controls.Add(this.Lbl_precio);
            this.gunaElipsePanel1.Controls.Add(this.label6);
            this.gunaElipsePanel1.Controls.Add(this.Lbl_Estado);
            this.gunaElipsePanel1.Controls.Add(this.label5);
            this.gunaElipsePanel1.Controls.Add(this.Lbl_Entrega);
            this.gunaElipsePanel1.Controls.Add(this.label2);
            this.gunaElipsePanel1.Controls.Add(this.Lbl_renta);
            this.gunaElipsePanel1.Controls.Add(this.label7);
            this.gunaElipsePanel1.Controls.Add(this.Label);
            this.gunaElipsePanel1.Controls.Add(this.Lbl_Vehiculo);
            this.gunaElipsePanel1.Controls.Add(this.label4);
            this.gunaElipsePanel1.Controls.Add(this.pictureBox1);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(3, 3);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Size = new System.Drawing.Size(864, 233);
            this.gunaElipsePanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Vista.Properties.Resources.Car_Sketch;
            this.pictureBox1.Location = new System.Drawing.Point(-34, -34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 334);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(13, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Renta de Vehiculo:";
            // 
            // Lbl_renta
            // 
            this.Lbl_renta.AutoSize = true;
            this.Lbl_renta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_renta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_renta.Location = new System.Drawing.Point(382, 78);
            this.Lbl_renta.Name = "Lbl_renta";
            this.Lbl_renta.Size = new System.Drawing.Size(50, 18);
            this.Lbl_renta.TabIndex = 15;
            this.Lbl_renta.Text = "label2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(273, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "Rentado en:";
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label.Location = new System.Drawing.Point(273, 28);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(135, 19);
            this.Label.TabIndex = 12;
            this.Label.Text = "Marca y modelo:";
            // 
            // Lbl_Vehiculo
            // 
            this.Lbl_Vehiculo.AutoSize = true;
            this.Lbl_Vehiculo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Vehiculo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_Vehiculo.Location = new System.Drawing.Point(414, 29);
            this.Lbl_Vehiculo.Name = "Lbl_Vehiculo";
            this.Lbl_Vehiculo.Size = new System.Drawing.Size(50, 18);
            this.Lbl_Vehiculo.TabIndex = 13;
            this.Lbl_Vehiculo.Text = "label2";
            // 
            // Lbl_Entrega
            // 
            this.Lbl_Entrega.AutoSize = true;
            this.Lbl_Entrega.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Entrega.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_Entrega.Location = new System.Drawing.Point(460, 123);
            this.Lbl_Entrega.Name = "Lbl_Entrega";
            this.Lbl_Entrega.Size = new System.Drawing.Size(50, 18);
            this.Lbl_Entrega.TabIndex = 17;
            this.Lbl_Entrega.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(273, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Entregado la fecha de:";
            // 
            // Lbl_Estado
            // 
            this.Lbl_Estado.AutoSize = true;
            this.Lbl_Estado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Estado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_Estado.Location = new System.Drawing.Point(431, 172);
            this.Lbl_Estado.Name = "Lbl_Estado";
            this.Lbl_Estado.Size = new System.Drawing.Size(50, 18);
            this.Lbl_Estado.TabIndex = 19;
            this.Lbl_Estado.Text = "label2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(273, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 19);
            this.label5.TabIndex = 18;
            this.label5.Text = "Estado de la renta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(590, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 19);
            this.label6.TabIndex = 20;
            this.label6.Text = "Total Cancelado:";
            // 
            // Lbl_precio
            // 
            this.Lbl_precio.AutoSize = true;
            this.Lbl_precio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_precio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_precio.Location = new System.Drawing.Point(734, 172);
            this.Lbl_precio.Name = "Lbl_precio";
            this.Lbl_precio.Size = new System.Drawing.Size(50, 18);
            this.Lbl_precio.TabIndex = 21;
            this.Lbl_precio.Text = "label2";
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = global::Vista.Properties.Resources.credit_card_solid_24;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(594, 77);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 5;
            this.gunaButton1.Size = new System.Drawing.Size(190, 42);
            this.gunaButton1.TabIndex = 22;
            this.gunaButton1.Text = "Ver Factura...";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Rentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.gunaElipsePanel1);
            this.Name = "Rentas";
            this.Size = new System.Drawing.Size(870, 239);
            this.gunaElipsePanel1.ResumeLayout(false);
            this.gunaElipsePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Lbl_renta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label Lbl_Vehiculo;
        private System.Windows.Forms.Label Lbl_Entrega;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lbl_Estado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Lbl_precio;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaButton gunaButton1;
    }
}
