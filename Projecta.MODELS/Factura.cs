using System;
using System.Collections.Generic;

namespace Projecta.MODELS;

public partial class Factura
{
    public int IdFactura { get; set; }

    public string? NumeroDocumento { get; set; }

    public decimal? Total { get; set; }

    public int? IdTipoPago { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual ICollection<DetalleVenta> DetalleVenta { get; set; } = new List<DetalleVenta>();

    public virtual ICollection<FacturaImpuesto> FacturaImpuestos { get; set; } = new List<FacturaImpuesto>();

    public virtual TipoPago? IdTipoPagoNavigation { get; set; }
}
