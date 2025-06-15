using Projecta.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecta.DLL.Services.Contrato
{
    public interface IRolService
    {
        Task<List<RolDTO>> GetAll();
    }
}
