using System;
using System.Collections.Generic;

namespace Projecta.MODELS;

public partial class Regimen
{
    public int IdRegimen { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<Company> Companies { get; set; } = new List<Company>();
}
