using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecta.DTO
{
    public class CertificacionesDTO
    {
        public int IdCertificacion { get; set; }

        public string? Nombre { get; set; }

        public string? FechaRealizado { get; set; }

        public string? FechaVigencia { get; set; }

        public string? FechaRegistro { get; set; }
    }
}
