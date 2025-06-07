using System;
using System.Collections.Generic;

namespace Projecta.MODELS;

public partial class Caso
{
    public int IdCaso { get; set; }

    public string? Nombre { get; set; }

    public bool? Urgente { get; set; }

    public bool? EsActivo { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual ICollection<CasoAgendada> CasoAgendada { get; set; } = new List<CasoAgendada>();

    public virtual ICollection<CasoCertificaciones> CasoCertificaciones { get; set; } = new List<CasoCertificaciones>();

    public virtual ICollection<CasoEvidencia> CasoEvidencia { get; set; } = new List<CasoEvidencia>();

    public virtual ICollection<CasoFechaSugerida> CasoFechaSugerida { get; set; } = new List<CasoFechaSugerida>();

    public virtual ICollection<CasoHerramienta> CasoHerramienta { get; set; } = new List<CasoHerramienta>();

    public virtual ICollection<CasoProducto> CasoProductos { get; set; } = new List<CasoProducto>();

    public virtual ICollection<CasoRiesgo> CasoRiesgos { get; set; } = new List<CasoRiesgo>();

    public virtual ICollection<Cotizacion> Cotizacions { get; set; } = new List<Cotizacion>();

    public virtual ICollection<DetalleVenta> DetalleVenta { get; set; } = new List<DetalleVenta>();

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();

    public virtual ICollection<RubroCaso> RubroCasos { get; set; } = new List<RubroCaso>();

    public virtual ICollection<ServicioCaso> ServicioCasos { get; set; } = new List<ServicioCaso>();

    public virtual ICollection<Simulacion> Simulacions { get; set; } = new List<Simulacion>();
}
