﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecta.DTO
{
    public class ReporteDTO
    {

        public string? numeroDocumento { get; set; }

        public string? TipoPago { get; set; }

        public string? FechaRegistro { get; set; }

        public string? TotalVenta { get; set; }

        public string? Producto { get; set; }

        public int? Cantidad { get; set; }

        public string? Precio { get; set; }

        public string? Total { get; set; }

        public string? EntregasExito { get; set; }

        public string? DiomiciliosRegistrados { get; set; }
    }
}
