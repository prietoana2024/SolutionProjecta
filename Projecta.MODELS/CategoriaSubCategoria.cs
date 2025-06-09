using System;
using System.Collections.Generic;

namespace Projecta.MODELS;

public partial class CategoriaSubCategoria
{
    public int IdCategoriaSubCategoria { get; set; }

    public int? IdCategoria { get; set; }

    public int? IdSubCategoria { get; set; }

    public virtual Categoria? IdCategoriaNavigation { get; set; }

    public virtual Subcategoria? IdSubCategoriaNavigation { get; set; }
}
