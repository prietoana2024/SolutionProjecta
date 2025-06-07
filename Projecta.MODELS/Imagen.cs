using System;
using System.Collections.Generic;

namespace Projecta.MODELS;

public partial class Imagen
{
    public int IdImagen { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<FileData> FileData { get; set; } = new List<FileData>();
}
