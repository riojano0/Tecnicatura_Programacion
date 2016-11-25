namespace CinemaTic_9000_v2
{
    partial class formRPTempleados
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.EmpleadoDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetCine = new CinemaTic_9000_v2.DataSetCine();
            this.lblPelicula = new System.Windows.Forms.Label();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnMostrarTodo = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.EmpleadoDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetCine)).BeginInit();
            this.SuspendLayout();
            // 
            // EmpleadoDataTableBindingSource
            // 
            this.EmpleadoDataTableBindingSource.DataMember = "EmpleadoDataTable";
            this.EmpleadoDataTableBindingSource.DataSource = this.DataSetCine;
            // 
            // DataSetCine
            // 
            this.DataSetCine.DataSetName = "DataSetCine";
            this.DataSetCine.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblPelicula
            // 
            this.lblPelicula.AutoSize = true;
            this.lblPelicula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPelicula.Location = new System.Drawing.Point(329, 17);
            this.lblPelicula.Name = "lblPelicula";
            this.lblPelicula.Size = new System.Drawing.Size(62, 13);
            this.lblPelicula.TabIndex = 17;
            this.lblPelicula.Text = "Empleado";
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(397, 14);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(126, 20);
            this.txtEmpleado.TabIndex = 16;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(560, 517);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(88, 23);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnMostrarTodo
            // 
            this.btnMostrarTodo.Location = new System.Drawing.Point(12, 12);
            this.btnMostrarTodo.Name = "btnMostrarTodo";
            this.btnMostrarTodo.Size = new System.Drawing.Size(88, 23);
            this.btnMostrarTodo.TabIndex = 14;
            this.btnMostrarTodo.Text = "Mostrar todo";
            this.btnMostrarTodo.UseVisualStyleBackColor = true;
            this.btnMostrarTodo.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(529, 12);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(88, 23);
            this.btnFiltrar.TabIndex = 13;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click_1);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "dsEmpleados";
            reportDataSource1.Value = this.EmpleadoDataTableBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CinemaTic_9000_v2.rptEmpleados.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(11, 53);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(646, 445);
            this.reportViewer1.TabIndex = 18;
            // 
            // formRPTempleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 551);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.lblPelicula);
            this.Controls.Add(this.txtEmpleado);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMostrarTodo);
            this.Controls.Add(this.btnFiltrar);
            this.Name = "formRPTempleados";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.formRPTempleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmpleadoDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetCine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPelicula;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnMostrarTodo;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.BindingSource EmpleadoDataTableBindingSource;
        private DataSetCine DataSetCine;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}