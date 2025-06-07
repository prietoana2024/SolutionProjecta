using System;
using System.Collections.Generic;

namespace Projecta.MODELS;

public partial class RubroProducto
{
    public int IdRubroProductos { get; set; }

    public int? IdRubro { get; set; }

    public int? IdProducto { get; set; }

    public virtual Producto? IdProductoNavigation { get; set; }

    public virtual Rubro? IdRubroNavigation { get; set; }
}
