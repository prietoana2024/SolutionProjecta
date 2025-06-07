using System;
using System.Collections.Generic;

namespace Projecta.MODELS;

public partial class FacturaImpuesto
{
    public int IdFacturaImpuestos { get; set; }

    public int? IdFactura { get; set; }

    public int? IdImpuesto { get; set; }

    public virtual Factura? IdFacturaNavigation { get; set; }

    public virtual Impuesto? IdImpuestoNavigation { get; set; }
}
