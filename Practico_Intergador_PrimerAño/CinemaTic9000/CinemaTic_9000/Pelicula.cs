using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTic_9000_v2
{
    class Pelicula
    {
        int identificador;
        string titulo;
        string descripcion;
        int genero;
        int clasificacion;

        public int pIdentificador { set { identificador = value; } get { return identificador; } }
        public string pTitulo { set { titulo = value; } get { return titulo; } }
        public string pDescripcion { set { descripcion = value; } get { return descripcion; } }
        public int pGenero { set { genero = value; } get { return genero; } }
        public int pClasificacion { set { clasificacion = value; } get { return clasificacion; } }

        public Pelicula() { }

        public Pelicula(int id, string t, string d, int ge, int cl)
        {
            identificador = id;
            titulo = t;
            descripcion = d;
            genero = ge;
            clasificacion = cl;
        }

        public string generoToString()
        {
            string st_genero = "";
            switch (genero)
            {
                case 1: st_genero = "Terror"; break;
                case 2: st_genero = "Ciencia Ficcion"; break;
                case 3: st_genero = "Drama"; break;
                case 4: st_genero = "Comedia"; break;
                case 5: st_genero = "Documental"; break;
                case 6: st_genero = "Musical"; break;
                case 7: st_genero = "Accion"; break;
                case 8: st_genero = "Animada"; break;
            }

            return st_genero;
        }

        public string clasificacionToString()
        {
            string st_clasificacion = "";
            switch (clasificacion)
            {
                case 1: st_clasificacion = "ATP"; break;
                case 2: st_clasificacion = "+13"; break;
                case 3: st_clasificacion = "+16"; break;
                case 4: st_clasificacion = "+18"; break;
            }

            return st_clasificacion;
        }

        override public string ToString()
        {
            return string.Format("{0}", titulo);
        }
    }
}
