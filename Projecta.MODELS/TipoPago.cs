using System;
using System.Collections.Generic;

namespace Projecta.MODELS;

public partial class TipoPago
{
    public int IdTipoPago { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<Cotizacion> Cotizacions { get; set; } = new List<Cotizacion>();

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();
}
