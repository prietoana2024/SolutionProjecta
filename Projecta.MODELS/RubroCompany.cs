using System;
using System.Collections.Generic;

namespace Projecta.MODELS;

public partial class RubroCompany
{
    public int IdRubroCompany { get; set; }

    public int? IdRubro { get; set; }

    public int? IdCompany7 { get; set; }

    public virtual Company? IdCompany7Navigation { get; set; }

    public virtual Rubro? IdRubroNavigation { get; set; }
}
