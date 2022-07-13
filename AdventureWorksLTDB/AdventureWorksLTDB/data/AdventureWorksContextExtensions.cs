using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventureWorksDBLT.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection; //IServiceCollection

namespace AdventureWorksDBLT.data
{
    public static class AdventureWorksContextExtensions
    {
        public static IServiceCollection AddAdventureWorksDBContext(this IServiceCollection services, string strCnx = "Data Source=DESKTOP-S0NQNAG;Initial Catalog=AdventureWorksLT2019;Integrated Security=false;User=sa;Password=GalileoPrueba;")
        {
            services.AddDbContext<AdventureWorksDB>(options => options.UseSqlServer(strCnx));
            return services;
        }
    }
}
