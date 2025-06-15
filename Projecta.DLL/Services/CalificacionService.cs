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
    public  class CalificacionService:ICalificacionService
    {
        private readonly IGenericRepository<Calificacion> _calificacionRepositorio;


        private readonly IMapper _mapper;

        public CalificacionService(IGenericRepository<Calificacion> calificacionRepositorio, IMapper mapper)
        {
            _calificacionRepositorio = calificacionRepositorio;
            _mapper = mapper;
        }


        public async Task<List<CalificacionDTO>> GetAll()
        {
            try
            {

                var querycalificacion = await _calificacionRepositorio.GetAll();
                var listacalificacions = querycalificacion.ToList();
                return _mapper.Map<List<CalificacionDTO>>(listacalificacions).ToList();

            }
            catch
            {
                throw;
            }
        }
        public async Task<CalificacionDTO> Create(CalificacionDTO modelo)
        {
            try
            {
                var calificacionCreado = await _calificacionRepositorio.Create(_mapper.Map<Calificacion>(modelo));
                if (calificacionCreado.IdCalificacion == 0)
                {
                    throw new TaskCanceledException("No se pudo crear el calificacion");
                }
                return _mapper.Map<CalificacionDTO>(calificacionCreado);

            }
            catch
            {
                throw;
            }
        }

        public async Task<bool> Update(CalificacionDTO modelo)
        {
            try
            {
                var calificacionModelo = _mapper.Map<Calificacion>(modelo);
                var calificacionEncontrado = await _calificacionRepositorio.Get(u => u.IdCalificacion == calificacionModelo.IdCalificacion);
                if (calificacionEncontrado == null)
                {
                    throw new TaskCanceledException("No existe el calificacion");
                }
                calificacionEncontrado.Numero = calificacionModelo.Numero;

                bool respuesta = await _calificacionRepositorio.Update(calificacionEncontrado);
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

        public async Task<bool> Delete(int id)
        {
            try
            {
                var calificacionEncontrado = await _calificacionRepositorio.Get(p => p.IdCalificacion == id);
                if (calificacionEncontrado == null)
                {
                    throw new TaskCanceledException("El calificacion no existe");
                }
                bool respuesta = await _calificacionRepositorio.Delete(calificacionEncontrado);
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
    }
}
