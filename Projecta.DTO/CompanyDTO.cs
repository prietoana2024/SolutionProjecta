using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecta.DTO
{
    public class CompanyDTO
    {
        public int IdCompany { get; set; }

        public string? Nombre { get; set; }

        public int? Nit { get; set; }

        public string? RazonSocial { get; set; }

        public string? Correo { get; set; }

        public string? CorreoFacturacion { get; set; }

        public string? Direccion { get; set; }

        public string? Fijo { get; set; }

        public int? Pbx { get; set; }

        public string? Celular { get; set; }

        public int? CodigoCiiu { get; set; }

        public int? IdSector { get; set; }

        public int? IdAntiguedad { get; set; }

        public int? IdPersona { get; set; }

        public int? IdRegimen { get; set; }

        public bool? EsActivo { get; set; }

        public string? FechaRegistro { get; set; }
    }
}
