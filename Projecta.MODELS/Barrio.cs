using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecta.MODELS
{
    public class Barrio
    {
        public int IdBarrio { get; set; }

        public string? Nombre { get; set; }

        public string? Url { get; set; }

        public virtual ICollection<Domicilio> Domicilios { get; } = new List<Domicilio>();
    }
}
