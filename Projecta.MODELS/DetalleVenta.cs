using System;
using System.Collections.Generic;

namespace Projecta.MODELS;

public partial class DetalleVenta
{
    public int IdDetalleVenta { get; set; }

    public int? IdFactura { get; set; }

    public int? IdProducto { get; set; }


    public int? IdCaso { get; set; }

    public int? Cantidad { get; set; }

    public decimal? Precio { get; set; }

    public decimal? Impuesto { get; set; }

    public decimal? Domicilio { get; set; }

    public decimal? Total { get; set; }

    public int? IdServicio { get; set; }


    public virtual Estado? IdEstadoNavigation { get; set; }

    public virtual Servicio? IdServicioNavigation { get; set; }

    public virtual Venta? IdVentaNavigation { get; set; }

    public virtual Caso? IdCasoNavigation { get; set; }

    public virtual Factura? IdFacturaNavigation { get; set; }

}
