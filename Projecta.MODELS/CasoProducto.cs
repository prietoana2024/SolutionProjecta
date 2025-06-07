using System;
using System.Collections.Generic;

namespace Projecta.MODELS;

public partial class CasoProducto
{
    public int IdCasoProducto { get; set; }

    public int? IdProducto { get; set; }

    public int? IdCaso { get; set; }

    public virtual Caso? IdCasoNavigation { get; set; }

    public virtual Producto? IdProductoNavigation { get; set; }
}
