using System;
using System.Collections.Generic;

namespace Projecta.MODELS;

public partial class CasoCertificaciones
{
    public int IdCasoCertificaciones { get; set; }

    public int? IdCertificacion { get; set; }

    public int? IdCaso { get; set; }

    public virtual Caso? IdCasoNavigation { get; set; }

    public virtual Certificaciones? IdCertificacionNavigation { get; set; }
}
