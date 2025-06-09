using Microsoft.EntityFrameworkCore;
using Projecta.DAL.Repository.Interfaces;
using Projecta.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecta.DAL.Repository
{
    public class VentaRepository:GenericRepository<Venta>,IVentaRepository
    {
        private readonly BdProjectaGroupContext _bdcontext;

        public VentaRepository(BdProjectaGroupContext bdcontext):base(bdcontext) 
        {
        
            _bdcontext = bdcontext;
        }

        public async Task<Venta> Registrar(Venta modelo)
        {//CREAMOS UNA VARIABLE
            Venta ventaGenerada = new();
            //si dentro de la logica ocurre un error la linea siguiente tiene que reestablecer todo al principio
            using (var transaction = _bdcontext.Database.BeginTransaction())
            {
                try
                {
                    foreach (DetalleVenta dv in modelo.DetalleVenta)
                    {
                        Servicio servicio_encontrado = _bdcontext.Servicios.Where(p => p.IdServicio == dv.IdServicio).First();

                        _bdcontext.Servicios.Update(servicio_encontrado);
                    }
                    await _bdcontext.SaveChangesAsync();
                    NumeroDocumento correlativo = _bdcontext.NumeroDocumentos.First();
                    correlativo.UltimoNumero = correlativo.UltimoNumero + 1;
                    correlativo.FechaRegistro = DateTime.Now;
                    _bdcontext.NumeroDocumentos.Update(correlativo);
                    await _bdcontext.SaveChangesAsync();
                    //0001
                    int CantidadDigitos = 4;
                    string ceros = string.Concat(Enumerable.Repeat("0", CantidadDigitos));
                    string numeroVenta = ceros + correlativo.UltimoNumero.ToString();
                    numeroVenta = numeroVenta.Substring(numeroVenta.Length - CantidadDigitos, CantidadDigitos);
                    modelo.NumeroDocumento = numeroVenta;
                    modelo.FechaRegistro = DateTime.Now;

                    await _bdcontext.AddAsync(modelo);
                    await _bdcontext.SaveChangesAsync();

                    ventaGenerada = modelo;
                    //la transaccion puede finalizar sin nigun problema
                    transaction.Commit();
                }
                catch
                {
                    //devolvera todo como estaba antes
                    transaction.Rollback();
                    //devuelve el error
                    throw;
                }
                return ventaGenerada;
            }
            //  throw new NotImplementedException();
        }
    }
}
