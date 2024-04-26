using AutoMapper;
using CleanArchitecture.Application.Features.properties.Commands.CreatePropiedad;
using CleanArchitecture.Application.Features.properties.Commands.DeletePropiedad;
using CleanArchitecture.Application.Features.properties.Commands.UpdatePropiedad;
using CleanArchitecture.Application.Features.properties.Queries.GetPropiedadList;

using CleanArchitecture.Domain;

namespace CleanArchitecture.Application.Mappings
{
     public class MappingProfile : Profile
     {
          public MappingProfile()
          {
               
               CreateMap<Propiedad, PropiedadVm>();

               CreateMap<CreatePropiedadCommand, Propiedad>();
               CreateMap<UpdatePropiedadCommand, Propiedad>();
               CreateMap<DeletePropiedadCommand, Propiedad>();

          }
     }
}
