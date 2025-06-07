using System;
using System.Collections.Generic;

namespace Projecta.MODELS;

public partial class CotizacionImpuesto
{
    public int IdCotizacionImpuestos { get; set; }

    public int? IdCotizacion { get; set; }

    public int? IdImpuesto { get; set; }

    public virtual Cotizacion? IdCotizacionNavigation { get; set; }

    public virtual Impuesto? IdImpuestoNavigation { get; set; }
}
