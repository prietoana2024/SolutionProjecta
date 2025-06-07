using System;
using System.Collections.Generic;

namespace Projecta.MODELS;

public partial class DetalleVenta
{
    public int IdDetalleVenta { get; set; }

    public int? IdFactura { get; set; }

    public int? IdCaso { get; set; }

    public int? Cantidad { get; set; }

    public decimal? Precio { get; set; }

    public decimal? Total { get; set; }

    public virtual Caso? IdCasoNavigation { get; set; }

    public virtual Factura? IdFacturaNavigation { get; set; }
}
