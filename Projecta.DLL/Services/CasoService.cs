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
    public class CasoService:ICasoService
    {
        private readonly IMapper _mapper;
        private readonly IGenericRepository<Caso> _caseRepository;

        public CasoService(IMapper mapper, IGenericRepository<Caso> caseRepository)
        {
            _mapper = mapper;
            _caseRepository = caseRepository;
        }
        public async Task<List<CasoDTO>> GetAll()
        {
            try
            {

                var querycaso = await _caseRepository.GetAll();
                var listacasos = querycaso.ToList();
                return _mapper.Map<List<CasoDTO>>(listacasos.ToList());

            }
            catch
            {
                throw;
            }
        }


        public async Task<CasoDTO> Create(CasoDTO model)
        {
            try
            {
                var casoCreado = await _caseRepository.Create(_mapper.Map<Caso>(model));
                if (casoCreado.IdCaso == 0)
                {
                    throw new TaskCanceledException("No se pudo crear el caso");
                }
                return _mapper.Map<CasoDTO>(casoCreado);

            }
            catch
            {
                throw;
            }
        }

        public async Task<bool> Delete(int id)
        {
            try
            {
                var casoEncontrado = await _caseRepository.Get(p => p.IdCaso == id);
                if (casoEncontrado == null)
                {
                    throw new TaskCanceledException("El calificacion no existe");
                }
                bool respuesta = await _caseRepository.Delete(casoEncontrado);
                if (respuesta == false)
                {
                    throw new TaskCanceledException("El calificacion no se elimino con exito");
                }
                return respuesta;
            }
            catch
            {
                throw;
            }
        }

       

        public async Task<bool> Update(CasoDTO model)
        {
            try
            {
                var casoModelo = _mapper.Map<Caso>(model);
                var casoEncontrado = await _caseRepository.Get(u => u.IdCaso == casoModelo.IdCaso);
                if (casoEncontrado == null)
                {
                    throw new TaskCanceledException("No existe el calificacion");
                }
                casoEncontrado.Nombre = casoModelo.Nombre;

                bool respuesta = await _caseRepository.Update(casoEncontrado);
                if (respuesta == false)
                {
                    throw new TaskCanceledException("No se pudo editar");
                }
                return respuesta;
            }
            catch
            {
                throw;
            }
        }
    }
}
