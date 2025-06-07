using System;
using System.Collections.Generic;

namespace Projecta.MODELS;

public partial class CasoHerramienta
{
    public int IdCasoHerramientas { get; set; }

    public int? IdHerramienta { get; set; }

    public int? IdCaso { get; set; }

    public virtual Caso? IdCasoNavigation { get; set; }

    public virtual Herramienta? IdHerramientaNavigation { get; set; }
}
