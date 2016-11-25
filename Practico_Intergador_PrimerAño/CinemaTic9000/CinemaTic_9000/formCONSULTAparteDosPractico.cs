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
    public partial class formCONSULTAparteDosPractico : Form
    {
        AccesoDatos Datos = new AccesoDatos();
        public formCONSULTAparteDosPractico()
        {
            InitializeComponent();
        }

        private void formCONSULTAparteDosPractico_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            cargaGrids();
            cargarCombo(cboxConsulta4, "Empleados");
        }


        public void cargaGrids()
        {

            DataTable tabla1 = new DataTable();
            tabla1 = Datos.consultar("exec consulta1_proc");
            grdConsulta1.DataSource = tabla1;

            for (int i = 0; grdConsulta1.ColumnCount > i; i++)
            {
                grdConsulta1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }

            this.grdConsulta1.DefaultCellStyle.Font = new Font("Tahoma", 8);

            DataTable tabla2 = new DataTable();
            tabla2 = Datos.consultar("select * from consulta2_view");
            grdConsulta2.DataSource = tabla2;

            for (int i = 0; grdConsulta2.ColumnCount > i; i++)
            {
                grdConsulta2.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            this.grdConsulta2.DefaultCellStyle.Font = new Font("Tahoma", 8);

            DataTable tabla3 = new DataTable();
            tabla3 = Datos.consultar("exec consulta3_proc");
            grdConsulta3.DataSource = tabla3;

            for (int i = 0; grdConsulta3.ColumnCount > i; i++)
            {
                grdConsulta3.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            this.grdConsulta3.DefaultCellStyle.Font = new Font("Tahoma", 8);

            DataTable tabla4 = new DataTable();
            tabla4 = Datos.consultar("exec consulta4_proc");
            grdConsulta4.DataSource = tabla4;

            for (int i = 0; grdConsulta4.ColumnCount > i; i++)
            {
                grdConsulta4.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            this.grdConsulta4.DefaultCellStyle.Font = new Font("Tahoma", 8);

            DataTable tabla5 = new DataTable();
            tabla5 = Datos.consultar("exec consulta5_poc");
            grdConsulta5.DataSource = tabla5;

            for (int i = 0; grdConsulta5.ColumnCount > i; i++)
            {
                grdConsulta5.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            this.grdConsulta5.DefaultCellStyle.Font = new Font("Tahoma", 8);

            DataTable tabla6 = new DataTable();
            tabla6 = Datos.consultar("select * from consulta6_view");
            grdConsulta6.DataSource = tabla6;

            for (int i = 0; grdConsulta6.ColumnCount > i; i++)
            {
                grdConsulta6.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            this.grdConsulta6.DefaultCellStyle.Font = new Font("Tahoma", 8);

            DataTable tabla7 = new DataTable();
            tabla7 = Datos.consultar("select * from consulta7_view");
            grdConsulta7.DataSource = tabla7;

            for (int i = 0; grdConsulta7.ColumnCount > i; i++)
            {
                grdConsulta7.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            this.grdConsulta7.DefaultCellStyle.Font = new Font("Tahoma", 8);

            DataTable tabla8 = new DataTable();
            tabla8 = Datos.consultar("select * from consulta8_view");
            grdConsulta8.DataSource = tabla8;

            for (int i = 0; grdConsulta8.ColumnCount > i; i++)
            {
                grdConsulta8.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            this.grdConsulta8.DefaultCellStyle.Font = new Font("Tahoma", 8);
        }

        private void btnFiltrar1_Click(object sender, EventArgs e)
        {
            DataTable tabla1 = new DataTable();
            string filtroConsulta = string.Format("exec consulta1_proc {0}", Convert.ToInt32(dtpConsulta1.Text));
            tabla1 = Datos.consultar(filtroConsulta);
            grdConsulta1.DataSource = tabla1;

            for (int i = 0; grdConsulta1.ColumnCount > i; i++)
            {
                grdConsulta1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }

            this.grdConsulta1.DefaultCellStyle.Font = new Font("Tahoma", 8);
        }

        private void btnFiltrar3_Click(object sender, EventArgs e)
        {
            DataTable tabla3 = new DataTable();
            string filtroConsulta;
            if (txtApellidoConsulta1.Text == "")
            {
                filtroConsulta = string.Format("exec consulta3_proc '%'");
            }
            else
            {
                filtroConsulta = string.Format("exec consulta3_proc '%{0}%'", txtApellidoConsulta1.Text);
            }
            tabla3 = Datos.consultar(filtroConsulta);
            grdConsulta3.DataSource = tabla3;

            for (int i = 0; grdConsulta1.ColumnCount > i; i++)
            {
                grdConsulta3.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }

            this.grdConsulta3.DefaultCellStyle.Font = new Font("Tahoma", 8);
        }

        private void btnFiltrar4_Click(object sender, EventArgs e)
        {
            DataTable tabla4 = new DataTable();
            string filtroConsulta;

            filtroConsulta = string.Format("exec consulta4_proc '{0}'", cboxConsulta4.SelectedValue);

            tabla4 = Datos.consultar(filtroConsulta);
            grdConsulta4.DataSource = tabla4;

            for (int i = 0; grdConsulta1.ColumnCount > i; i++)
            {
                grdConsulta4.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }

            this.grdConsulta4.DefaultCellStyle.Font = new Font("Tahoma", 8);
        }


        public void cargarCombo(ComboBox combo, string tablaObjetivo)
        {
            DataTable tabla = new DataTable();
            tabla = Datos.consultarTabla(tablaObjetivo);
            combo.DataSource = tabla;
            combo.ValueMember = tabla.Columns[1].ColumnName;
            combo.DisplayMember = tabla.Columns[1].ColumnName;

            combo.SelectedIndex = 3;
        }

        private void btnFiltrar5_Click(object sender, EventArgs e)
        {
            DataTable tabla5 = new DataTable();
            string filtroConsulta = string.Format("exec consulta5_poc {0}", Convert.ToInt32(dtpConsulta5.Text));
            tabla5 = Datos.consultar(filtroConsulta);
            grdConsulta5.DataSource = tabla5;

            for (int i = 0; grdConsulta5.ColumnCount > i; i++)
            {
                grdConsulta5.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }

            this.grdConsulta5.DefaultCellStyle.Font = new Font("Tahoma", 8);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cargaGrids();
        }

        private void txtApellidoConsulta1_Click(object sender, EventArgs e)
        {
            txtApellidoConsulta1.Text = "";
            // if you want this to happen only the first time you can remove the event handler like this
            txtApellidoConsulta1.GotFocus -= txtApellidoConsulta1_Click;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

