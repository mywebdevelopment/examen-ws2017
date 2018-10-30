using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
   public class Tipo: BaseEntity
    {
        public string Descripcion { get; set; }
        public List<Incidencia> Incidencias { get; set; }
    }
}
