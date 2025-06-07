using System;
using System.Collections.Generic;

namespace Projecta.MODELS;

public partial class Evidencia
{
    public int IdEvidencia { get; set; }

    public string? Foto { get; set; }

    public string? Url { get; set; }

    public string? TipoArchivo { get; set; }

    public string? Descripcion { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual ICollection<CasoEvidencia> CasoEvidencia { get; set; } = new List<CasoEvidencia>();

    public virtual ICollection<Encuesta> Encuesta { get; set; } = new List<Encuesta>();

    public virtual ICollection<EncuestaEvidencia> EncuestaEvidencia { get; set; } = new List<EncuestaEvidencia>();

    public virtual ICollection<Riesgo> Riesgos { get; set; } = new List<Riesgo>();
}
