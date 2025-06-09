using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecta.MODELS
{
    public class Estado
    {
        public int IdEstado { get; set; }

        public string? Nombre { get; set; }

        public DateTime? FechaRegistro { get; set; }

        public virtual ICollection<DetalleVenta> DetalleVenta { get; } = new List<DetalleVenta>();
    }
}
