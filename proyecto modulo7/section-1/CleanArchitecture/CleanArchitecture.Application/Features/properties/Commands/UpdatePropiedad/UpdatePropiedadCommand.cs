﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.properties.Commands.UpdatePropiedad
{
     public class UpdatePropiedadCommand:IRequest
     {
          public int Id { get; set; }
          public string Descripcion { get; set; } = string.Empty;
          public string Direccion { get; set; } = string.Empty;
          public Boolean Esverificado { get; set; } = true;
          public long TipoPropiedadId { get; set; } = 1;
          public long CiudadId { get; set; } = 1;
          public string Estado { get; set; } = "AC";
     }
}
