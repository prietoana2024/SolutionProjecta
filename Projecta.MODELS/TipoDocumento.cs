using System;
using System.Collections.Generic;

namespace Projecta.MODELS;

public partial class TipoDocumento
{
    public int IdDocumento { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<NumeroDocumento> NumeroDocumentos { get; set; } = new List<NumeroDocumento>();

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
