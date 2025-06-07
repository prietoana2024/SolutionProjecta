using System;
using System.Collections.Generic;

namespace Projecta.MODELS;

public partial class EncuestaEvidencia
{
    public int IdEncuestaEvidencia { get; set; }

    public int? IdEncuesta { get; set; }

    public int? IdEvidencia { get; set; }

    public virtual Encuesta? IdEncuestaNavigation { get; set; }

    public virtual Evidencia? IdEvidenciaNavigation { get; set; }
}
