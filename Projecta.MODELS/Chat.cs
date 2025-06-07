using System;
using System.Collections.Generic;

namespace Projecta.MODELS;

public partial class Chat
{
    public int IdChat { get; set; }

    public string? Numero { get; set; }

    public string? Titulo { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual ICollection<UsuarioChat> UsuarioChats { get; set; } = new List<UsuarioChat>();
}
