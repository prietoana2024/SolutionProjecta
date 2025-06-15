using AutoMapper;
using Projecta.DAL.Repository.Interfaces;
using Projecta.DLL.Services.Contrato;
using Projecta.DTO;
using Projecta.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecta.DLL.Services
{
    public class RolService:IRolService
    {

        private readonly IMapper _mapper;

        private readonly IGenericRepository<Rol> _rolRepository;

        public RolService(IMapper mapper, IGenericRepository<Rol> rolRepository)
        {
            _mapper = mapper;
            _rolRepository = rolRepository;
        }

        public async Task<List<RolDTO>> GetAll()
        {
            try 
            {
                var listRoles=await _rolRepository.GetAll();
                return _mapper.Map<List<RolDTO>>(listRoles.ToList());
            } 
            catch { throw; }       
        }
    }
}
