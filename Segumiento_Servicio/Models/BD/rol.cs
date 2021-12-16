using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Segumiento_Servicio_cliente.Models.BD
{
    public class rol
    {
        [Key]

        public int id_rol { get; set; }

        public string nombre_rol { get; set;}


    }
}
