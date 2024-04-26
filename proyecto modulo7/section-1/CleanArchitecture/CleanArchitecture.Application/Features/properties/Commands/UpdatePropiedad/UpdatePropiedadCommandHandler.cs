using AutoMapper;
using CleanArchitecture.Application.Contracts.Persistence;
using CleanArchitecture.Application.Exceptions;
using CleanArchitecture.Application.Features.properties.Commands.DeletePropiedad;
using CleanArchitecture.Domain;
using MediatR;
using Microsoft.Extensions.Logging;


namespace CleanArchitecture.Application.Features.properties.Commands.UpdatePropiedad
{
     public  class UpdatePropiedadCommandHandler: IRequest<UpdatePropiedadCommand>
     {
          private readonly IUnitOfWork _unitOfWork;
          
          private readonly IMapper _mapper;
          private readonly ILogger<DeletePropiedadCommandHandler> _logger;

          public UpdatePropiedadCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, Contracts.Infrastructure.IEmailService @object, ILogger<DeletePropiedadCommandHandler> logger)
          {
             
               _unitOfWork = unitOfWork;
               _mapper = mapper;
               _logger = logger;
          }

          public async Task<Unit> Handle(UpdatePropiedadCommand request, CancellationToken cancellationToken)
        {
           
            var PropiedadToUpdate = await _unitOfWork.PropiedadRepository.GetByIdAsync(request.Id);

            if (PropiedadToUpdate == null)
            {
                _logger.LogError($"No se encontro la propiedad id {request.Id}");
                throw new NotFoundException(nameof(Propiedad), request.Id);
            }

            _mapper.Map(request, PropiedadToUpdate, typeof(UpdatePropiedadCommand), typeof(Propiedad));

            

           _unitOfWork.PropiedadRepository.UpdateEntity(PropiedadToUpdate);

            await _unitOfWork.Complete();

            _logger.LogInformation($"La operacion fue exitosa actualizando la Propiedad {request.Id}");

            return Unit.Value;
        }
    }
}
