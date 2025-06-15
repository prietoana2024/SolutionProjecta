using Projecta.DTO;
using Projecta.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecta.DLL.Services.Contrato
{
    public interface IBancoService
    {
        Task<List<BancoDTO>> GetAll();

        Task<BancoDTO> Create(BancoDTO model);

        Task<bool> Update(BancoDTO model);

        Task<bool> Delete(int id);
    }
}
