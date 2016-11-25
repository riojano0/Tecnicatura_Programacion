namespace CinemaTic_9000_v2
{
    partial class formRPTfunciones
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnMostrarTodo = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.FuncionDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetCine = new CinemaTic_9000_v2.DataSetCine();
            this.txtPelicula = new System.Windows.Forms.TextBox();
            this.lblPelicula = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FuncionDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetCine)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(529, 510);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(88, 23);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnMostrarTodo
            // 
            this.btnMostrarTodo.Location = new System.Drawing.Point(12, 5);
            this.btnMostrarTodo.Name = "btnMostrarTodo";
            this.btnMostrarTodo.Size = new System.Drawing.Size(88, 23);
            this.btnMostrarTodo.TabIndex = 8;
            this.btnMostrarTodo.Text = "Mostrar todo";
            this.btnMostrarTodo.UseVisualStyleBackColor = true;
            this.btnMostrarTodo.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(529, 5);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(88, 23);
            this.btnFiltrar.TabIndex = 7;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click_1);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "dsFunciones";
            reportDataSource1.Value = this.FuncionDataTableBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CinemaTic_9000_v2.rptFunciones.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 34);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(636, 470);
            this.reportViewer1.TabIndex = 5;
            // 
            // FuncionDataTableBindingSource
            // 
            this.FuncionDataTableBindingSource.DataMember = "FuncionDataTable";
            this.FuncionDataTableBindingSource.DataSource = this.DataSetCine;
            // 
            // DataSetCine
            // 
            this.DataSetCine.DataSetName = "DataSetCine";
            this.DataSetCine.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtPelicula
            // 
            this.txtPelicula.Location = new System.Drawing.Point(397, 7);
            this.txtPelicula.Name = "txtPelicula";
            this.txtPelicula.Size = new System.Drawing.Size(126, 20);
            this.txtPelicula.TabIndex = 10;
            // 
            // lblPelicula
            // 
            this.lblPelicula.AutoSize = true;
            this.lblPelicula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPelicula.Location = new System.Drawing.Point(341, 9);
            this.lblPelicula.Name = "lblPelicula";
            this.lblPelicula.Size = new System.Drawing.Size(52, 13);
            this.lblPelicula.TabIndex = 11;
            this.lblPelicula.Text = "Pelicula";
            // 
            // formRPTfunciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 540);
            this.Controls.Add(this.lblPelicula);
            this.Controls.Add(this.txtPelicula);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMostrarTodo);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.reportViewer1);
            this.Name = "formRPTfunciones";
            this.Text = "Funciones";
            this.Load += new System.EventHandler(this.formRPTfunciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FuncionDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetCine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnMostrarTodo;
        private System.Windows.Forms.Button btnFiltrar;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource FuncionDataTableBindingSource;
        private DataSetCine DataSetCine;
        private System.Windows.Forms.TextBox txtPelicula;
        private System.Windows.Forms.Label lblPelicula;
    }
}