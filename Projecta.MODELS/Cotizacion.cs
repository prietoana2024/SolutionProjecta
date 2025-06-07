using System;
using System.Collections.Generic;

namespace Projecta.MODELS;

public partial class Cotizacion
{
    public int IdCotizacion { get; set; }

    public string? Nombre { get; set; }

    public string? Detalle { get; set; }

    public decimal? Total { get; set; }

    public bool? EsAprobado { get; set; }

    public int? IdTipoPago { get; set; }

    public int? IdCaso { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual ICollection<CotizacionImpuesto> CotizacionImpuestos { get; set; } = new List<CotizacionImpuesto>();

    public virtual Caso? IdCasoNavigation { get; set; }

    public virtual TipoPago? IdTipoPagoNavigation { get; set; }
}
