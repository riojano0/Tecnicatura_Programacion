namespace CinemaTic_9000_v2
{
    partial class formABMfuncion
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
            this.cboxPelicula = new System.Windows.Forms.ComboBox();
            this.cboxHorario = new System.Windows.Forms.ComboBox();
            this.cboxIdioma = new System.Windows.Forms.ComboBox();
            this.cboxSubtitulo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboxPelicula
            // 
            this.cboxPelicula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxPelicula.FormattingEnabled = true;
            this.cboxPelicula.Location = new System.Drawing.Point(130, 36);
            this.cboxPelicula.Name = "cboxPelicula";
            this.cboxPelicula.Size = new System.Drawing.Size(121, 21);
            this.cboxPelicula.TabIndex = 18;
            // 
            // cboxHorario
            // 
            this.cboxHorario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxHorario.FormattingEnabled = true;
            this.cboxHorario.Location = new System.Drawing.Point(130, 74);
            this.cboxHorario.Name = "cboxHorario";
            this.cboxHorario.Size = new System.Drawing.Size(121, 21);
            this.cboxHorario.TabIndex = 19;
            // 
            // cboxIdioma
            // 
            this.cboxIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxIdioma.FormattingEnabled = true;
            this.cboxIdioma.Location = new System.Drawing.Point(130, 114);
            this.cboxIdioma.Name = "cboxIdioma";
            this.cboxIdioma.Size = new System.Drawing.Size(121, 21);
            this.cboxIdioma.TabIndex = 20;
            // 
            // cboxSubtitulo
            // 
            this.cboxSubtitulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSubtitulo.FormattingEnabled = true;
            this.cboxSubtitulo.Location = new System.Drawing.Point(130, 158);
            this.cboxSubtitulo.Name = "cboxSubtitulo";
            this.cboxSubtitulo.Size = new System.Drawing.Size(121, 21);
            this.cboxSubtitulo.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Pelicula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Horario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Idioma";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Subtitulo";
            // 
            // formABMfuncion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 472);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxSubtitulo);
            this.Controls.Add(this.cboxIdioma);
            this.Controls.Add(this.cboxHorario);
            this.Controls.Add(this.cboxPelicula);
            this.Name = "formABMfuncion";
            this.Text = "formABMfuncion";
            this.Load += new System.EventHandler(this.formABMfuncion_Load);
            this.Controls.SetChildIndex(this.cboxPelicula, 0);
            this.Controls.SetChildIndex(this.cboxHorario, 0);
            this.Controls.SetChildIndex(this.cboxIdioma, 0);
            this.Controls.SetChildIndex(this.cboxSubtitulo, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxPelicula;
        private System.Windows.Forms.ComboBox cboxHorario;
        private System.Windows.Forms.ComboBox cboxIdioma;
        private System.Windows.Forms.ComboBox cboxSubtitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}