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
    public partial class formABMpelicula : formBase
    {
        const int tam = 40;
        Pelicula[] aPeliculas = new Pelicula[tam];
        int cPelicula = 0;

        public formABMpelicula()
        {
            InitializeComponent();
        }

        private void formABMpelicula_Load(object sender, EventArgs e)
        {
            cargarArray("Peliculas");
            cargarLista(aPeliculas, cPelicula);
            cargarCombo(cboxGenero, "Generos");
            cargarCombo(cboxClasificacion, "Clasificaciones");
        }

        public void cargarArray(string nombreTabla)
        {
            pDatos.leerTabla(nombreTabla);
            pLstboxObjetivo.Items.Clear();

            cPelicula = 0;
            while (pDatos.pReader.Read())
            {
                Pelicula p = new Pelicula();
                if (!pDatos.pReader.IsDBNull(0))
                {
                    p.pIdentificador = pDatos.pReader.GetInt32(0);
                }
                if (!pDatos.pReader.IsDBNull(1))
                {
                    p.pTitulo = pDatos.pReader.GetString(1);
                }
                if (!pDatos.pReader.IsDBNull(2))
                {
                    p.pDescripcion = pDatos.pReader.GetString(2);
                }
                if (!pDatos.pReader.IsDBNull(3))
                {
                    p.pGenero = pDatos.pReader.GetInt32(3);
                }
                if (!pDatos.pReader.IsDBNull(4))
                {
                    p.pClasificacion = pDatos.pReader.GetInt32(4);
                }

                aPeliculas[cPelicula] = p;
                cPelicula += 1;
            }
            pDatos.pReader.Close();
            pDatos.desconectar();

        }

        protected override void btnCargar_Click(object sender, EventArgs e)
        {
            if (validadorCampos())
            {
                Pelicula peli = new Pelicula();
                peli.pTitulo = txtTitulo.Text;
                peli.pGenero = Convert.ToInt32(cboxGenero.SelectedValue);
                peli.pClasificacion = Convert.ToInt32(cboxClasificacion.SelectedValue);
                peli.pDescripcion = txtDescripcion.Text;

                if (banderaNuevo)
                {
                    string queryInsert = string.Format("exec insertarPelicula '{0}',{1},{2},'{3}'",
                                                        peli.pTitulo, peli.pGenero, peli.pClasificacion, peli.pDescripcion);
                    pDatos.actualizar(queryInsert);
                }
                else
                {
                    int i = pLstboxObjetivo.SelectedIndex;
                        
                    string queryUpdate = string.Format("update peliculas set pelicula='{0}', id_genero={1}, id_clasificacion={2}, descripcion='{3}' " +
                                                        "where id_pelicula={4}",
                                                        peli.pTitulo, peli.pGenero, peli.pClasificacion, peli.pDescripcion,
                                                        aPeliculas[i].pIdentificador);
                    //MessageBox.Show(aPeliculas[i].pIdentificador.ToString());
                    pDatos.actualizar(queryUpdate);
                }


                limpiarCampos();
                habilitarBotones(true);
                habilitarCampos(false);
                banderaNuevo = false;
                cargarArray("Peliculas");
                cargarLista(aPeliculas, cPelicula);
            }
        }

        protected override void btnBorrar_Click(object sender, EventArgs e)
        {
            DialogResult condicion = MessageBox.Show("Esta seguro que desea borrar esta Pelicula?", "Atencion!", MessageBoxButtons.YesNo,
              MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            if (condicion == DialogResult.Yes)
            {
                string queryDelete = string.Format("delete peliculas where id_pelicula={0}", aPeliculas[pLstboxObjetivo.SelectedIndex].pIdentificador);
                pDatos.actualizar(queryDelete);
                cargarArray("Peliculas");
                cargarLista(aPeliculas, cPelicula);
                limpiarCampos();
            }
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            int avail = 800;
            lblContadorCaracteres.Text = (avail - txtDescripcion.TextLength).ToString();

        }

        protected override void lstBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTitulo.Text = aPeliculas[pLstboxObjetivo.SelectedIndex].pTitulo;
            cboxGenero.SelectedValue = aPeliculas[pLstboxObjetivo.SelectedIndex].pGenero;
            cboxClasificacion.SelectedValue = aPeliculas[pLstboxObjetivo.SelectedIndex].pClasificacion;
            txtDescripcion.Text = aPeliculas[pLstboxObjetivo.SelectedIndex].pDescripcion;
        }

        protected override void btnImprimir_Click(object sender, EventArgs e) {
            formRPTpeliculas reporteForm = new formRPTpeliculas();
            reporteForm.ShowDialog();
        }

    }
}

