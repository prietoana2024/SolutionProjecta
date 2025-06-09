using System;
using System.Collections.Generic;

namespace Projecta.MODELS;

public partial class Servicio
{
    public int IdServicio { get; set; }

    public string? Nombre { get; set; }

    public decimal? Precio { get; set; }

    public int? DuracionMinutos { get; set; }

    public int? NumeroPersonas { get; set; }

    public bool? Supervision { get; set; }

    public bool? Acompanamiento { get; set; }

    public bool? EsActivo { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual ICollection<DetalleVenta> DetalleVenta { get; } = new List<DetalleVenta>();

    public virtual ICollection<ServicioCaso> ServicioCasos { get; set; } = new List<ServicioCaso>();

    public virtual ICollection<ServicioCategorium> ServicioCategoria { get; set; } = new List<ServicioCategorium>();

    public virtual ICollection<ServicioHerramienta> ServicioHerramienta { get; set; } = new List<ServicioHerramienta>();

    public virtual ICollection<ServicioProducto> ServicioProductos { get; set; } = new List<ServicioProducto>();

    public virtual ICollection<ServicioRiesgo> ServicioRiesgos { get; set; } = new List<ServicioRiesgo>();
}
