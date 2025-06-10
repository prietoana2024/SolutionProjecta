using System;
using System.Collections.Generic;

namespace Projecta.MODELS;

public partial class Producto
{
    public int IdProducto { get; set; }

    public string? Nombre { get; set; }


    public int? Cantidad { get; set; }

    public int? Stock { get; set; }

    public decimal? Precio { get; set; }

    public bool? EsProveedor { get; set; }

    public int? IdCompany { get; set; }

    public int? IdCategoria { get; set; }

    public int? IdCaso { get; set; }

    public DateTime? FechaInventario { get; set; }

    public decimal? Total { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual ICollection<CasoProducto> CasoProductos { get; set; } = new List<CasoProducto>();

    public virtual Caso? IdCasoNavigation { get; set; }

    public virtual Categoria? IdCategoriaNavigation { get; set; }

    public virtual Company? IdCompanyNavigation { get; set; }

    public virtual ICollection<RubroProducto> RubroProductos { get; set; } = new List<RubroProducto>();

    public virtual ICollection<ServicioProducto> ServicioProductos { get; set; } = new List<ServicioProducto>();
}
