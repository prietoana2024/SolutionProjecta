using System;
using System.Collections.Generic;

namespace Projecta.MODELS;

public partial class UsuarioNivel
{
    public int IdUsuarioNivel { get; set; }

    public int? IdNivel { get; set; }

    public int? IdUsuario { get; set; }

    public virtual NivelDificultad? IdNivelNavigation { get; set; }

    public virtual Usuario? IdUsuarioNavigation { get; set; }
}
