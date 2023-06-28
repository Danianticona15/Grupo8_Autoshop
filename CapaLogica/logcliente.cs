using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaLogica
{
    public class logcliente
    {
        public List<entcliente> ListarCliente()
        {
            return Cliente.Instancia.ListarCliente();
        }
    }
}
