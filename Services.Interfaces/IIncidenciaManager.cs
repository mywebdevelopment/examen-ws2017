using Services.Interfaces.Common;
using Services.Interfaces.Requests;
using Services.Interfaces.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces
{
   public interface IIncidenciaManager:IGeneralManager<CrearIncidencia,ModificarIncidencia, RegistradoIncidencia>
    {
    }
}
