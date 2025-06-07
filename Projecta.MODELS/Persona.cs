using System;
using System.Collections.Generic;

namespace Projecta.MODELS;

public partial class Persona
{
    public int IdPersona { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<Company> Companies { get; set; } = new List<Company>();

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
