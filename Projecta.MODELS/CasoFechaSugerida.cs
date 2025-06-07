using System;
using System.Collections.Generic;

namespace Projecta.MODELS;

public partial class CasoFechaSugerida
{
    public int IdCasoFechaSugerida { get; set; }

    public int? IdCaso { get; set; }

    public int? IdFecha { get; set; }

    public virtual Caso? IdCasoNavigation { get; set; }

    public virtual FechaSugerida? IdFechaNavigation { get; set; }
}
