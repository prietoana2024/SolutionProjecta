using System;
using System.Collections.Generic;

namespace Projecta.MODELS;

public partial class Banco
{
    public int IdBanco { get; set; }

    public int? NumeroCuenta { get; set; }

    public string? NombreBanco { get; set; }

    public string? Titular { get; set; }

    public bool? EsActivo { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual ICollection<UsuarioBanco> UsuarioBancos { get; set; } = new List<UsuarioBanco>();
}
