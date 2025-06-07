using System;
using System.Collections.Generic;

namespace Projecta.MODELS;

public partial class CasoRiesgo
{
    public int IdCasoRiesgo { get; set; }

    public int? IdRiesgo { get; set; }

    public int? IdCaso { get; set; }

    public virtual Caso? IdCasoNavigation { get; set; }

    public virtual Riesgo? IdRiesgoNavigation { get; set; }
}
