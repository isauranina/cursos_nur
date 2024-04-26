using AutoMapper;
using CleanArchitecture.Application.Contracts.Infrastructure;
using CleanArchitecture.Application.Contracts.Persistence;
using CleanArchitecture.Application.Models;
using CleanArchitecture.Domain;
using MediatR;
using Microsoft.Extensions.Logging;
using System.IO;

namespace CleanArchitecture.Application.Features.properties.Commands.CreatePropiedad
{
     public class CreatePropiedadCommandHandler : IRequestHandler<CreatePropiedadCommand, long>
     {
          private readonly IUnitOfWork _unitOfWork;          
          private readonly IMapper _mapper;
          private readonly IEmailService _emailservice;
          private readonly ILogger<CreatePropiedadCommandHandler> _logger;

          public CreatePropiedadCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, IEmailService emailservice, ILogger<CreatePropiedadCommandHandler> logger)
          {

               _unitOfWork = unitOfWork;
               _mapper = mapper;
               _emailservice = emailservice;
               _logger = logger;
          }

          public async Task<long> Handle(CreatePropiedadCommand request, CancellationToken cancellationToken)
          {
               var PropiedadEntity = _mapper.Map<Propiedad>(request);  

               _unitOfWork.PropiedadRepository.AddEntity(PropiedadEntity);

               var result = await _unitOfWork.Complete();

               if (result <= 0)
               {
                    throw new Exception($"No se pudo insertar el record");
               }

               _logger.LogInformation($" {PropiedadEntity.Id} fue creado existosamente");

               await SendEmail(PropiedadEntity);

               return PropiedadEntity.Id;
          }
          private async Task SendEmail(Propiedad propiedad)
          {
               var email = new Email
               {
                    To = "bnbnur@gmail.com",
                    Body = "Se añadio una nueva propiedad",
                    Subject = "Mensaje de notificacion"
               };

               try
               {
                    await _emailservice.SendEmail(email);
               }
               catch (Exception ex)
               {
                    _logger.LogError($"El envio de Email no tubo exito {propiedad.Id}");
               }

          }
     }
}
