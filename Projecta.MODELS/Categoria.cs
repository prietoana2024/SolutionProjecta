using System;
using System.Collections.Generic;

namespace Projecta.MODELS;

public partial class Categoria
{
    public int IdCategoria { get; set; }

    public string? Nombre { get; set; }

    public bool? EsActivo { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual ICollection<CategoriaSubCategoria> CategoriaSubCategoria { get; set; } = new List<CategoriaSubCategoria>();

    public virtual ICollection<Encuesta> Encuesta { get; set; } = new List<Encuesta>();

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();

    public virtual ICollection<ServicioCategorium> ServicioCategoria { get; set; } = new List<ServicioCategorium>();

    public virtual ICollection<Simulacion> Simulacions { get; set; } = new List<Simulacion>();

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
