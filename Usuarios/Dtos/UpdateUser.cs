using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Usuarios.Dtos
{
    public class UpdateUser
    {
        public int Idusuario { get; set; }
        public string nombre { get; set; }

        public string apellido { get; set; }
        public string clave { get; set; }
        public string codigo { get; set; }
        public string cedula { get; set; }
        public DateTime fechanacimiento { get; set; }
        public string tipocontrato { get; set; }
        public string correo { get; set; }
        public int id_estado { get; set; }

        public int id_rol { get; set; }
        public string telefono { get; set; }
    }
}
