using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CambiaContrasena.Dtos
{
    public class ActualizaClaveCliente
    {
        public int Id_cliente { get; set; }
        public string passwords { get; set; }
    }
}
