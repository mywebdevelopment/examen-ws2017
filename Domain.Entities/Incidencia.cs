using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Incidencia : BaseEntity
    {
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public int TipoId { get; set; }
        public Tipo Tipo { get; set; }
        public Gravedad Gravedad { get; set; }
    }
}
