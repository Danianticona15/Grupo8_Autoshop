using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class datcliente
    {
        public static object Instancia { get; set; }

        public List<entcliente> ListarCliente()
        {
            SqlCommand cmd = null;
            List<entcliente> lista = new List<entcliente>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListaCliente", cn);
                cmd = new SqlCommand("select * from Cliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entcliente Cli = new entcliente();
                    Cli.ClienteID = Convert.ToInt32(dr["ClienteID"]);
                    Cli.Nombre = dr["Nombre"].ToString();
                    Cli.Direccion = dr["Direccion"].ToString();
                    Cli.Telefono = Convert.ToInt32(dr["Telefono"]);
                    lista.Add(Cli);
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }
    }
}
