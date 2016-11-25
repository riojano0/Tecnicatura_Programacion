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
    public partial class formMenuPrincipal: Form
    {
        public formMenuPrincipal()
        {
            InitializeComponent();
        }

        private void funcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formABMfuncion frmFuncion = new formABMfuncion();
            frmFuncion.ShowDialog();
        }

        private void peliculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formABMpelicula frmPelicula = new formABMpelicula();
            frmPelicula.ShowDialog();
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formABMempleado frmEmpleado = new formABMempleado();
            frmEmpleado.ShowDialog();
        }

        private void generoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formABMgenero frmGenero = new formABMgenero();
            frmGenero.ShowDialog();
        }

        private void consultasConGridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCONSULTAgrid frmGRid = new formCONSULTAgrid();
            frmGRid.ShowDialog();
        }

        private void consultaConFiltroFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCONSULTASporFecha frmFecha = new formCONSULTASporFecha();
            frmFecha.ShowDialog();
        }

        private void consultasParteDosPracticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCONSULTAparteDosPractico frmParteDos = new formCONSULTAparteDosPractico();
            frmParteDos.ShowDialog();
        }

        private void consultaConDetallePeliculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCONSULTAdetallePelicula frmDetallePelicula = new formCONSULTAdetallePelicula();
            frmDetallePelicula.ShowDialog();
        }

        private void peliculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formRPTpeliculas reporteForm = new formRPTpeliculas();
            reporteForm.ShowDialog();
        }

        private void funcionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            formRPTfunciones reporteForm = new formRPTfunciones();
            reporteForm.ShowDialog(); 
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formNosotros formAbout = new formNosotros();
            formAbout.ShowDialog();
        }

        private void formMenuPrincipal_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formRPTempleados rptEmpleados = new formRPTempleados();
            rptEmpleados.ShowDialog();
        }

        private void generosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formRPTgeneros rptGenero = new formRPTgeneros();
            rptGenero.ShowDialog();
        }
    }
}
