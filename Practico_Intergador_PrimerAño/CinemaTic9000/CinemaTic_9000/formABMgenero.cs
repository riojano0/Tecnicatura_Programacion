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
    public partial class formABMgenero : formBase
    {

        const int tam = 20;
        Genero[] aGeneros = new Genero[tam];
        int cGenero = 0;

        public formABMgenero()
        {
            InitializeComponent();
        }

        private void formABMgenero_Load(object sender, EventArgs e)
        {
            cargarArray("Generos");
            cargarLista(aGeneros, cGenero);
            
        }

        private void cargarArray(string nombreTabla)
        {
            pDatos.leerTabla(nombreTabla);
            
            cGenero = 0;
            while (pDatos.pReader.Read())
            {
                Genero g = new Genero();
                if (!pDatos.pReader.IsDBNull(0))
                {
                    g.pCodigo = pDatos.pReader.GetInt32(0);
                }
                if (!pDatos.pReader.IsDBNull(1))
                {
                    g.pNombre = pDatos.pReader.GetString(1);
                }

                aGeneros[cGenero] = g;
                cGenero += 1;
            }
            pDatos.pReader.Close();
            pDatos.desconectar();

        }

        protected override void btnCargar_Click(object sender, EventArgs e)
        {
        
                if (validadorCampos())
                {

                    Genero gen = new Genero();
                    //gen.pCodigo = Convert.ToInt32(txtCodigo.Text);
                    gen.pNombre = txtGenero.Text;

                    if (banderaNuevo)
                    {
                        string queryInsert = string.Format("insert into Generos(genero) values('{0}')", gen.pNombre
                                                            );
                        pDatos.actualizar(queryInsert);
                    }
                    else
                    {
                        int i = pLstboxObjetivo.SelectedIndex;
                        string queryUpdate = string.Format("update generos " +
                                                            "set genero='{0}' " +
                                                            "where id_genero={1}",
                                                            gen.pNombre, aGeneros[i].pCodigo);
                    //MessageBox.Show(aPeliculas[i].pIdentificador.ToString());
                    pDatos.actualizar(queryUpdate);
                    }
                }
            limpiarCampos();
            habilitarBotones(true);
            habilitarCampos(false);
            banderaNuevo = false;
            cargarArray("Generos");
            cargarLista(aGeneros, cGenero);

        }

        protected override void btnBorrar_Click(object sender, EventArgs e)
        {

            DialogResult condicion = MessageBox.Show("Esta seguro que desea borrar este Genero?", "Atencion!", MessageBoxButtons.YesNo,
             MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            if (condicion == DialogResult.Yes)
            {
                try {
                    string queryDelete = string.Format("delete generos where id_genero={0}", aGeneros[pLstboxObjetivo.SelectedIndex].pCodigo);
                    pDatos.actualizar(queryDelete);
                    cargarArray("Generos");
                    cargarLista(aGeneros, cGenero);
                    limpiarCampos();
                }
                catch{
                    MessageBox.Show("Perdon, no podemos permitirle borrar un genero que esta relacionado con una pelicula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }

        protected override void lstBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtCodigo.Text = aGeneros[pLstboxObjetivo.SelectedIndex].pCodigo.ToString();
            txtGenero.Text = aGeneros[pLstboxObjetivo.SelectedIndex].pNombre;
        }
        protected override void btnImprimir_Click(object sender, EventArgs e)
        {
            formRPTgeneros reporteForm = new formRPTgeneros();
            reporteForm.ShowDialog();
        }

    }
}
