using System;
using System.Collections.Generic;

namespace Projecta.MODELS;

public partial class Company
{
    public int IdCompany { get; set; }

    public string? Nombre { get; set; }

    public int? Nit { get; set; }

    public string? RazonSocial { get; set; }

    public string? Correo { get; set; }

    public string? CorreoFacturacion { get; set; }

    public string? Direccion { get; set; }

    public string? Fijo { get; set; }

    public int? Pbx { get; set; }

    public string? Celular { get; set; }

    public int? CodigoCiiu { get; set; }

    public int? IdSector { get; set; }

    public int? IdAntiguedad { get; set; }

    public int? IdPersona { get; set; }

    public int? IdRegimen { get; set; }

    public bool? EsActivo { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual Antiguedad? IdAntiguedadNavigation { get; set; }

    public virtual Persona? IdPersonaNavigation { get; set; }

    public virtual Regimen? IdRegimenNavigation { get; set; }

    public virtual Sector? IdSectorNavigation { get; set; }

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();

    public virtual ICollection<RubroCompany> RubroCompanies { get; set; } = new List<RubroCompany>();

    public virtual ICollection<UsuarioCompany> UsuarioCompanies { get; set; } = new List<UsuarioCompany>();
}
