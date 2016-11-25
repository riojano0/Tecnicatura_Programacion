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
    public partial class formRPTgeneros : Form
    {
        AccesoDatos datos = new AccesoDatos();
        public formRPTgeneros()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formRPTgeneros_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.reportViewer1.RefreshReport();
            cargarReport("generos_vista");
        }

        private void cargarReport(string nombreTabla)
        {
            datos.leerTabla(nombreTabla);


            DataSetCine.GeneroDataTable.Rows.Clear();
            while (datos.pReader.Read())
            {
                if (!datos.pReader.IsDBNull(0))
                {
                    DataSetCine.GeneroDataTable.Rows.Add(datos.pReader.GetInt32(0), datos.pReader.GetString(1));
                }

            }
            datos.pReader.Close();
            datos.desconectar();
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cargarReport("generos_vista");
        }
    }
}
