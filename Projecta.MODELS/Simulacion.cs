using System;
using System.Collections.Generic;

namespace Projecta.MODELS;

public partial class Simulacion
{
    public int IdSimulacion { get; set; }

    public string? Nombre { get; set; }

    public DateTime? Fecha { get; set; }

    public int? IdCategoria { get; set; }

    public int? IdCaso { get; set; }

    public virtual Caso? IdCasoNavigation { get; set; }

    public virtual Categoria? IdCategoriaNavigation { get; set; }
}
