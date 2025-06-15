using Projecta.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecta.DLL.Services.Contrato
{
    public interface ICasoService
    {
        Task<List<CasoDTO>> GetAll();

        Task<CasoDTO> Create(CasoDTO model);

        Task<bool> Update(CasoDTO model);

        Task<bool> Delete(int id);
    }
}
