using System;
using System.Collections.Generic;

namespace Projecta.MODELS;

public partial class Divisa
{
    public int IdDivisa { get; set; }

    public string? Nombre { get; set; }

    public bool? EsActivo { get; set; }
}
