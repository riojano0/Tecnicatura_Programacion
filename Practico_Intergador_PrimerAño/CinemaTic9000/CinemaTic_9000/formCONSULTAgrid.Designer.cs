namespace CinemaTic_9000_v2
{
    partial class formCONSULTAgrid
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
            this.cboxCampo1 = new System.Windows.Forms.ComboBox();
            this.lblCampo1 = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.cboxTablas = new System.Windows.Forms.ComboBox();
            this.btnMostrarTabla = new System.Windows.Forms.Button();
            this.grdConsulta1 = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdConsulta1)).BeginInit();
            this.SuspendLayout();
            // 
            // cboxCampo1
            // 
            this.cboxCampo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCampo1.FormattingEnabled = true;
            this.cboxCampo1.Location = new System.Drawing.Point(294, 77);
            this.cboxCampo1.Name = "cboxCampo1";
            this.cboxCampo1.Size = new System.Drawing.Size(103, 21);
            this.cboxCampo1.TabIndex = 16;
            // 
            // lblCampo1
            // 
            this.lblCampo1.AutoSize = true;
            this.lblCampo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampo1.Location = new System.Drawing.Point(291, 61);
            this.lblCampo1.Name = "lblCampo1";
            this.lblCampo1.Size = new System.Drawing.Size(55, 13);
            this.lblCampo1.TabIndex = 14;
            this.lblCampo1.Text = "Columna";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(420, 77);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(158, 21);
            this.btnFiltrar.TabIndex = 12;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // cboxTablas
            // 
            this.cboxTablas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTablas.FormattingEnabled = true;
            this.cboxTablas.Location = new System.Drawing.Point(12, 30);
            this.cboxTablas.Name = "cboxTablas";
            this.cboxTablas.Size = new System.Drawing.Size(120, 21);
            this.cboxTablas.TabIndex = 11;
            this.cboxTablas.SelectedIndexChanged += new System.EventHandler(this.cboxTablas_SelectedIndexChanged);
            // 
            // btnMostrarTabla
            // 
            this.btnMostrarTabla.Location = new System.Drawing.Point(346, 449);
            this.btnMostrarTabla.Margin = new System.Windows.Forms.Padding(2);
            this.btnMostrarTabla.Name = "btnMostrarTabla";
            this.btnMostrarTabla.Size = new System.Drawing.Size(128, 42);
            this.btnMostrarTabla.TabIndex = 10;
            this.btnMostrarTabla.Text = "Mostrar Tabla";
            this.btnMostrarTabla.UseVisualStyleBackColor = true;
            this.btnMostrarTabla.Click += new System.EventHandler(this.button1_Click);
            // 
            // grdConsulta1
            // 
            this.grdConsulta1.AllowUserToAddRows = false;
            this.grdConsulta1.AllowUserToDeleteRows = false;
            this.grdConsulta1.AllowUserToResizeColumns = false;
            this.grdConsulta1.AllowUserToResizeRows = false;
            this.grdConsulta1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdConsulta1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdConsulta1.Location = new System.Drawing.Point(11, 122);
            this.grdConsulta1.Margin = new System.Windows.Forms.Padding(2);
            this.grdConsulta1.Name = "grdConsulta1";
            this.grdConsulta1.RowTemplate.Height = 28;
            this.grdConsulta1.Size = new System.Drawing.Size(872, 323);
            this.grdConsulta1.TabIndex = 9;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(755, 552);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(128, 42);
            this.btnSalir.TabIndex = 17;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // fromCONSULTAgrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 605);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.cboxCampo1);
            this.Controls.Add(this.lblCampo1);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.cboxTablas);
            this.Controls.Add(this.btnMostrarTabla);
            this.Controls.Add(this.grdConsulta1);
            this.Name = "fromCONSULTAgrid";
            this.Text = "fromCONSULTAgrid";
            this.Load += new System.EventHandler(this.fromCONSULTAgrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdConsulta1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxCampo1;
        private System.Windows.Forms.Label lblCampo1;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.ComboBox cboxTablas;
        private System.Windows.Forms.Button btnMostrarTabla;
        private System.Windows.Forms.DataGridView grdConsulta1;
        private System.Windows.Forms.Button btnSalir;
    }
}