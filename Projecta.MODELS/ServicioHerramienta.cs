using System;
using System.Collections.Generic;

namespace Projecta.MODELS;

public partial class ServicioHerramienta
{
    public int IdServicioHerramientas { get; set; }

    public int? IdServicio { get; set; }

    public int? IdHerramienta { get; set; }

    public virtual Herramienta? IdHerramientaNavigation { get; set; }

    public virtual Servicio? IdServicioNavigation { get; set; }
}
