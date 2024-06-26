﻿using CleanArchitecture.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain
{
     public class Ciudad : BaseDomainModel
     {
         
          public string? Descripcion { get; set; }
          public long PaisId { get; set; }
          public virtual Pais? Pais { get; set; }
          public string? Estado { get; set; }
     }
}
