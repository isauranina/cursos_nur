using FluentValidation;

namespace CleanArchitecture.Application.Features.properties.Commands.UpdatePropiedad
{
     public class UpdatePropiedadCommandValidator: AbstractValidator<UpdatePropiedadCommand>
     {
          public UpdatePropiedadCommandValidator()
          {
               RuleFor(p => p.Descripcion)
                     .NotEmpty().WithMessage("La {Direccion} no puede estar en blanco");

          }

     }
}
