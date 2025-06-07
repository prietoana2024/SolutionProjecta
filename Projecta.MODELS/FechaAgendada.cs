using System;
using System.Collections.Generic;

namespace Projecta.MODELS;

public partial class FechaAgendada
{
    public int IdFechaAgendada { get; set; }

    public DateTime? FechaInicio { get; set; }

    public DateTime? FechaFin { get; set; }

    public int? NumeroDias { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual ICollection<CasoAgendada> CasoAgendada { get; set; } = new List<CasoAgendada>();
}
