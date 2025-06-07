using System;
using System.Collections.Generic;

namespace Projecta.MODELS;

public partial class ServicioProducto
{
    public int IdServicioProductos { get; set; }

    public int? IdServicio { get; set; }

    public int? IdProducto { get; set; }

    public virtual Producto? IdProductoNavigation { get; set; }

    public virtual Servicio? IdServicioNavigation { get; set; }
}
