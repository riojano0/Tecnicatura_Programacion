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
    public partial class formCONSULTASporFecha : Form
    {
        AccesoDatos Datos = new AccesoDatos();

        public formCONSULTASporFecha()
        {
            InitializeComponent();
        }

        private void btnMostrarEmpleados_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();

            //MessageBox.Show(string.Format("SELECT * FROM empleados_vista WHERE convert(datetime,[Fecha Nacimiento],101) BETWEEN '{0}' AND '{1}'",
            //    dtpFechaDesde.Value.ToString("MM-dd-yyyy"), dtpFechaHasta.Value.ToString("MM-dd-yyyy")));

            tabla = Datos.consultar(string.Format("SELECT * FROM empleados_vista WHERE convert(datetime,[Fecha Nacimiento],101) BETWEEN '{0}' AND '{1}'",
                dtpFechaDesde.Value.ToShortDateString(), dtpFechaHasta.Value.ToShortDateString()));

            //dtpFechaDesde.Value.ToShortDateString();

            grdEmpleadosFecha.DataSource = tabla;


            for (int i = 0; grdEmpleadosFecha.ColumnCount > i; i++)
            {
                grdEmpleadosFecha.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            grdEmpleadosFecha.Columns[grdEmpleadosFecha.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formCONSULTASporFecha_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}
