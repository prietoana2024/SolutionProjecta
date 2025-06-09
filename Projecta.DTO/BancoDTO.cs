using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecta.DTO
{
    public class BancoDTO
    {
        public int IdBanco { get; set; }

        public int? NumeroCuenta { get; set; }

        public string? NombreBanco { get; set; }

        public string? Titular { get; set; }

        public bool? EsActivo { get; set; }

        public string? FechaRegistro { get; set; }
    }
}
