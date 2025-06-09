using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecta.DTO
{
    public class EvidenciaDTO
    {
        public int IdEvidencia { get; set; }

        public string? Foto { get; set; }

        public string? Url { get; set; }

        public string? TipoArchivo { get; set; }

        public string? Descripcion { get; set; }

        public string? FechaRegistro { get; set; }
    }
}
