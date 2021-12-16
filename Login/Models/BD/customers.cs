using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Login.Models.BD
{
    public class customers
    {
         [Key]
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

        public DateTime fecha_creacion_cli { get; set; }


        public DateTime fecha_actualizacion_cli { get; set; }


        public string passwords { get; set; }

    }
}
