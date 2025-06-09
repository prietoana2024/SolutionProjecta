using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecta.DTO
{
    public class SimulacionDTO
    {
        public int IdSimulacion { get; set; }

        public string? Nombre { get; set; }

        public string? Fecha { get; set; }

        public int? IdCategoria { get; set; }

        public int? IdCaso { get; set; }

    }
}
