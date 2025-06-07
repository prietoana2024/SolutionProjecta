using System;
using System.Collections.Generic;

namespace Projecta.MODELS;

public partial class Riesgo
{
    public int IdRiesgo { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public int? IdEvidencia { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual ICollection<CasoRiesgo> CasoRiesgos { get; set; } = new List<CasoRiesgo>();

    public virtual Evidencia? IdEvidenciaNavigation { get; set; }

    public virtual ICollection<ServicioRiesgo> ServicioRiesgos { get; set; } = new List<ServicioRiesgo>();
}
