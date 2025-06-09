using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecta.DTO
{
    public class CasoDTO
    {
        public int IdCaso { get; set; }

        public string? Nombre { get; set; }

        public bool? Urgente { get; set; }

        public bool? EsActivo { get; set; }

        public string? FechaRegistro { get; set; }

    }
}
