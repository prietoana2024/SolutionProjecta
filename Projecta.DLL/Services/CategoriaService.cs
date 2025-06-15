using AutoMapper;
using Projecta.DAL.Repository.Interfaces;
using Projecta.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecta.DLL.Services
{
    public class CategoriaService
    {
        private readonly IMapper _mapper;
        private readonly IGenericRepository<Categoria> _categoriaRepository;
    }
}
