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
    public class TipoController : ApiController
    {
        ITipoManager _tipoManager;
        public TipoController()
        {
            this._tipoManager = new TipoManagerSQL();
        }

        [HttpPost]
        public RegistradoTipo Create(CrearTipo newRegister)
        {
            return this._tipoManager.Create(newRegister);
        }

        [HttpDelete]
        public void Delete(int registerId)
        {
            this._tipoManager.Delete(registerId);
        }

        [HttpGet]
        public List<RegistradoTipo> List()
        {
            return this._tipoManager.List();
        }

        [HttpGet]
        public RegistradoTipo Search(int registerId)
        {
            return this._tipoManager.Search(registerId);
        }

        [HttpPut]
        public RegistradoTipo Update(ModificarTipo updateRegister)
        {
            return this._tipoManager.Update(updateRegister);
        }
    }
}
