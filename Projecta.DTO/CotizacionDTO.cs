using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecta.DTO
{
    public class CotizacionDTO
    {
        public int IdCotizacion { get; set; }

        public string? Nombre { get; set; }

        public string? Detalle { get; set; }

        public decimal? Total { get; set; }

        public bool? EsAprobado { get; set; }

        public int? IdTipoPago { get; set; }

        public int? IdCaso { get; set; }

        public string? FechaRegistro { get; set; }
    }
}
