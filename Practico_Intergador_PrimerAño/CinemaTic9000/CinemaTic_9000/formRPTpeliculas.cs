using Microsoft.Reporting.WinForms;
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
    public partial class formRPTpeliculas : Form
    {
        AccesoDatos datos = new AccesoDatos();

        public formRPTpeliculas()
        {
            InitializeComponent();
        }

        private void formRPTpeliculas_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.reportViewer1.RefreshReport();
            cargarReport("peliculas_vista");
            cargarCombo(cboxClasificaciones, "generos");
        }

        private void cargarReport(string nombreTabla)
        {
            datos.leerTabla(nombreTabla);

            
            DataSetCine.PeliculaDataTable.Rows.Clear();
            while (datos.pReader.Read())
            {
                if (!datos.pReader.IsDBNull(0))
                {
                    DataSetCine.PeliculaDataTable.Rows.Add(datos.pReader.GetString(1), datos.pReader.GetString(2), datos.pReader.GetString(3), datos.pReader.GetString(4));
                }

            }
            datos.pReader.Close();
            datos.desconectar();
            this.reportViewer1.RefreshReport();
        }

        private void cargarCombo(ComboBox combo, string nombreTabla)
        {
            DataTable tabla = new DataTable();
            tabla = datos.consultarTabla(nombreTabla);
            combo.DataSource = tabla;
            combo.ValueMember = tabla.Columns[1].ColumnName;
            combo.DisplayMember = tabla.Columns[1].ColumnName;

            combo.SelectedIndex = 0;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(cboxClasificaciones.SelectedValue.ToString());
            string consulta = string.Format("peliculas_vista where genero like '{0}'", cboxClasificaciones.SelectedValue.ToString());
            cargarReport(consulta);


        }


        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            cargarReport("peliculas_vista");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

