using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecta.DTO
{
    public class UsuarioDTO
    {
        public int IdUsuario { get; set; }

        public string? NombreCompleto { get; set; }

        public string? Correo { get; set; }

        public string? Clave { get; set; }

        public decimal? Balance { get; set; }

        public int? IdPersona { get; set; }

        public string? PersonaDescripcion { get; set; }


        public int? IdRol { get; set; }

        public string? RolDescripcion { get; set; }


        public int? IdDocumento { get; set; }

        public string? DocumentoDescripcion { get; set; }


        public int? IdCategoria { get; set; }

        public string? CategoriaDescripcion { get; set; }


        public bool? EsActivo { get; set; }

        public string? FechaRegistro { get; set; }

        public virtual ICollection<BancoDTO> UsuarioBancos { get; set; } = new List<BancoDTO>();

        public virtual ICollection<CalificacionDTO> UsuarioCalificacions { get; set; } = new List<CalificacionDTO>();

        public virtual ICollection<CertificacionesDTO> UsuarioCertificaciones { get; set; } = new List<CertificacionesDTO>();

        public virtual ICollection<ChatDTO> UsuarioChats { get; set; } = new List<ChatDTO>();

        public virtual ICollection<CompanyDTO> UsuarioCompanies { get; set; } = new List<CompanyDTO>();

        public virtual ICollection<NivelDificultadDTO> UsuarioNivels { get; set; } = new List<NivelDificultadDTO>();

    }
}
