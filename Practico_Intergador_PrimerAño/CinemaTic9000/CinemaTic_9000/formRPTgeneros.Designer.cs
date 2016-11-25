namespace CinemaTic_9000_v2
{
    partial class formRPTgeneros
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.GeneroDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetCine = new CinemaTic_9000_v2.DataSetCine();
            ((System.ComponentModel.ISupportInitialize)(this.GeneroDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetCine)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(346, 490);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(88, 23);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "dsGeneros";
            reportDataSource1.Value = this.GeneroDataTableBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CinemaTic_9000_v2.rptGeneros.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(6, 14);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(428, 470);
            this.reportViewer1.TabIndex = 12;
            // 
            // GeneroDataTableBindingSource
            // 
            this.GeneroDataTableBindingSource.DataMember = "GeneroDataTable";
            this.GeneroDataTableBindingSource.DataSource = this.DataSetCine;
            // 
            // DataSetCine
            // 
            this.DataSetCine.DataSetName = "DataSetCine";
            this.DataSetCine.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // formRPTgeneros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 520);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.reportViewer1);
            this.Name = "formRPTgeneros";
            this.Text = "Reporte Generos";
            this.Load += new System.EventHandler(this.formRPTgeneros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GeneroDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetCine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource GeneroDataTableBindingSource;
        private DataSetCine DataSetCine;
    }
}