using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecta.DTO
{
    public class ProductoDTO
    {
        public int IdProducto { get; set; }

        public string? Nombre { get; set; }


        public int? Cantidad { get; set; }

        public int? Stock { get; set; }

        public string? PrecioTexto { get; set; }

        public bool? EsProveedor { get; set; }

        public int? IdCompany { get; set; }

        public int? IdCategoria { get; set; }

        public int? IdCaso { get; set; }

        public string? FechaInventario { get; set; }

        public string? TotalTexto { get; set; }

        public string? FechaRegistro { get; set; }
    }
}
