using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecta.DTO
{
    public class EncuestaDTO
    {
        public int IdEncuesta { get; set; }

        public string? Nombre { get; set; }

        public string? Descripcion { get; set; }

        public int? IdCategoria { get; set; }

        public int? IdEvidencia { get; set; }

        public string? FechaRegistro { get; set; }
    }
}
