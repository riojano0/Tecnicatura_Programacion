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
    public partial class formABMempleado : formBase
    {
        const int tam = 20;
        Empleado[] aEmpleados = new Empleado[tam];
        int cEmpleado = 0;

        public formABMempleado()
        {
            InitializeComponent();
        }

        private void formABMempleado_Load(object sender, EventArgs e)
        {
            cargarArray("Empleados");
            cargarLista(aEmpleados, cEmpleado);
            cargarCombo(cboxTipoDocumento, "Tipo_documentos");
        }

        public void cargarArray(string nombreTabla)
        {
            pDatos.leerTabla(nombreTabla);
            cEmpleado = 0;
            while (pDatos.pReader.Read())
            {
                Empleado p = new Empleado();
                if (!pDatos.pReader.IsDBNull(0))
                {
                    p.pIdentificacion = pDatos.pReader.GetInt32(0);
                }
                if (!pDatos.pReader.IsDBNull(1))
                {
                    p.pNombre = pDatos.pReader.GetString(1);
                }
                if (!pDatos.pReader.IsDBNull(2))
                {
                    p.pApellido = pDatos.pReader.GetString(2);
                }
                if (!pDatos.pReader.IsDBNull(3))
                {
                    p.pTipoDocumento = pDatos.pReader.GetInt32(3);
                }
                if (!pDatos.pReader.IsDBNull(4))
                {
                    p.pDocumento = pDatos.pReader.GetInt64(4);
                }
                if (!pDatos.pReader.IsDBNull(5))
                {
                    p.pfecNacimiento = pDatos.pReader.GetDateTime(5);
                }

                aEmpleados[cEmpleado] = p;
                cEmpleado += 1;
            }
            pDatos.pReader.Close();
            pDatos.desconectar();
        }

        protected override void btnCargar_Click(object sender, EventArgs e)
        {
            if (validadorCampos())
            {
                Empleado emp = new Empleado();
                emp.pNombre = txtNombre.Text;
                emp.pApellido = txtApellido.Text;
                emp.pTipoDocumento = Convert.ToInt32(cboxTipoDocumento.SelectedValue);
                emp.pDocumento = Convert.ToDouble(txtDocumento.Text);
                emp.pfecNacimiento = dtpFecNac.Value;
                if (banderaNuevo)
                {
                    string queryInsert = string.Format("insert into empleados(nombre, apellido, id_tipo_documento, documento,fec_nac ) " +
                                                        "values('{0}','{1}',{2},{3}, '{4}')",
                                                        emp.pNombre, emp.pApellido, emp.pTipoDocumento, emp.pDocumento, emp.pfecNacimiento);
                    pDatos.actualizar(queryInsert);
                }
                else
                {
                    int i = pLstboxObjetivo.SelectedIndex;
                    string queryUpdate = string.Format("update empleados " +
                                                        "set nombre='{0}', apellido='{1}', id_tipo_documento={2}, documento={3}, fec_nac='{4}' " +
                                                        "where id_empleado={5}",
                                                        emp.pNombre, emp.pApellido, emp.pTipoDocumento, emp.pDocumento, emp.pfecNacimiento,
                                                        aEmpleados[i].pIdentificacion);
                    
                    pDatos.actualizar(queryUpdate);
                }
            }
            limpiarCampos();
            habilitarBotones(true);
            habilitarCampos(false);
            banderaNuevo = false;
            cargarArray("Empleados");
            cargarLista(aEmpleados, cEmpleado);

        }

        public void txtBox_SoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        protected override void btnBorrar_Click(object sender, EventArgs e)
        {

            DialogResult condicion = MessageBox.Show("Esta seguro que desea borrar este Empleado?", "Atencion!", MessageBoxButtons.YesNo,
             MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            if (condicion == DialogResult.Yes)
            {
                string queryDelete = string.Format("delete empleados where documento={0}", aEmpleados[pLstboxObjetivo.SelectedIndex].pDocumento);
                pDatos.actualizar(queryDelete);
                cargarArray("Empleados");
                cargarLista(aEmpleados, cEmpleado);
                limpiarCampos();
            }
        }

        protected override void lstBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNombre.Text = aEmpleados[pLstboxObjetivo.SelectedIndex].pNombre;
            txtApellido.Text = aEmpleados[pLstboxObjetivo.SelectedIndex].pApellido;
            txtDocumento.Text = aEmpleados[pLstboxObjetivo.SelectedIndex].pDocumento.ToString();
            cboxTipoDocumento.SelectedValue = aEmpleados[pLstboxObjetivo.SelectedIndex].pTipoDocumento;
            dtpFecNac.Value = aEmpleados[pLstboxObjetivo.SelectedIndex].pfecNacimiento;
        }

        protected override void btnImprimir_Click(object sender, EventArgs e)
        {
            formRPTempleados reporteForm = new formRPTempleados();
            reporteForm.ShowDialog();
        }

    }
}
