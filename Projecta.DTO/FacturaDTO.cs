using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecta.DTO
{
    public class FacturaDTO
    {
        public int IdFactura { get; set; }

        public string? NumeroDocumento { get; set; }

        public decimal? Total { get; set; }

        public int? IdTipoPago { get; set; }

        public string? FechaRegistro { get; set; }
    }
}
