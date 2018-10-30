using Domain.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities.Common
{
   public class BaseEntity
    {
        public int Id { get; set; }
        public Estado Estado { get; set; } = Estado.Activo;
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public DateTime FechaModificacion { get; set; } = DateTime.Now;
    }
}
