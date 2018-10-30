using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces.Responses
{
   public class RegistradoIncidencia
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public int TipoId { get; set; }
        public string Tipo { get; set; }
        public string Gravedad { get; set; }
        public string Estado { get; set; }
    }
}
