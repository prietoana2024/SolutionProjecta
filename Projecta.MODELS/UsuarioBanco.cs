using System;
using System.Collections.Generic;

namespace Projecta.MODELS;

public partial class UsuarioBanco
{
    public int IdUsuarioBanco { get; set; }

    public int? IdBanco { get; set; }

    public int? IdUsuario { get; set; }

    public virtual Banco? IdBancoNavigation { get; set; }

    public virtual Usuario? IdUsuarioNavigation { get; set; }
}
