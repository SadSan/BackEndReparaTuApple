using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Segumiento_Servicio.Dtos
{
    public class InsertSeguimiento
    {
        public string nombre_seguimiento { get; set; }

        public string descripcion { get; set; }

        public int id_equipo { get; set; }

        public int Idusuario { get; set; }
        public string nombre_cliente { get; set; }

        public string celular_cliente { get; set; }

        public string direccion_cliente { get; set; }

        public string confirmacion_cliente { get; set; }

        public string reporte_falla { get; set; }

        public string referencia_equipo { get; set; }

        public string modelo { get; set; }

        public string disco { get; set; }

        public string Ob_cliente { get; set; }

        public string valor_negociado { get; set; }

        public string correo_cliente { get; set; }

        public int cod_seguimiento { get; set; }

    }
}
