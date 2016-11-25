using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTic_9000_v2
{
    class Genero
    {
        int codigo;
        string nombre;

        public int pCodigo { set { codigo = value; } get { return codigo; } }
        public string pNombre { set { nombre = value; } get { return nombre; } }


        public override string ToString()
        {
            return string.Format("Nombre del genero:{1}", codigo, nombre);
        }

        public Genero()
        {

        }
    }
}
