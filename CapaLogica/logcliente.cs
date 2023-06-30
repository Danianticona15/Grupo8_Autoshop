using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class logcliente
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logcliente _instancia = new logcliente();
        //privado para evitar la instanciación directa
        public static logcliente Instancia
        {
            get
            {
                return logcliente._instancia;
            }
        }
        #endregion singleton
       // public List<entcliente> ListaCliente()
        //{
            //return datcliente.Instancia.ListaCliente();
        //}
    }
}

