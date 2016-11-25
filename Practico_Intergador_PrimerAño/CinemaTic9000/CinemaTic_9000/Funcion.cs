using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTic_9000_v2
{
    class Funcion
    {
        int codigo;
        int peliculaCod;
        string peliculaNom;
        int horario;
        int idioma;
        int subtitulo;

        public int pCodigo { set { codigo = value; }get { return codigo; } }
        public int pPeliculaCod { set { peliculaCod = value; } get { return peliculaCod; } }
        public string pPeliculaNom { set { peliculaNom = value; } get { return peliculaNom; } }
        public int pHorario { set { horario = value; } get { return horario; } }
        public int pIdioma { set { idioma = value; } get { return idioma; } }
        public int pSubtitulo { set { subtitulo = value; } get { return subtitulo; } }
        

        public Funcion()
        {}

        public override string ToString()
        {
            return string.Format("Pelicula: {0} {1}hs, {2}, {3}",
                                    peliculaNom, horarioToString(), idiomaToString(), subtituloToString());
        }


        public string horarioToString()
        {
            string ht = "";
            switch (horario)
            {
                case 1: ht = "10" ;break;
                case 2: ht = "14"; break;
                case 3: ht = "16"; break;
                case 4: ht = "18"; break;
                case 5: ht = "20"; break;
                case 6: ht = "22"; break;

            }
            return ht;
        }

        public string idiomaToString()
        {
            string it = "";
            switch (idioma)
            {
                case 1: it = "Ingles"; break;
                case 2: it = "Español"; break;
                case 3: it = "Esperanto"; break;
                case 4: it = "Italiano"; break;
                case 5: it = "Frances"; break;
                
            }
            return it;
        }

        public string subtituloToString()
        {
            string st = "";
            switch (subtitulo)
            {
                case 1: st = "Ninguno"; break;
                case 2: st = "Español"; break;
                case 3: st = "Ingles"; break;

            }
            return st;
        }



    }
}
