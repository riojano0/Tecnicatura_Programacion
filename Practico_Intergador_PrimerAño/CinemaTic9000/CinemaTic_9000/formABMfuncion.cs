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
    public partial class formABMfuncion : formBase
    {
        const int tam = 40;
        Funcion[] aFunciones = new Funcion[tam];
        int cFuncion = 0;

        public formABMfuncion()
        {
            InitializeComponent();
        }

        private void formABMfuncion_Load(object sender, EventArgs e)
        {
            cargarArray("Funciones");
            cargarLista(aFunciones, cFuncion);
            cargarCombo(cboxPelicula, "Peliculas");
            cargarCombo(cboxIdioma, "Idiomas");
            cargarCombo(cboxHorario, "funcion_horarios");
            cargarCombo(cboxSubtitulo, "subtitulos");
        }

        public void cargarArray(string nombreTabla)
        {
            pDatos.leerTabla(nombreTabla);
            pLstboxObjetivo.Items.Clear();

            cFuncion = 0;
            while (pDatos.pReader.Read())
            {
                Funcion p = new Funcion();
                if (!pDatos.pReader.IsDBNull(0))
                {
                    p.pCodigo = pDatos.pReader.GetInt32(0);
                }
                if (!pDatos.pReader.IsDBNull(1))
                {
                    p.pPeliculaCod = pDatos.pReader.GetInt32(1);
                }
                if (!pDatos.pReader.IsDBNull(2))
                {
                    p.pHorario = pDatos.pReader.GetInt32(2);
                }
                if (!pDatos.pReader.IsDBNull(3))
                {
                    p.pIdioma = pDatos.pReader.GetInt32(3);
                }
                if (!pDatos.pReader.IsDBNull(4))
                {
                    p.pSubtitulo = pDatos.pReader.GetInt32(4);
                }

                aFunciones[cFuncion] = p;
                cFuncion += 1;
            }
            pDatos.pReader.Close();
            pDatos.desconectar();

            //Se encarga de buscar la ID cargada previamente de la pelicula y completar el nombre
            for (int i = 0; i < cFuncion; i++)
            {
                foreach (DataRow row in pDatos.consultarTabla("Peliculas").Rows)
                {
                    if (Convert.ToInt32(row["id_pelicula"]) == aFunciones[i].pPeliculaCod)
                    {
                        aFunciones[i].pPeliculaNom = row["pelicula"].ToString();
                    }
                }
            }


        }

        protected override void btnCargar_Click(object sender, EventArgs e)
        {
            if (validadorCampos())
            {
                Funcion func = new Funcion();
                func.pPeliculaCod = Convert.ToInt32(cboxPelicula.SelectedValue);
                func.pPeliculaNom = cboxPelicula.SelectedText;
                func.pHorario = Convert.ToInt32(cboxHorario.SelectedValue);
                func.pIdioma = Convert.ToInt32(cboxIdioma.SelectedValue);
                func.pSubtitulo = Convert.ToInt32(cboxSubtitulo.SelectedValue);


                if (banderaNuevo)
                {
                    string queryInsert = string.Format("insert into funciones(id_pelicula,id_horario,id_idioma,id_subtitulo) values ({0},{1},{2},{3})",
                                                        func.pPeliculaCod, func.pHorario, func.pIdioma, func.pSubtitulo);
                    pDatos.actualizar(queryInsert);
                }
                else
                {
                    int i = pLstboxObjetivo.SelectedIndex;
                    string queryUpdate = string.Format("update funciones " +
                                                        "set id_pelicula={0},id_horario={1},id_idioma={2},id_subtitulo={3} " +
                                                        "where id_funcion={4}",
                                                        func.pPeliculaCod, func.pHorario, func.pIdioma, func.pSubtitulo,
                                                        aFunciones[i].pCodigo);
                    
                    pDatos.actualizar(queryUpdate);
                }

                limpiarCampos();
                habilitarBotones(true);
                habilitarCampos(false);
                banderaNuevo = false;
                cargarArray("Funciones");
                cargarLista(aFunciones, cFuncion);
            }
        }

        protected override void btnBorrar_Click(object sender, EventArgs e)
        {
            DialogResult condicion = MessageBox.Show("Esta seguro que desea borrar esta Funcion?", "Atencion!", MessageBoxButtons.YesNo,
              MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            if (condicion == DialogResult.Yes)
            {
                string queryDelete = string.Format("delete funciones where id_funcion={0}", aFunciones[pLstboxObjetivo.SelectedIndex].pCodigo);
                pDatos.actualizar(queryDelete);
                cargarArray("Funciones");
                cargarLista(aFunciones, cFuncion);
                limpiarCampos();
            }
        }

        protected override void lstBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboxPelicula.SelectedValue = aFunciones[pLstboxObjetivo.SelectedIndex].pPeliculaCod;
            cboxHorario.SelectedValue = aFunciones[pLstboxObjetivo.SelectedIndex].pHorario;
            cboxIdioma.SelectedValue = aFunciones[pLstboxObjetivo.SelectedIndex].pIdioma;
            cboxSubtitulo.SelectedValue = aFunciones[pLstboxObjetivo.SelectedIndex].pSubtitulo;
        }

        protected override void btnImprimir_Click(object sender, EventArgs e)
        {
            formRPTfunciones reporteForm = new formRPTfunciones();
            reporteForm.ShowDialog();
        }

    }

}
