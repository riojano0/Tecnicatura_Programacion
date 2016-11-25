namespace CinemaTic_9000_v2
{
    partial class formRPTpeliculas
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cboxClasificaciones = new System.Windows.Forms.ComboBox();
            this.DataSetCine = new CinemaTic_9000_v2.DataSetCine();
            this.PeliculaDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetCine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeliculaDataTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetPe";
            reportDataSource1.Value = this.PeliculaDataTableBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CinemaTic_9000_v2.rptPeliculas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 54);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(605, 466);
            this.reportViewer1.TabIndex = 0;
            // 
            // cboxClasificaciones
            // 
            this.cboxClasificaciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxClasificaciones.FormattingEnabled = true;
            this.cboxClasificaciones.Location = new System.Drawing.Point(386, 27);
            this.cboxClasificaciones.Name = "cboxClasificaciones";
            this.cboxClasificaciones.Size = new System.Drawing.Size(121, 21);
            this.cboxClasificaciones.TabIndex = 1;
            // 
            // DataSetCine
            // 
            this.DataSetCine.DataSetName = "DataSetCine";
            this.DataSetCine.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PeliculaDataTableBindingSource
            // 
            this.PeliculaDataTableBindingSource.DataMember = "PeliculaDataTable";
            this.PeliculaDataTableBindingSource.DataSource = this.DataSetCine;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(529, 25);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(88, 23);
            this.btnFiltrar.TabIndex = 2;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Mostrar todo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(529, 530);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(88, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // formRPTpeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 565);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.cboxClasificaciones);
            this.Controls.Add(this.reportViewer1);
            this.Name = "formRPTpeliculas";
            this.Text = "formRPTpeliculas";
            this.Load += new System.EventHandler(this.formRPTpeliculas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetCine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeliculaDataTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ComboBox cboxClasificaciones;
        private System.Windows.Forms.BindingSource PeliculaDataTableBindingSource;
        private DataSetCine DataSetCine;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSalir;
    }
}