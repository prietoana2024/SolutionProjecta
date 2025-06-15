using Projecta.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Projecta.DLL.Servicios.Contrato
{
    public interface ICategoriaService
    {
        Task<List<CategoriaDTO>> GetAll();
        Task<CategoriaDTO> Create(CategoriaDTO modelo);
        Task<bool> Update(CategoriaDTO modelo);
        Task<bool> Delete(int id);
    }
}
