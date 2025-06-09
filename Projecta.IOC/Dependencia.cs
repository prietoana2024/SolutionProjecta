using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Projecta.DAL;
using Projecta.DAL.Repository;
using Projecta.DAL.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecta.IOC
{
    public static class Dependencia
    {

        public static void Injection(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BdProjectaGroupContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("cadenaSql"));

            });
            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IVentaRepository, VentaRepository>();
        }
    }
}
