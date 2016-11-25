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
    public partial class formRPTempleados : Form
    {
        AccesoDatos datos = new AccesoDatos();
        public formRPTempleados()
        {
            InitializeComponent();
        }

        private void formRPTempleados_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.reportViewer1.RefreshReport();
            cargarReport("empleados_vista");
            this.reportViewer1.RefreshReport();
        }



        private void cargarReport(string nombreTabla)
        {
            datos.leerTabla(nombreTabla);

            
            DataSetCine.EmpleadoDataTable.Rows.Clear();
            while (datos.pReader.Read())
            {
                if (!datos.pReader.IsDBNull(0))
                {
                    DataSetCine.EmpleadoDataTable.Rows.Add(datos.pReader.GetInt32(0), datos.pReader.GetString(1), datos.pReader.GetString(2),datos.pReader.GetInt64(3),datos.pReader.GetString(4));
                }

            }
            datos.pReader.Close();
            datos.desconectar();
            this.reportViewer1.RefreshReport();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cargarReport("empleados_vista");
        }

        private void btnFiltrar_Click_1(object sender, EventArgs e)
        {
            string consulta = string.Format("empleados_vista where [apellido, nombre] like '%{0}%'", txtEmpleado.Text);
            cargarReport(consulta);
        }
    }
}
