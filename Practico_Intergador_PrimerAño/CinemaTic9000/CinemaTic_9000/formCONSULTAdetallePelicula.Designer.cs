namespace CinemaTic_9000_v2
{
    partial class formCONSULTAdetallePelicula
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtClasificacion = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.lblClasificacion = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lstViewPelicula = new System.Windows.Forms.ListView();
            this.clID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clPelicula = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clEntradasVendidas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clIngresoTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clPrecioPromedio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clUltimaEntrada = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Peliculas con ventas";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(502, 135);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(91, 13);
            this.lblDescripcion.TabIndex = 18;
            this.lblDescripcion.Text = "DESCRIPCION";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Location = new System.Drawing.Point(505, 151);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(334, 136);
            this.txtDescripcion.TabIndex = 17;
            // 
            // txtClasificacion
            // 
            this.txtClasificacion.Enabled = false;
            this.txtClasificacion.Location = new System.Drawing.Point(621, 91);
            this.txtClasificacion.Name = "txtClasificacion";
            this.txtClasificacion.Size = new System.Drawing.Size(100, 20);
            this.txtClasificacion.TabIndex = 16;
            // 
            // txtGenero
            // 
            this.txtGenero.Enabled = false;
            this.txtGenero.Location = new System.Drawing.Point(505, 91);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(100, 20);
            this.txtGenero.TabIndex = 15;
            // 
            // lblClasificacion
            // 
            this.lblClasificacion.AutoSize = true;
            this.lblClasificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClasificacion.Location = new System.Drawing.Point(618, 75);
            this.lblClasificacion.Name = "lblClasificacion";
            this.lblClasificacion.Size = new System.Drawing.Size(99, 13);
            this.lblClasificacion.TabIndex = 14;
            this.lblClasificacion.Text = "CLASIFICACION";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(502, 75);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(59, 13);
            this.lblGenero.TabIndex = 13;
            this.lblGenero.Text = "GENERO";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(502, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(52, 13);
            this.lblTitulo.TabIndex = 12;
            this.lblTitulo.Text = "TITULO";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Enabled = false;
            this.txtTitulo.Location = new System.Drawing.Point(505, 35);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(334, 20);
            this.txtTitulo.TabIndex = 11;
            // 
            // lstViewPelicula
            // 
            this.lstViewPelicula.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clID,
            this.clPelicula,
            this.clEntradasVendidas,
            this.clIngresoTotal,
            this.clPrecioPromedio,
            this.clUltimaEntrada});
            this.lstViewPelicula.Location = new System.Drawing.Point(12, 35);
            this.lstViewPelicula.MultiSelect = false;
            this.lstViewPelicula.Name = "lstViewPelicula";
            this.lstViewPelicula.Size = new System.Drawing.Size(473, 252);
            this.lstViewPelicula.TabIndex = 10;
            this.lstViewPelicula.UseCompatibleStateImageBehavior = false;
            this.lstViewPelicula.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstViewPelicula_ItemSelectionChanged);
            // 
            // clID
            // 
            this.clID.DisplayIndex = 1;
            this.clID.Text = "ID";
            // 
            // clPelicula
            // 
            this.clPelicula.DisplayIndex = 0;
            this.clPelicula.Text = "Pelicula";
            // 
            // clEntradasVendidas
            // 
            this.clEntradasVendidas.Text = "EntradasVendidas";
            // 
            // clIngresoTotal
            // 
            this.clIngresoTotal.Text = "Ingreso Total";
            // 
            // clPrecioPromedio
            // 
            this.clPrecioPromedio.Text = "Precio Promedio";
            // 
            // clUltimaEntrada
            // 
            this.clUltimaEntrada.Text = "Ultima entrada vendida";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(716, 346);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(123, 53);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // formCONSULTAdetallePelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 411);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtClasificacion);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.lblClasificacion);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lstViewPelicula);
            this.Name = "formCONSULTAdetallePelicula";
            this.Text = "formCONSULTAdetallePelicula";
            this.Load += new System.EventHandler(this.formCONSULTAdetallePelicula_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtClasificacion;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.Label lblClasificacion;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.ListView lstViewPelicula;
        private System.Windows.Forms.ColumnHeader clID;
        private System.Windows.Forms.ColumnHeader clPelicula;
        private System.Windows.Forms.ColumnHeader clEntradasVendidas;
        private System.Windows.Forms.ColumnHeader clIngresoTotal;
        private System.Windows.Forms.ColumnHeader clPrecioPromedio;
        private System.Windows.Forms.ColumnHeader clUltimaEntrada;
        private System.Windows.Forms.Button btnSalir;
    }
}