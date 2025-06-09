using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecta.MODELS
{
    public class DivisaProducto
    {
        public int IdDivisaProducto { get; set; }

        public int? IdDivisa { get; set; }

        public int? IdProducto { get; set; }

        public virtual Divisa? IdDivisaNavigation { get; set; }

        public virtual Producto? IdProductoNavigation { get; set; }
    }
}
