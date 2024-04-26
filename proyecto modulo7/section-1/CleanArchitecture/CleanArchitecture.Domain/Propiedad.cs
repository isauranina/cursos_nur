using CleanArchitecture.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain
{
    public class Propiedad : BaseDomainModel
    {
        public string? Descripcion { get; set; }
        public string Direccion { get; set; } = string.Empty;
        public Boolean Esverificado { get; set; } = false;
        public long? TipoPropiedadId { get; set; }
        public virtual TipoPropiedad? TipoPropiedad { get; set; }
        public long? CiudadId { get; set; }
        public virtual Ciudad? Ciudad { get; set; }
        public string? Estado { get; set; }
    }
}
