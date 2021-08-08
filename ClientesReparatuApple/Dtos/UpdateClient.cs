using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientesReparatuApple.Dtos
{
    public class UpdateClient
    {

        public int Id_cliente { get; set; }
        public string nombre_cliente { get; set; }

        public string documento_cliente { get; set; }
        public string tipo_documento { get; set; }
        public string correo_cliente { get; set; }
        public DateTime fecha_nacimiento_cli { get; set; }
        public string Acepto_Registro { get; set; }
        public string terminos_condiciones { get; set; }

        public string telefono_cliente { get; set; }
        public string telefono2_cliente { get; set; }

        public string passwords { get; set; }


    }
}
