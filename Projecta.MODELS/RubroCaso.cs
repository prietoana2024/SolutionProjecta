using System;
using System.Collections.Generic;

namespace Projecta.MODELS;

public partial class RubroCaso
{
    public int IdRubroCaso { get; set; }

    public int? IdRubro { get; set; }

    public int? IdCaso { get; set; }

    public virtual Caso? IdCasoNavigation { get; set; }

    public virtual Rubro? IdRubroNavigation { get; set; }
}
