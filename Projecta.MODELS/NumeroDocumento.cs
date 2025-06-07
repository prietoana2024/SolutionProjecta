using System;
using System.Collections.Generic;

namespace Projecta.MODELS;

public partial class NumeroDocumento
{
    public int IdNumeroDocumento { get; set; }

    public int UltimoNumero { get; set; }

    public int? IdDocumento { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual TipoDocumento? IdDocumentoNavigation { get; set; }
}
