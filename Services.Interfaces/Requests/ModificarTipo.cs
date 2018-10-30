using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces.Requests
{
   public class ModificarTipo
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
    }
}
