using System;
using System.Collections.Generic;

namespace Projecta.MODELS;

public partial class Impuesto
{
    public int IdImpuesto { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<CotizacionImpuesto> CotizacionImpuestos { get; set; } = new List<CotizacionImpuesto>();

    public virtual ICollection<FacturaImpuesto> FacturaImpuestos { get; set; } = new List<FacturaImpuesto>();
}
