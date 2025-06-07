using System;
using System.Collections.Generic;

namespace Projecta.MODELS;

public partial class Rubro
{
    public int IdRubro { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<RubroCaso> RubroCasos { get; set; } = new List<RubroCaso>();

    public virtual ICollection<RubroCompany> RubroCompanies { get; set; } = new List<RubroCompany>();

    public virtual ICollection<RubroProducto> RubroProductos { get; set; } = new List<RubroProducto>();
}
