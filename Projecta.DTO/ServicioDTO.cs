using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecta.DTO
{
    public class ServicioDTO
    {
        public int IdServicio { get; set; }

        public string? Nombre { get; set; }

        public string? PrecioTexto { get; set; }

        public int? DuracionMinutos { get; set; }

        public int? NumeroPersonas { get; set; }

        public bool? Supervision { get; set; }

        public bool? Acompanamiento { get; set; }

        public bool? EsActivo { get; set; }

        public string? FechaRegistro { get; set; }
    }
}
