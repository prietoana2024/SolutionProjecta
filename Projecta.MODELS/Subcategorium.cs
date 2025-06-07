using System;
using System.Collections.Generic;

namespace Projecta.MODELS;

public partial class Subcategorium
{
    public int IdSubCategoria { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<CategoriaSubCategoria> CategoriaSubCategoria { get; set; } = new List<CategoriaSubCategoria>();
}
