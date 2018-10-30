using Services.Implementation.SqlPesistance;
using Services.Interfaces;
using Services.Interfaces.Requests;
using Services.Interfaces.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Presentation.WebApi.Controllers.api
{
    public class IncidenciaController : ApiController
    {
        IIncidenciaManager _incidenciaManager;
        public IncidenciaController()
        {
            this._incidenciaManager = new IncidenciaManagerSQL();
        }

        [HttpPost]
        public RegistradoIncidencia Create(CrearIncidencia newRegister)
        {
            return this._incidenciaManager.Create(newRegister);
        }

        [HttpDelete]
        public void Delete(int registerId)
        {
             this._incidenciaManager.Delete(registerId);
        }

        [HttpGet]
        public List<RegistradoIncidencia> List()
        {
            return this._incidenciaManager.List();
        }

        [HttpGet]
        public RegistradoIncidencia Search(int registerId)
        {
            return this._incidenciaManager.Search(registerId);
        }

        [HttpPut]
        public RegistradoIncidencia Update(ModificarIncidencia updateRegister)
        {
            return this._incidenciaManager.Update(updateRegister);
        }
    }
}
