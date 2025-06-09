using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecta.DTO
{
    public class NumeroDocumentoDTO
    {
        public int IdNumeroDocumento { get; set; }

        public int UltimoNumero { get; set; }

        public int? IdDocumento { get; set; }

        public string? FechaRegistro { get; set; }
    }
}
