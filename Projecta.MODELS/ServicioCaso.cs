using System;
using System.Collections.Generic;

namespace Projecta.MODELS;

public partial class ServicioCaso
{
    public int IdServicioCaso { get; set; }

    public int? IdServicio { get; set; }

    public int? IdCaso { get; set; }

    public virtual Caso? IdCasoNavigation { get; set; }

    public virtual Servicio? IdServicioNavigation { get; set; }
}
