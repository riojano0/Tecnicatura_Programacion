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
    public partial class formCONSULTAgrid : Form
    {
        AccesoDatos Datos = new AccesoDatos();
        Dictionary<string, string> dictVistas = new Dictionary<string, string>()
    {
        {"Tipos de Documentos", "Tipo_Documentos_vista"},
        {"Empleados", "Empleados_vista"},
        {"Tipos de Caja","Tipo_Cajas_vista"},
        {"Cajas", "Cajas_vista"},
        {"Metodos de Pago", "Metodo_pagos_vista"},
        {"Tipos de Cliente", "Tipo_Clientes_vista"},
        {"Generos", "generos_vista"},
        {"Clasificaciones", "Clasificaciones"},
        {"Peliculas", "Peliculas_vista"},
        {"Idiomas", "Idiomas_vista"},
        {"subtitulos", "subtitulos_vista"},
        {"Horarios de Funciones", "Funcion_horarios_vista"},
        {"Funciones", "Funciones_vista"},
        {"Tipo de Salas", "tipo_Salas_vista"},
        {"Entradas", " Entradas_vista"},
        {"Tickets", "TICKETS_vista"},
        {"Detalle de Tickets", "detalle_Tickets_vista"},

    };


        public formCONSULTAgrid()
        {
            InitializeComponent();
        }

        private void fromCONSULTAgrid_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            cargarComboDeDict(cboxTablas, dictVistas);

            lblCampo1.Visible = false;
            cboxCampo1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DataTable tabla = new DataTable();
            tabla = Datos.consultarTabla(cboxTablas.SelectedValue.ToString());
            grdConsulta1.DataSource = tabla;

            for (int i = 0; grdConsulta1.ColumnCount > i; i++)
            {
                grdConsulta1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            grdConsulta1.Columns[grdConsulta1.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            lblCampo1.Text = grdConsulta1.Columns[1].Name;

            DataTable tablacombos1 = new DataTable();
            tablacombos1 = tabla.Copy();
            cboxCampo1.DataSource = tablacombos1;
            cboxCampo1.DisplayMember = tablacombos1.Columns[1].ColumnName;
            cboxCampo1.ValueMember = tablacombos1.Columns[1].ColumnName;
            cboxCampo1.Visible = true;
            cboxCampo1.SelectedIndexChanged += new EventHandler(comboBox1_SelectedIndexChanged);
            cboxCampo1.Enabled = true;
            lblCampo1.Visible = true;
            lblCampo1.Enabled = true;
            btnFiltrar.Enabled = true;
            
            cboxCampo1.SelectedIndex = 0;


        }


        private void cargarComboDeDict(ComboBox combo, Dictionary<string, string> dict)
        {
            combo.DataSource = new BindingSource(dict, null);
            combo.DisplayMember = "Key";
            combo.ValueMember = "Value";
            combo.SelectedIndex = combo.Items.Count - 1;

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();

            string filtroSql = string.Format("Select * from {0} where [{1}]='{2}'",
                cboxTablas.SelectedValue.ToString(), lblCampo1.Text, cboxCampo1.SelectedValue.ToString());
            tabla = Datos.consultar(filtroSql);
            grdConsulta1.DataSource = tabla;

            for (int i = 0; grdConsulta1.ColumnCount > i; i++)
            {
                grdConsulta1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;


            }
            grdConsulta1.Columns[grdConsulta1.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboxCampo1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboxTablas_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboxCampo1.Enabled = false;
            lblCampo1.Enabled = false;
            btnFiltrar.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

