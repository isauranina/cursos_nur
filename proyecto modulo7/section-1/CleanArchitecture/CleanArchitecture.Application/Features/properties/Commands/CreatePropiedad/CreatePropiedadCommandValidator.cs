using FluentValidation;


namespace CleanArchitecture.Application.Features.properties.Commands.CreatePropiedad
{
     public class CreatePropiedadCommandValidator:AbstractValidator<CreatePropiedadCommand>
     {
          public CreatePropiedadCommandValidator()
          {
               RuleFor(p => p.Descripcion)
               .NotEmpty().WithMessage("{Descripcion} no puede estar en blanco")
               .NotNull();               

               RuleFor(p => p.Direccion)
                    .NotEmpty().WithMessage("La {Direccion} no puede estar en blanco");
          }
     }
}
