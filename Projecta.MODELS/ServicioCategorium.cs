using System;
using System.Collections.Generic;

namespace Projecta.MODELS;

public partial class ServicioCategorium
{
    public int IdServicioCategoria { get; set; }

    public int? IdServicio { get; set; }

    public int? IdCategoria { get; set; }

    public virtual Categoria? IdCategoriaNavigation { get; set; }

    public virtual Servicio? IdServicioNavigation { get; set; }
}
