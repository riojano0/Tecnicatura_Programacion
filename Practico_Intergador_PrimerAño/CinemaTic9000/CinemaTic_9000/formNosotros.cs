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
    public partial class formNosotros : Form
    {
        string mazzeoPath;
        string montiveroPath;
        string rodriguezPath;
        string porcelPath;

        public formNosotros()
        {
            InitializeComponent();
        }

        private void formNosotros_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            string hostName = System.Net.Dns.GetHostName();
            if (hostName == "riojano0-PC")
            {
                montiveroPath= @"C:\Users\danie\Dropbox\UTN2016\Laboratorio II\Practico Integrador\Programa\CinemaTic_9000_v2\CinemaTic_9000_v2\resources\cvs\CV_Montivero_foto.pdf";
                mazzeoPath = @"C:\Users\danie\Dropbox\UTN2016\Laboratorio II\Practico Integrador\Programa\CinemaTic_9000_v2\CinemaTic_9000_v2\resources\cvs\CV_Mazzeo.pdf";
                porcelPath = @"C:\Users\danie\Dropbox\UTN2016\Laboratorio II\Practico Integrador\Programa\CinemaTic_9000_v2\CinemaTic_9000_v2\resources\cvs\CV_Porcel.pdf"; 
                 rodriguezPath = @"C:\Users\danie\Dropbox\UTN2016\Laboratorio II\Practico Integrador\Programa\CinemaTic_9000_v2\CinemaTic_9000_v2\resources\cvs\Cv_Rodriguez.pdf";
            }
            else
            {
                montiveroPath = @"C:\Users\danie\Dropbox\UTN2016\Laboratorio II\Practico Integrador\Programa\CinemaTic_9000_v2\CinemaTic_9000_v2\resources\cvs\CV_Montivero_foto.pdf";
                mazzeoPath = @"C:\Users\danie\Dropbox\UTN2016\Laboratorio II\Practico Integrador\Programa\CinemaTic_9000_v2\CinemaTic_9000_v2\resources\cvs\CV_Mazzeo.pdf";
                porcelPath = @"C:\Users\danie\Dropbox\UTN2016\Laboratorio II\Practico Integrador\Programa\CinemaTic_9000_v2\CinemaTic_9000_v2\resources\cvs\CV_Porcel.pdf";
                rodriguezPath = @"C:\Users\danie\Dropbox\UTN2016\Laboratorio II\Practico Integrador\Programa\CinemaTic_9000_v2\CinemaTic_9000_v2\resources\cvs\Cv_Rodriguez.pdf";
            }

        }

        private void btnCvMazzeo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(mazzeoPath);
        }

        private void btnCvMontivero_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(montiveroPath);
        }

        private void btnCvRodriguez_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(rodriguezPath);
        }

        private void btnCvPorcel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(porcelPath);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
