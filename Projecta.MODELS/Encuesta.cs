using System;
using System.Collections.Generic;

namespace Projecta.MODELS;

public partial class Encuesta
{
    public int IdEncuesta { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public int? IdCategoria { get; set; }

    public int? IdEvidencia { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual ICollection<EncuestaEvidencia> EncuestaEvidencia { get; set; } = new List<EncuestaEvidencia>();

    public virtual Categoria? IdCategoriaNavigation { get; set; }

    public virtual Evidencia? IdEvidenciaNavigation { get; set; }
}
