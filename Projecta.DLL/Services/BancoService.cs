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
    public class BancoService:IBancoService
    {
        private readonly IMapper _mapper;
        private readonly IGenericRepository<Banco> _bankRepository;

        public BancoService(IMapper mapper, IGenericRepository<Banco> bankRepository)
        {
            _mapper = mapper;
            _bankRepository = bankRepository;
        }

        public async Task<List<BancoDTO>> GetAll()
        {
            try
            {

                var bankList = await _bankRepository.GetAll();
                return _mapper.Map<List<BancoDTO>>(bankList.ToList());

            }
            catch
            {
                throw;
            }
        }
        public async Task<BancoDTO> Create(BancoDTO model)
        {
            try
            {
                var bankCreate = await _bankRepository.Create(_mapper.Map<Banco>(model));
                if (bankCreate.IdBanco == 0)
                {
                    throw new TaskCanceledException("No se pudo crear el banco");
                }
                return _mapper.Map<BancoDTO>(bankCreate);

            }
            catch
            {
                throw;
            }
        }
        public async Task<bool> Update(BancoDTO model)
        {
            try
            {
                var bancoModelo = _mapper.Map<Banco>(model);
                var bancoEncontrado = await  _bankRepository.Get(u => u.IdBanco == bancoModelo.IdBanco);
                if (bancoEncontrado == null)
                {
                    throw new TaskCanceledException("No existe el Banco");
                }
                bancoEncontrado.Titular = bancoModelo.Titular;

                bool respuesta = await _bankRepository.Update(bancoEncontrado);
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
                var bancoEncontrado = await _bankRepository.Get(p => p.IdBanco == id);
                if (bancoEncontrado == null)
                {
                    throw new TaskCanceledException("El banco no existe");
                }
                bool respuesta = await _bankRepository.Delete(bancoEncontrado);
                if (respuesta == false)
                {
                    throw new TaskCanceledException("El banco no se elimino con exito");
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
