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
    public partial class formCONSULTAdetallePelicula : Form
    {
        AccesoDatos Datos = new AccesoDatos();

        const int tam = 20;
        Pelicula[] aPeliculas = new Pelicula[tam];
        int cPelicula = 0;


        public formCONSULTAdetallePelicula()
        {
            
            InitializeComponent();
        }

        private void formCONSULTAdetallePelicula_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            lstViewPelicula.View = View.Details;
            cargarLista("Peliculas");
        }

        public void cargarLista(string nombreTabla)
        {
            Datos.leerTabla(nombreTabla);
            lstViewPelicula.Items.Clear();

            cPelicula = 0;
            while (Datos.pReader.Read())
            {
                Pelicula p = new Pelicula();
                if (!Datos.pReader.IsDBNull(0))
                {
                    p.pIdentificador = Datos.pReader.GetInt32(0);
                }
                if (!Datos.pReader.IsDBNull(1))
                {
                    p.pTitulo = Datos.pReader.GetString(1);
                }
                if (!Datos.pReader.IsDBNull(2))
                {
                    p.pDescripcion = Datos.pReader.GetString(2);
                }
                if (!Datos.pReader.IsDBNull(3))
                {
                    p.pGenero = Datos.pReader.GetInt32(3);
                }
                if (!Datos.pReader.IsDBNull(4))
                {
                    p.pClasificacion = Datos.pReader.GetInt32(4);
                }

                aPeliculas[cPelicula] = p;
                cPelicula += 1;
            }
            Datos.pReader.Close();
            Datos.desconectar();

            DataTable consultaTabla = new DataTable();
            consultaTabla = Datos.consultarTabla("vistapeliculas_2");
            Datos.desconectar();

            for (int i = 0; i < consultaTabla.Rows.Count; i += 1)
            {
                DataRow registro = consultaTabla.Rows[i];
                ListViewItem peliculaItems = new ListViewItem(registro[0].ToString());
                peliculaItems.SubItems.Add(registro[1].ToString());
                peliculaItems.SubItems.Add(registro[2].ToString());
                peliculaItems.SubItems.Add(registro[3].ToString());
                peliculaItems.SubItems.Add(registro[4].ToString());
                peliculaItems.SubItems.Add(registro[5].ToString());

                lstViewPelicula.Items.Add(peliculaItems);

            }

            lstViewPelicula.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lstViewPelicula.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }


        private void lstViewPelicula_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            int id;
            lstViewPelicula.FullRowSelect = true;
            if (lstViewPelicula.SelectedItems.Count > 0)
            {
                id = Convert.ToInt32(lstViewPelicula.SelectedItems[0].Text) - 1;
                txtTitulo.Text = aPeliculas[id].pTitulo;
                txtDescripcion.Text = aPeliculas[id].pDescripcion;
                txtGenero.Text = aPeliculas[id].generoToString();
                txtClasificacion.Text = aPeliculas[id].clasificacionToString();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
