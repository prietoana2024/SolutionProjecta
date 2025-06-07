using System;
using System.Collections.Generic;

namespace Projecta.MODELS;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string? NombreCompleto { get; set; }

    public string? Correo { get; set; }

    public string? Clave { get; set; }

    public decimal? Balance { get; set; }

    public int? IdPersona { get; set; }

    public int? IdRol { get; set; }

    public int? IdDocumento { get; set; }

    public int? IdCategoria { get; set; }

    public bool? EsActivo { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual Categoria? IdCategoriaNavigation { get; set; }

    public virtual TipoDocumento? IdDocumentoNavigation { get; set; }

    public virtual Persona? IdPersonaNavigation { get; set; }

    public virtual Rol? IdRolNavigation { get; set; }

    public virtual ICollection<UsuarioBanco> UsuarioBancos { get; set; } = new List<UsuarioBanco>();

    public virtual ICollection<UsuarioCalificacion> UsuarioCalificacions { get; set; } = new List<UsuarioCalificacion>();

    public virtual ICollection<UsuarioCertificaciones> UsuarioCertificaciones { get; set; } = new List<UsuarioCertificaciones>();

    public virtual ICollection<UsuarioChat> UsuarioChats { get; set; } = new List<UsuarioChat>();

    public virtual ICollection<UsuarioCompany> UsuarioCompanies { get; set; } = new List<UsuarioCompany>();

    public virtual ICollection<UsuarioNivel> UsuarioNivels { get; set; } = new List<UsuarioNivel>();
}
