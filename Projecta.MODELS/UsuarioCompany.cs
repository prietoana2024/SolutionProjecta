using System;
using System.Collections.Generic;

namespace Projecta.MODELS;

public partial class UsuarioCompany
{
    public int IdUsuarioCompany { get; set; }

    public int? IdUsuario { get; set; }

    public int? IdCompany { get; set; }

    public virtual Company? IdCompanyNavigation { get; set; }

    public virtual Usuario? IdUsuarioNavigation { get; set; }
}
