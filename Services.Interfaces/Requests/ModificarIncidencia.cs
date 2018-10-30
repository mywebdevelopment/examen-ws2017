using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces.Requests
{
   public class ModificarIncidencia
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public int TipoId { get; set; }
        public string Gravedad { get; set; }
        public string Estado { get; set; }
    }
}
