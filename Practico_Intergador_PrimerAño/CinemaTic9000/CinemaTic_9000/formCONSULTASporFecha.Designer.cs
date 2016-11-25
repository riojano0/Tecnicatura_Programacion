namespace CinemaTic_9000_v2
{
    partial class formCONSULTASporFecha
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.btnMostrarEmpleados = new System.Windows.Forms.Button();
            this.grdEmpleadosFecha = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmpleadosFecha)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(492, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Hasta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nacidos desde:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Empleados por Fecha de Nacimiento";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.CustomFormat = "dd-mm-yyy";
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(536, 43);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(95, 20);
            this.dtpFechaHasta.TabIndex = 18;
            this.dtpFechaHasta.Value = new System.DateTime(2018, 3, 1, 14, 25, 0, 0);
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.CustomFormat = "dd-mm-yyy";
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(297, 43);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(95, 20);
            this.dtpFechaDesde.TabIndex = 17;
            this.dtpFechaDesde.Value = new System.DateTime(1970, 1, 1, 14, 25, 0, 0);
            // 
            // btnMostrarEmpleados
            // 
            this.btnMostrarEmpleados.Location = new System.Drawing.Point(365, 359);
            this.btnMostrarEmpleados.Name = "btnMostrarEmpleados";
            this.btnMostrarEmpleados.Size = new System.Drawing.Size(75, 23);
            this.btnMostrarEmpleados.TabIndex = 16;
            this.btnMostrarEmpleados.Text = "Mostrar";
            this.btnMostrarEmpleados.UseVisualStyleBackColor = true;
            this.btnMostrarEmpleados.Click += new System.EventHandler(this.btnMostrarEmpleados_Click);
            // 
            // grdEmpleadosFecha
            // 
            this.grdEmpleadosFecha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEmpleadosFecha.Location = new System.Drawing.Point(16, 69);
            this.grdEmpleadosFecha.Name = "grdEmpleadosFecha";
            this.grdEmpleadosFecha.Size = new System.Drawing.Size(825, 284);
            this.grdEmpleadosFecha.TabIndex = 15;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(766, 368);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 22;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // formCONSULTASporFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 403);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.dtpFechaDesde);
            this.Controls.Add(this.btnMostrarEmpleados);
            this.Controls.Add(this.grdEmpleadosFecha);
            this.Name = "formCONSULTASporFecha";
            this.Text = "fromCONSULTASporFecha";
            this.Load += new System.EventHandler(this.formCONSULTASporFecha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdEmpleadosFecha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Button btnMostrarEmpleados;
        private System.Windows.Forms.DataGridView grdEmpleadosFecha;
        private System.Windows.Forms.Button btnSalir;
    }
}