using System;
using System.Collections.Generic;

namespace Projecta.MODELS;

public partial class ServicioRiesgo
{
    public int IdServicioRiesgo { get; set; }

    public int? IdServicio { get; set; }

    public int? IdRiesgo { get; set; }

    public virtual Riesgo? IdRiesgoNavigation { get; set; }

    public virtual Servicio? IdServicioNavigation { get; set; }
}
