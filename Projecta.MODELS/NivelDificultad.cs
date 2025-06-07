using System;
using System.Collections.Generic;

namespace Projecta.MODELS;

public partial class NivelDificultad
{
    public int IdNivel { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<UsuarioNivel> UsuarioNivels { get; set; } = new List<UsuarioNivel>();
}
