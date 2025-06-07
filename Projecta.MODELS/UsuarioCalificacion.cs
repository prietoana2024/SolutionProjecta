using System;
using System.Collections.Generic;

namespace Projecta.MODELS;

public partial class UsuarioCalificacion
{
    public int IdUsuarioCalificacion { get; set; }

    public int? IdCalificacion { get; set; }

    public int? IdUsuario { get; set; }

    public virtual Calificacion? IdCalificacionNavigation { get; set; }

    public virtual Usuario? IdUsuarioNavigation { get; set; }
}
