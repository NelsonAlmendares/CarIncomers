
namespace Vista
{
    partial class Reingreso
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
            this.Btn_Eliminar = new Guna.UI.WinForms.GunaButton();
            this.Btn_Reingreso = new Guna.UI.WinForms.GunaButton();
            this.label12 = new System.Windows.Forms.Label();
            this.Txt_Reingreso = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaGroupBox2 = new Guna.UI.WinForms.GunaGroupBox();
            this.DatePickerIngreso = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.datePickerLlegada = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Detalles = new System.Windows.Forms.RichTextBox();
            this.ComboBox = new Guna.UI.WinForms.GunaComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.gunaGroupBox2.SuspendLayout();
            this.gunaGroupBox1.SuspendLayout();
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
            this.label3.Size = new System.Drawing.Size(279, 29);
            this.label3.TabIndex = 30;
            this.label3.Text = "Reingreso de Vehículo:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_Exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1325, 40);
            this.panel1.TabIndex = 29;
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
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 561);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(1301, 267);
            this.dataGridView.TabIndex = 71;
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
            this.Btn_Eliminar.Location = new System.Drawing.Point(1170, 496);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.Btn_Eliminar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Btn_Eliminar.OnHoverForeColor = System.Drawing.Color.White;
            this.Btn_Eliminar.OnHoverImage = null;
            this.Btn_Eliminar.OnPressedColor = System.Drawing.Color.Black;
            this.Btn_Eliminar.Radius = 10;
            this.Btn_Eliminar.Size = new System.Drawing.Size(140, 45);
            this.Btn_Eliminar.TabIndex = 81;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Btn_Reingreso
            // 
            this.Btn_Reingreso.AnimationHoverSpeed = 0.07F;
            this.Btn_Reingreso.AnimationSpeed = 0.03F;
            this.Btn_Reingreso.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Reingreso.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Btn_Reingreso.BorderColor = System.Drawing.Color.Black;
            this.Btn_Reingreso.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Btn_Reingreso.FocusedColor = System.Drawing.Color.Empty;
            this.Btn_Reingreso.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Reingreso.ForeColor = System.Drawing.Color.White;
            this.Btn_Reingreso.Image = null;
            this.Btn_Reingreso.ImageSize = new System.Drawing.Size(20, 20);
            this.Btn_Reingreso.Location = new System.Drawing.Point(937, 496);
            this.Btn_Reingreso.Name = "Btn_Reingreso";
            this.Btn_Reingreso.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.Btn_Reingreso.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Btn_Reingreso.OnHoverForeColor = System.Drawing.Color.White;
            this.Btn_Reingreso.OnHoverImage = null;
            this.Btn_Reingreso.OnPressedColor = System.Drawing.Color.Black;
            this.Btn_Reingreso.Radius = 10;
            this.Btn_Reingreso.Size = new System.Drawing.Size(227, 45);
            this.Btn_Reingreso.TabIndex = 80;
            this.Btn_Reingreso.Text = "Registrar";
            this.Btn_Reingreso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Btn_Reingreso.Click += new System.EventHandler(this.Btn_Reingreso_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(24, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(239, 18);
            this.label12.TabIndex = 84;
            this.label12.Text = "Número de factura del solicitante:";
            // 
            // Txt_Reingreso
            // 
            this.Txt_Reingreso.BackColor = System.Drawing.Color.Transparent;
            this.Txt_Reingreso.BaseColor = System.Drawing.Color.White;
            this.Txt_Reingreso.BorderColor = System.Drawing.Color.Silver;
            this.Txt_Reingreso.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Reingreso.FocusedBaseColor = System.Drawing.Color.White;
            this.Txt_Reingreso.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Txt_Reingreso.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.Txt_Reingreso.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Txt_Reingreso.Location = new System.Drawing.Point(17, 231);
            this.Txt_Reingreso.Name = "Txt_Reingreso";
            this.Txt_Reingreso.PasswordChar = '\0';
            this.Txt_Reingreso.Radius = 5;
            this.Txt_Reingreso.SelectedText = "";
            this.Txt_Reingreso.Size = new System.Drawing.Size(246, 30);
            this.Txt_Reingreso.TabIndex = 85;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(24, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 18);
            this.label1.TabIndex = 86;
            this.label1.Text = "Kilometraje de reingreso";
            // 
            // gunaGroupBox2
            // 
            this.gunaGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.gunaGroupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.gunaGroupBox2.Controls.Add(this.DatePickerIngreso);
            this.gunaGroupBox2.Controls.Add(this.label7);
            this.gunaGroupBox2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaGroupBox2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.gunaGroupBox2.Location = new System.Drawing.Point(877, 119);
            this.gunaGroupBox2.Name = "gunaGroupBox2";
            this.gunaGroupBox2.Radius = 5;
            this.gunaGroupBox2.Size = new System.Drawing.Size(433, 176);
            this.gunaGroupBox2.TabIndex = 87;
            this.gunaGroupBox2.Text = "Fecha de Reingreso";
            this.gunaGroupBox2.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // DatePickerIngreso
            // 
            this.DatePickerIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePickerIngreso.Location = new System.Drawing.Point(42, 99);
            this.DatePickerIngreso.MaxDate = new System.DateTime(2026, 12, 31, 0, 0, 0, 0);
            this.DatePickerIngreso.MinDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.DatePickerIngreso.Name = "DatePickerIngreso";
            this.DatePickerIngreso.Size = new System.Drawing.Size(338, 25);
            this.DatePickerIngreso.TabIndex = 82;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(39, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 18);
            this.label7.TabIndex = 79;
            this.label7.Text = "Fecha de reingreso:";
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.gunaGroupBox1.Controls.Add(this.datePickerLlegada);
            this.gunaGroupBox1.Controls.Add(this.label4);
            this.gunaGroupBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaGroupBox1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.gunaGroupBox1.Location = new System.Drawing.Point(433, 119);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Radius = 5;
            this.gunaGroupBox1.Size = new System.Drawing.Size(429, 176);
            this.gunaGroupBox1.TabIndex = 88;
            this.gunaGroupBox1.Text = "Hora de Reingreso";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // datePickerLlegada
            // 
            this.datePickerLlegada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.datePickerLlegada.Location = new System.Drawing.Point(37, 99);
            this.datePickerLlegada.Name = "datePickerLlegada";
            this.datePickerLlegada.Size = new System.Drawing.Size(349, 25);
            this.datePickerLlegada.TabIndex = 80;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(34, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 18);
            this.label4.TabIndex = 77;
            this.label4.Text = "Hora ingresado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(24, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 18);
            this.label2.TabIndex = 90;
            this.label2.Text = "Detalles de reingreso";
            // 
            // Txt_Detalles
            // 
            this.Txt_Detalles.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Detalles.Location = new System.Drawing.Point(17, 353);
            this.Txt_Detalles.Name = "Txt_Detalles";
            this.Txt_Detalles.Size = new System.Drawing.Size(390, 96);
            this.Txt_Detalles.TabIndex = 91;
            this.Txt_Detalles.Text = "";
            // 
            // ComboBox
            // 
            this.ComboBox.BackColor = System.Drawing.Color.Transparent;
            this.ComboBox.BaseColor = System.Drawing.Color.White;
            this.ComboBox.BorderColor = System.Drawing.Color.Silver;
            this.ComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.ComboBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox.ForeColor = System.Drawing.Color.Black;
            this.ComboBox.FormattingEnabled = true;
            this.ComboBox.Location = new System.Drawing.Point(17, 119);
            this.ComboBox.Name = "ComboBox";
            this.ComboBox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ComboBox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.ComboBox.Radius = 5;
            this.ComboBox.Size = new System.Drawing.Size(390, 26);
            this.ComboBox.TabIndex = 92;
            // 
            // Reingreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1325, 840);
            this.Controls.Add(this.ComboBox);
            this.Controls.Add(this.Txt_Detalles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.gunaGroupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_Reingreso);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Reingreso);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reingreso";
            this.Text = "s";
            this.Load += new System.EventHandler(this.Reingreso_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.gunaGroupBox2.ResumeLayout(false);
            this.gunaGroupBox2.PerformLayout();
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.DataGridView dataGridView;
        private Guna.UI.WinForms.GunaButton Btn_Eliminar;
        private Guna.UI.WinForms.GunaButton Btn_Reingreso;
        private System.Windows.Forms.Label label12;
        private Guna.UI.WinForms.GunaTextBox Txt_Reingreso;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox2;
        private System.Windows.Forms.DateTimePicker DatePickerIngreso;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private System.Windows.Forms.DateTimePicker datePickerLlegada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox Txt_Detalles;
        private Guna.UI.WinForms.GunaComboBox ComboBox;
    }
}