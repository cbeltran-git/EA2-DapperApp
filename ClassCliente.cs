using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DapperApp
{
    public class ClassCliente
    {
        public int IdCliente { get; set; }
        public string NroDocumento { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
    }
}