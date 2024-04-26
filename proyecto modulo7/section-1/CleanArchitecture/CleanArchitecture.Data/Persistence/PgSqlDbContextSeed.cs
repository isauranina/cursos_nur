using CleanArchitecture.Domain;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Persistence
{
    public class PgSqlDbContextSeed
    {
        public static async Task SeedAsync(PgSqlDbContext context, ILogger<PgSqlDbContextSeed> logger)
        {
            if (!context.TipoPropiedades!.Any())
            {
                context.TipoPropiedades!.AddRange(GetPreconfiguredPropiedad());
                await context.SaveChangesAsync();
                logger.LogInformation("Estamos insertando nuevos records al db {context}", typeof(PgSqlDbContext).Name);
            }

        }
        private static IEnumerable<TipoPropiedad> GetPreconfiguredPropiedad()
        {
            return new List<TipoPropiedad>
            {
                new TipoPropiedad {Descripcion= "Depa",Estado = "AC" },
                new TipoPropiedad {Descripcion = "Casa", Estado = "AC" },
            };

        }
    }
}
