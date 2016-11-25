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
    public partial class formRPTfunciones : Form
    {
        AccesoDatos datos = new AccesoDatos();

        public formRPTfunciones()
        {
            InitializeComponent();
        }

        private void formRPTfunciones_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.reportViewer1.RefreshReport();
            cargarReport("funciones_vista");
        }

        private void cargarReport(string nombreTabla)
        {
            datos.leerTabla(nombreTabla);


            DataSetCine.FuncionDataTable.Rows.Clear();
            while (datos.pReader.Read())
            {
                if (!datos.pReader.IsDBNull(0))
                {
                    DataSetCine.FuncionDataTable.Rows.Add(datos.pReader.GetString(1), datos.pReader.GetString(2), datos.pReader.GetString(3), datos.pReader.GetString(4));
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
            cargarReport("funciones_vista");
        }

        private void btnFiltrar_Click_1(object sender, EventArgs e)
        {
            string consulta = string.Format("funciones_vista where pelicula like '%{0}%'", txtPelicula.Text);
            cargarReport(consulta);
        }


    }
}
