using System;
using System.Collections.Generic;

namespace Projecta.MODELS;

public partial class Antiguedad
{
    public int IdAntiguedad { get; set; }

    public string? Valor { get; set; }

    public virtual ICollection<Company> Companies { get; set; } = new List<Company>();
}
