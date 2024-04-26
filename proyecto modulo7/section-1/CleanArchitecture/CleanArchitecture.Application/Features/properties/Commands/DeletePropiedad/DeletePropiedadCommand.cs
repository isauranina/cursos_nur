using MediatR;


namespace CleanArchitecture.Application.Features.properties.Commands.DeletePropiedad
{
     public class DeletePropiedadCommand : IRequest
     {        
          public int Id { get; set; }
          
     }
}
