namespace CinemaTic_9000_v2
{
    partial class formABMpelicula
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
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblContadorCaracteres = new System.Windows.Forms.Label();
            this.lblCaracteres = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cboxClasificacion = new System.Windows.Forms.ComboBox();
            this.cboxGenero = new System.Windows.Forms.ComboBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(31, 161);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(74, 13);
            this.lblDescripcion.TabIndex = 27;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Clasificacion";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(31, 74);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(48, 13);
            this.lblGenero.TabIndex = 25;
            this.lblGenero.Text = "Genero";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(31, 27);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(39, 13);
            this.lblTitulo.TabIndex = 24;
            this.lblTitulo.Text = "Titulo";
            // 
            // lblContadorCaracteres
            // 
            this.lblContadorCaracteres.AutoSize = true;
            this.lblContadorCaracteres.Location = new System.Drawing.Point(222, 161);
            this.lblContadorCaracteres.Name = "lblContadorCaracteres";
            this.lblContadorCaracteres.Size = new System.Drawing.Size(25, 13);
            this.lblContadorCaracteres.TabIndex = 23;
            this.lblContadorCaracteres.Text = "800";
            // 
            // lblCaracteres
            // 
            this.lblCaracteres.AutoSize = true;
            this.lblCaracteres.Location = new System.Drawing.Point(158, 161);
            this.lblCaracteres.Name = "lblCaracteres";
            this.lblCaracteres.Size = new System.Drawing.Size(58, 13);
            this.lblCaracteres.TabIndex = 22;
            this.lblCaracteres.Text = "Caracteres";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(34, 177);
            this.txtDescripcion.MaxLength = 800;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(223, 151);
            this.txtDescripcion.TabIndex = 21;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            // 
            // cboxClasificacion
            // 
            this.cboxClasificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxClasificacion.FormattingEnabled = true;
            this.cboxClasificacion.Location = new System.Drawing.Point(135, 118);
            this.cboxClasificacion.Name = "cboxClasificacion";
            this.cboxClasificacion.Size = new System.Drawing.Size(122, 21);
            this.cboxClasificacion.TabIndex = 20;
            // 
            // cboxGenero
            // 
            this.cboxGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxGenero.FormattingEnabled = true;
            this.cboxGenero.Location = new System.Drawing.Point(135, 72);
            this.cboxGenero.Name = "cboxGenero";
            this.cboxGenero.Size = new System.Drawing.Size(122, 21);
            this.cboxGenero.TabIndex = 19;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(92, 27);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(165, 20);
            this.txtTitulo.TabIndex = 18;
            // 
            // formABMpelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 463);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblContadorCaracteres);
            this.Controls.Add(this.lblCaracteres);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.cboxClasificacion);
            this.Controls.Add(this.cboxGenero);
            this.Controls.Add(this.txtTitulo);
            this.Name = "formABMpelicula";
            this.Text = "formABMpelicula";
            this.Load += new System.EventHandler(this.formABMpelicula_Load);
            this.Controls.SetChildIndex(this.txtTitulo, 0);
            this.Controls.SetChildIndex(this.cboxGenero, 0);
            this.Controls.SetChildIndex(this.cboxClasificacion, 0);
            this.Controls.SetChildIndex(this.txtDescripcion, 0);
            this.Controls.SetChildIndex(this.lblCaracteres, 0);
            this.Controls.SetChildIndex(this.lblContadorCaracteres, 0);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.lblGenero, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblDescripcion, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblContadorCaracteres;
        private System.Windows.Forms.Label lblCaracteres;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox cboxClasificacion;
        private System.Windows.Forms.ComboBox cboxGenero;
        private System.Windows.Forms.TextBox txtTitulo;
    }
}