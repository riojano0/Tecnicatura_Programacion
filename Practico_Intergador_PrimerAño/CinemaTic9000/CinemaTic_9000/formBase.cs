using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaTic_9000_v2
{
    public partial class formBase : Form
    {
        AccesoDatos Datos = new AccesoDatos();
        public bool banderaNuevo = false;

        public formBase()
        {
            InitializeComponent();
        }

        private void form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            habilitarBotones(true);
        }

        public AccesoDatos pDatos { get { return Datos; } set { Datos = value; } }
        public ListBox pLstboxObjetivo { get { return lstBoxObjetivo; } set { lstBoxObjetivo = value; } }

        
        public void cargarLista(Object[] arrayEnUso, int contador)
        {
            lstBoxObjetivo.Items.Clear();
            for (int i = 0; i < contador; i += 1)
            {
                lstBoxObjetivo.Items.Add(arrayEnUso[i].ToString());
            }
            lstBoxObjetivo.SelectedIndex = lstBoxObjetivo.Items.Count - 1;
        }



        public void cargarCombo(ComboBox combo, string nombreTabla)
        {
            DataTable tabla = new DataTable();
            tabla = Datos.consultarTabla(nombreTabla);
            combo.DataSource = tabla;
            combo.ValueMember = tabla.Columns[0].ColumnName;
            combo.DisplayMember = tabla.Columns[1].ColumnName;
            combo.SelectedIndex = combo.Items.Count - 1;
        }


        public void habilitarBotones(bool x)
        {
            btnNuevo.Enabled = x;
            btnCargar.Enabled = !x;
            btnSalir.Enabled = x;
            btnCancelar.Enabled = !x;
            btnBorrar.Enabled = x;
            btnEditar.Enabled = x;
            habilitarCampos(!x);
        }

        public void habilitarCampos(bool x)
        {
            //pnlContener.Enabled = x;
            foreach (Control ct in this.Controls)
            {
                if (ct is TextBox)
                {
                    ct.Enabled = x;
                }
            }

            var comboBoxes = this.Controls.OfType<ComboBox>().Where(cc => cc.Name.StartsWith("cbox"));
            foreach (ComboBox cb in comboBoxes)
                {
                    if (cb is ComboBox)
                    {
                        cb.Enabled = x;
                    }
                }

            var dateTimePickers = this.Controls.OfType<DateTimePicker>().Where(yy => yy.Name.StartsWith("dtp"));
            foreach(DateTimePicker cdtp in dateTimePickers)
                {
                    if (cdtp is DateTimePicker)
                    {
                        cdtp.Enabled = x;
                    }
                }
            
            lstBoxObjetivo.Enabled = !x;
        }


        public void limpiarCampos()
        {
            foreach (Control ct in this.Controls)
            {
                if (ct is TextBox)
                {
                    ct.Text = "";
                }
            }
            var comboBoxes = this.Controls.OfType<ComboBox>().Where(x => x.Name.StartsWith("cbox"));

            foreach (ComboBox cb in comboBoxes)
            {
                if (cb is ComboBox)
                {
                    cb.SelectedValue = 1;
                }
            }


        }

        public bool validadorCampos()
        {

            foreach (Control ct in this.Controls)
            {
                if (ct.Text == "")
                {
                    ct.Focus();
                    MessageBox.Show("Falta introducir un valor, porfavor revice", "Error de Ingreso");
                    return false;
                }
            }
            return true;

        }



        protected virtual void btnNuevo_Click(object sender, EventArgs e)
        {
            habilitarBotones(false);
            limpiarCampos();
            banderaNuevo = true;
        }


        
        protected virtual void btnCargar_Click(object sender, EventArgs e)
        {
            /*
             * Para poder usarla en tu propio form, copiar
             * protected override void btnCargar_Click(object sender, EventArgs e){}
             * Y alli dentro modificar lo que sea necesario
             */
        }

        protected virtual void btnCancelar_Click(object sender, EventArgs e)
        {
            habilitarBotones(true);
            limpiarCampos();
            banderaNuevo = false;
        }

        protected virtual void btnBorrar_Click(object sender, EventArgs e)
        {
            /*
             * Para poder usarla en tu propio form, copiar
             * protected override void btnBorrar_Click(object sender, EventArgs e){}
             * Y alli dentro modificar lo que sea necesario
             */
        }

        protected virtual void btnEditar_Click(object sender, EventArgs e)
        {
            habilitarBotones(false);
            habilitarCampos(true);
        }

        protected virtual void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        protected virtual void lstBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            /*
             * Para poder usarla en tu propio form, copiar
             * protected override void lstBox_SelectedIndexChanged(object sender, EventArgs e){}
             * Y alli dentro modificar lo que sea necesario
             */
        }

        protected virtual void btnImprimir_Click(object sender, EventArgs e)
        {
            /*
             * Para poder usarla en tu propio form, copiar
             * protected override void btnImprimir_Click(object sender, EventArgs e){}
             * Y alli dentro modificar lo que sea necesario
             */
        }
    }
}
