using System;
using System.Collections.Generic;

namespace Projecta.MODELS;

public partial class Certificaciones
{
    public int IdCertificacion { get; set; }

    public string? Nombre { get; set; }

    public DateTime? FechaRealizado { get; set; }

    public DateTime? FechaVigencia { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual ICollection<CasoCertificaciones> CasoCertificaciones { get; set; } = new List<CasoCertificaciones>();

    public virtual ICollection<UsuarioCertificaciones> UsuarioCertificaciones { get; set; } = new List<UsuarioCertificaciones>();
}
