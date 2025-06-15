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

namespace Projecta.DLL.Servicios
{
    public class BarrioService:IBarrioService
    {
        private readonly IGenericRepository<Barrio> _barrioRepositorio;


        private readonly IMapper _mapper;

        public BarrioService(IGenericRepository<Barrio> barrioRepositorio, IMapper mapper)
        {
            _barrioRepositorio = barrioRepositorio;
            _mapper = mapper;
        }


        public async Task<List<BarrioDTO>> Lista()
        {
            try
            {

                var querybarrio = await _barrioRepositorio.GetAll();
                return _mapper.Map<List<BarrioDTO>>(querybarrio.ToList());

            }
            catch
            {
                throw;
            }
        }
        public async Task<BarrioDTO> Crear(BarrioDTO modelo)
        {
            try
            {
                var barrioCreado = await _barrioRepositorio.Create(_mapper.Map<Barrio>(modelo));
                if (barrioCreado.IdBarrio == 0)
                {
                    throw new TaskCanceledException("No se pudo crear el barrio");
                }
                return _mapper.Map<BarrioDTO>(barrioCreado);

            }
            catch
            {
                throw;
            }
        }

        public async Task<bool> Editar(BarrioDTO modelo)
        {
            try
            {
                var barrioModelo = _mapper.Map<Barrio>(modelo);
                var barrioEncontrado = await _barrioRepositorio.Get(u => u.IdBarrio == barrioModelo.IdBarrio);
                if (barrioEncontrado == null)
                {
                    throw new TaskCanceledException("No existe el barrio");
                }
                barrioEncontrado.Nombre = barrioModelo.Nombre;

                bool respuesta = await _barrioRepositorio.Update(barrioEncontrado);
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

        public async Task<bool> Eliminar(int id)
        {
            try
            {
                var barrioEncontrado = await _barrioRepositorio.Get(p => p.IdBarrio == id);
                if (barrioEncontrado == null)
                {
                    throw new TaskCanceledException("El Barrio no existe");
                }
                bool respuesta = await _barrioRepositorio.Delete(barrioEncontrado);
                if (respuesta == false)
                {
                    throw new TaskCanceledException("El barrio no se elimino con exito");
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
