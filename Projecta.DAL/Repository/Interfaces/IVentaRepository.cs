﻿using Projecta.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecta.DAL.Repository.Interfaces
{
    public interface IVentaRepository:IGenericRepository<Venta>
    {
        Task<Venta> Registrar(Venta modelo);

    }
}
