using System;
using System.Collections.Generic;

namespace Projecta.MODELS;

public partial class CasoEvidencia
{
    public int IdCasoEvidencia { get; set; }

    public int? IdEvidencia { get; set; }

    public int? IdCaso { get; set; }

    public virtual Caso? IdCasoNavigation { get; set; }

    public virtual Evidencia? IdEvidenciaNavigation { get; set; }
}
