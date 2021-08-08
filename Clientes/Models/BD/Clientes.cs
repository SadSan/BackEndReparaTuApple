using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clientess.Repository
{
    public class Clientes
    { 
        public int Id_cliente { get; set; }

        public string nombre_cliente { get; set; }
        public string documento_cliente { get; set; }
        public string tipo_documento { get; set; }

        public string correo_cliente { get; set; }

        public DateTime fecha_nacimiento { get; set; }
        public string Acepto_Registro { get; set; }

        public string terminos_condiciones { get; set; }
        public string telefono_cliente { get; set; }

        public string telefono2_cliente { get; set; }


    }
}
