using System.ComponentModel.DataAnnotations;

namespace Segumiento_Servicio.Models.BD
{
    public class Seguimiento
    {
        [Key]
        public int id_seguimiento { get; set; }

        public string nombre_seguimiento { get; set; }

        public string descripcion { get; set; }

        public int id_cliente { get; set; }

        public int id_equipo { get; set; }
    }
}
