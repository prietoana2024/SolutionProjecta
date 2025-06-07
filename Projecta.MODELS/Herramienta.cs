using System;
using System.Collections.Generic;

namespace Projecta.MODELS;

public partial class Herramienta
{
    public int IdHerramienta { get; set; }

    public string? Nombre { get; set; }

    public string? Marca { get; set; }

    public string? Foto { get; set; }

    public string? Url { get; set; }

    public int? Estado { get; set; }

    public virtual ICollection<CasoHerramienta> CasoHerramienta { get; set; } = new List<CasoHerramienta>();

    public virtual ICollection<ServicioHerramienta> ServicioHerramienta { get; set; } = new List<ServicioHerramienta>();
}
