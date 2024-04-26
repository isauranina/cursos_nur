﻿using CleanArchitecture.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain
{
    public class Servicio : BaseDomainModel
     {
       
        public string? Descripcion { get; set; } 
     
        public string? Estado { get; set; }

      
    }
}
