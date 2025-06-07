using System;
using System.Collections.Generic;

namespace Projecta.MODELS;

public partial class UsuarioCertificaciones
{
    public int IdUsuarioCertificacion { get; set; }

    public int? IdCertificacion { get; set; }

    public int? IdUsuario { get; set; }

    public virtual Certificaciones? IdCertificacionNavigation { get; set; }

    public virtual Usuario? IdUsuarioNavigation { get; set; }
}
