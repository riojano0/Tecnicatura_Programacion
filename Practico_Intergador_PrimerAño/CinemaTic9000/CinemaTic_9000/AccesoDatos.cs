using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CinemaTic_9000_v2
{
    public class AccesoDatos
    {   
        

        string stringConection;
        SqlConnection conexion;
        SqlCommand command;
        SqlDataReader reader;
        DataTable tabla;

        public string pStrincConection { set { pStrincConection = value; } get { return stringConection; } }
        public SqlDataReader pReader { set { reader = value; } get { return reader; } }

        public AccesoDatos()
        {
            conexion = new SqlConnection();
            command = new SqlCommand();
            tabla = new DataTable();
            reader = null;

            string hostName = System.Net.Dns.GetHostName();
            if (hostName == "riojano0-PC")
            {
                stringConection = @"Data Source = riojano0-pc\sqlexpress;
                                    Initial Catalog = DB_Practico_Integrador; 
                                    Persist Security Info = False; Trusted_Connection=Yes";
            }
            else
            {
                stringConection = @"Data Source = DESKTOP-9E55766\SQLEXPRESS;
                                    Initial Catalog = PracticoIntegrador_MMRP; 
                                    Persist Security Info = False; Trusted_Connection=Yes";
            }
        }

        public AccesoDatos(string strCon)
        {
            conexion = new SqlConnection();
            command = new SqlCommand();
            tabla = new DataTable();
            reader = null;
            stringConection = strCon;
        }

        public void conectar()
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.ConnectionString = stringConection;
                conexion.Open();
                command.Connection = conexion;
                command.CommandType = CommandType.Text;
            }
        }

        public void desconectar()
        {
            conexion.Close();
            conexion.Dispose();
        }

        public DataTable consultarTabla(string tablaObjetivo)
        {
            tabla = new DataTable();
            conectar();
            command.CommandText = string.Format("select * from {0}", tablaObjetivo);
            tabla.Load(command.ExecuteReader());
            desconectar();
            return tabla;
        }

        public DataTable consultar(string sqlstring)
        {
            tabla = new DataTable();
            conectar();
            command.CommandText = sqlstring;
            tabla.Load(command.ExecuteReader());
            desconectar();
            return tabla;
        }

        public void leerTabla(string tablaObjetivo)
        {
            conectar();
            command.CommandText = string.Format("select * from {0}", tablaObjetivo);
            reader = command.ExecuteReader();
        }

        public void actualizar(string sqlstring)
        {
            conectar();
            command.CommandText = sqlstring;
            command.ExecuteNonQuery();
            desconectar();
        }
    }
}
