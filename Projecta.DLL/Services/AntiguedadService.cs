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
    public class AntiguedadService:IAntiguedadService
    {
        private readonly IMapper _mapper;

        private readonly IGenericRepository<Antiguedad> _antiguedadRepository;

        public async Task<List<AntiguedadDTO>> GetAll()
        {
            try
            {
                var listTime = await _antiguedadRepository.GetAll();
                return _mapper.Map<List<AntiguedadDTO>>(listTime.ToList());
            }
            catch { throw; }
        }
    }
}
