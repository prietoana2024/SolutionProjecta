using System;
using System.Collections.Generic;

namespace Projecta.MODELS;

public partial class FechaSugerida
{
    public int IdFecha { get; set; }

    public DateTime? FechaInicio { get; set; }

    public DateTime? FechaFin { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual ICollection<CasoFechaSugerida> CasoFechaSugerida { get; set; } = new List<CasoFechaSugerida>();
}
