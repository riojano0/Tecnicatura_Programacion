using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTic_9000_v2
{
    class Empleado
    {
        double identificacion;
        string nombre, apellido;
        int tipoDocumento;
        double documento;
        DateTime fecNacimiento;

        public double pIdentificacion { set { identificacion = value; } get { return identificacion; } }
        public string pNombre { set { nombre = value; } get { return nombre; } }
        public string pApellido { set { apellido = value; } get { return apellido; } }
        public double pDocumento { set { documento = value; } get { return documento; } }
        public int pTipoDocumento { set { tipoDocumento = value; } get { return tipoDocumento; } }
        public DateTime pfecNacimiento { set { fecNacimiento = value; } get { return fecNacimiento; } }

        public Empleado()
        {
            this.fecNacimiento = DateTime.Now;
        }

        public Empleado(double identificacion, string nombre, string apellido,
                        int tipoDocumento, double documento, DateTime fecNacimiento)
        {
            this.identificacion = identificacion;
            this.nombre = nombre;
            this.apellido = apellido;
            this.tipoDocumento = tipoDocumento;
            this.documento = documento;
            this.fecNacimiento = fecNacimiento;
        }

        override public string ToString()
        {
            //string mystr = string.Format("This is {0} overflow", nombre);
            return string.Format("{0} {1}", nombre, apellido);
        }

    }
}
