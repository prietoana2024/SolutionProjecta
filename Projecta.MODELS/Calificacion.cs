using System;
using System.Collections.Generic;

namespace Projecta.MODELS;

public partial class Calificacion
{
    public int IdCalificacion { get; set; }

    public int? Numero { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual ICollection<UsuarioCalificacion> UsuarioCalificacions { get; set; } = new List<UsuarioCalificacion>();
}
