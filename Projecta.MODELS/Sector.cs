using System;
using System.Collections.Generic;

namespace Projecta.MODELS;

public partial class Sector
{
    public int IdSector { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<Company> Companies { get; set; } = new List<Company>();
}
