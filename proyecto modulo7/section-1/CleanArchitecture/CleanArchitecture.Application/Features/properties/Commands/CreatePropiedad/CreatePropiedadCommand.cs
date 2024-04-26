using MediatR;


namespace CleanArchitecture.Application.Features.properties.Commands.CreatePropiedad
{
     public class CreatePropiedadCommand: IRequest<long>
     {
          public string Descripcion { get; set; } = string.Empty;
          public string Direccion { get; set; } = string.Empty;
          public Boolean Esverificado { get; set; } = false;
          public long? TipoPropiedadId { get; set; } 
          public long? CiudadId { get; set; }
          public string? Estado { get; set; }
     }
}
