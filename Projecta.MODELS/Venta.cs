﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Projecta.MODELS
{
    public class Venta
    {
        public int IdVenta { get; set; }

        public string? NumeroDocumento { get; set; }

        public string? TipoPago { get; set; }

        public decimal? Total {  get; set; }

        public DateTime? FechaRegistro { get; set; }


        public virtual ICollection<DetalleVenta> DetalleVenta { get; } = new List<DetalleVenta>();
      
    }
}
