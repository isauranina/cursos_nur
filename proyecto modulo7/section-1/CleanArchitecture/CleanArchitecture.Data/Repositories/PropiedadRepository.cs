using CleanArchitecture.Application.Contracts.Persistence;
using CleanArchitecture.Domain;
using CleanArchitecture.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infrastructure.Repositories
{
     public class PropiedadRepository :RepositoryBase <Propiedad>, IPropiedadRepository
     {
          public PropiedadRepository(PgSqlDbContext context) : base(context)
          { }

          public async Task<Propiedad> GetPropiedadByCiudad(long ciudadId)
          {
               return await _context.Propiedades!.Where(o => o.CiudadId == ciudadId).FirstOrDefaultAsync();
          }

          public async Task<IEnumerable<Propiedad>> GetPropiedadVerificado()
          {
               return await _context.Propiedades!.Where(v => v.Esverificado).ToListAsync();
          }
     }
}
