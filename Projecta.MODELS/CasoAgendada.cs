using System;
using System.Collections.Generic;

namespace Projecta.MODELS;

public partial class CasoAgendada
{
    public int IdCasoAgendada { get; set; }

    public int? IdCaso { get; set; }

    public int? IdFechaAgendada { get; set; }

    public virtual Caso? IdCasoNavigation { get; set; }

    public virtual FechaAgendada? IdFechaAgendadaNavigation { get; set; }
}
