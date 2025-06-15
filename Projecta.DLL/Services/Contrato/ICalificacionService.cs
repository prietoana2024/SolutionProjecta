using Projecta.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecta.DLL.Services.Contrato
{
    public interface ICalificacionService
    {
        Task<List<CalificacionDTO>> GetAll();
        Task<CalificacionDTO> Create(CalificacionDTO modelo);
        Task<bool> Update(CalificacionDTO modelo);
        Task<bool> Delete(int id);
    }
}
