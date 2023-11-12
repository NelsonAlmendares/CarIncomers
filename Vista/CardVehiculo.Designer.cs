
namespace Vista
{
    partial class CardVehiculo
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
            this.Label = new System.Windows.Forms.Label();
            this.Lbl_Vehiculo = new System.Windows.Forms.Label();
            this.Lbl_Tipo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Lbl_Transmicion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.Lbl_hora = new System.Windows.Forms.Label();
            this.Lbl_fecha = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Lbl_anio = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gunaElipsePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label.Location = new System.Drawing.Point(22, 82);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(135, 19);
            this.Label.TabIndex = 0;
            this.Label.Text = "Marca y modelo:";
            // 
            // Lbl_Vehiculo
            // 
            this.Lbl_Vehiculo.AutoSize = true;
            this.Lbl_Vehiculo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Vehiculo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_Vehiculo.Location = new System.Drawing.Point(163, 83);
            this.Lbl_Vehiculo.Name = "Lbl_Vehiculo";
            this.Lbl_Vehiculo.Size = new System.Drawing.Size(50, 18);
            this.Lbl_Vehiculo.TabIndex = 1;
            this.Lbl_Vehiculo.Text = "label2";
            // 
            // Lbl_Tipo
            // 
            this.Lbl_Tipo.AutoSize = true;
            this.Lbl_Tipo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Tipo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_Tipo.Location = new System.Drawing.Point(170, 132);
            this.Lbl_Tipo.Name = "Lbl_Tipo";
            this.Lbl_Tipo.Size = new System.Drawing.Size(50, 18);
            this.Lbl_Tipo.TabIndex = 3;
            this.Lbl_Tipo.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(22, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo de Vehiculo:";
            // 
            // Lbl_Transmicion
            // 
            this.Lbl_Transmicion.AutoSize = true;
            this.Lbl_Transmicion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Transmicion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_Transmicion.Location = new System.Drawing.Point(137, 182);
            this.Lbl_Transmicion.Name = "Lbl_Transmicion";
            this.Lbl_Transmicion.Size = new System.Drawing.Size(50, 18);
            this.Lbl_Transmicion.TabIndex = 5;
            this.Lbl_Transmicion.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(22, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Transmición:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(20, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(297, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Vehiculo en dominio:";
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.gunaElipsePanel1.Controls.Add(this.Lbl_hora);
            this.gunaElipsePanel1.Controls.Add(this.Lbl_fecha);
            this.gunaElipsePanel1.Controls.Add(this.label8);
            this.gunaElipsePanel1.Controls.Add(this.label7);
            this.gunaElipsePanel1.Controls.Add(this.Lbl_anio);
            this.gunaElipsePanel1.Controls.Add(this.label6);
            this.gunaElipsePanel1.Controls.Add(this.label4);
            this.gunaElipsePanel1.Controls.Add(this.Label);
            this.gunaElipsePanel1.Controls.Add(this.Lbl_Transmicion);
            this.gunaElipsePanel1.Controls.Add(this.Lbl_Vehiculo);
            this.gunaElipsePanel1.Controls.Add(this.label3);
            this.gunaElipsePanel1.Controls.Add(this.label2);
            this.gunaElipsePanel1.Controls.Add(this.Lbl_Tipo);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(3, 7);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Size = new System.Drawing.Size(586, 289);
            this.gunaElipsePanel1.TabIndex = 7;
            // 
            // Lbl_hora
            // 
            this.Lbl_hora.AutoSize = true;
            this.Lbl_hora.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_hora.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_hora.Location = new System.Drawing.Point(387, 184);
            this.Lbl_hora.Name = "Lbl_hora";
            this.Lbl_hora.Size = new System.Drawing.Size(50, 18);
            this.Lbl_hora.TabIndex = 12;
            this.Lbl_hora.Text = "label2";
            // 
            // Lbl_fecha
            // 
            this.Lbl_fecha.AutoSize = true;
            this.Lbl_fecha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_fecha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_fecha.Location = new System.Drawing.Point(426, 131);
            this.Lbl_fecha.Name = "Lbl_fecha";
            this.Lbl_fecha.Size = new System.Drawing.Size(50, 18);
            this.Lbl_fecha.TabIndex = 11;
            this.Lbl_fecha.Text = "label2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(277, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 19);
            this.label8.TabIndex = 10;
            this.label8.Text = "A la hora de:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(277, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "Disponible hasta:";
            // 
            // Lbl_anio
            // 
            this.Lbl_anio.AutoSize = true;
            this.Lbl_anio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_anio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_anio.Location = new System.Drawing.Point(171, 236);
            this.Lbl_anio.Name = "Lbl_anio";
            this.Lbl_anio.Size = new System.Drawing.Size(50, 18);
            this.Lbl_anio.TabIndex = 8;
            this.Lbl_anio.Text = "label2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(22, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Año del Vehículo:";
            // 
            // CardVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.gunaElipsePanel1);
            this.Name = "CardVehiculo";
            this.Size = new System.Drawing.Size(595, 299);
            this.Load += new System.EventHandler(this.CardVehiculo_Load);
            this.gunaElipsePanel1.ResumeLayout(false);
            this.gunaElipsePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label Lbl_Vehiculo;
        private System.Windows.Forms.Label Lbl_Tipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lbl_Transmicion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private System.Windows.Forms.Label Lbl_anio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Lbl_hora;
        private System.Windows.Forms.Label Lbl_fecha;
        private System.Windows.Forms.Label label8;
    }
}
