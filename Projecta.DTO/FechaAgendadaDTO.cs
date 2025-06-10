using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecta.DTO
{
    public class FechaAgendadaDTO
    {
        public int IdFechaAgendada { get; set; }

        public string? FechaInicio { get; set; }

        public string? FechaFin { get; set; }

        public int? NumeroDias { get; set; }

        public string? FechaRegistro { get; set; }

        public virtual ICollection<CasoDTO> Caso { get; set; } = new List<CasoDTO>();
    }
}
