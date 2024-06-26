﻿using CleanArchitecture.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Contracts.Persistence
{
    public interface IPropiedadRepository : IAsyncRepository<Propiedad>
    {
        Task<Propiedad> GetPropiedadByCiudad(long ciudadId);
        Task<IEnumerable<Propiedad>> GetPropiedadVerificado();
    }
}
