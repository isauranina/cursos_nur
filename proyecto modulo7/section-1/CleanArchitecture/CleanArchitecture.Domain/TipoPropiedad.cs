using CleanArchitecture.Domain.Common;

namespace CleanArchitecture.Domain
{
     public class TipoPropiedad : BaseDomainModel
     {         
          public string? Descripcion { get; set; } 

          public string? Estado { get; set; }
     }
}
