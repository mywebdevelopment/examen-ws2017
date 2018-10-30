using Domain.Entities;
using Domain.Entities.Enum;
using Infraestructure.DataMapping;
using Infraestructure.SQLServerRepository.IncidenciaDB;
using Services.Interfaces;
using Services.Interfaces.Common;
using Services.Interfaces.Requests;
using Services.Interfaces.Responses;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Services.Implementation.SqlPesistance
{
    public class TipoManagerSQL : ITipoManager
    {
        public RegistradoTipo Create(CrearTipo newRegister)
        {
            using (IncidenciaContext db = new IncidenciaContext())
            {
                Tipo tipoEntity = newRegister.ToEntity();
                db.Tipos.Add(tipoEntity);
                db.SaveChanges();
                return tipoEntity.ToDTO();
            }
        }

        public void Delete(int registerId)
        {
            using (IncidenciaContext db = new IncidenciaContext())
            {
                Tipo tipoToDelete = db.Tipos.Find(registerId);
                db.Entry(tipoToDelete).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public List<RegistradoTipo> List()
        {
            using (IncidenciaContext db = new IncidenciaContext())
            {
                return db.Tipos.ToList().Select(x => x.ToDTO()).ToList();
            }
        }

        public RegistradoTipo Search(int registerId)
        {
            using (IncidenciaContext db = new IncidenciaContext())
            {
                return db.Tipos.Find(registerId).ToDTO();
            }
        }

        public RegistradoTipo Update(ModificarTipo updateRegister)
        {
            using (IncidenciaContext db = new IncidenciaContext())
            {
                Tipo tipoToUpdate = db.Tipos.Find(updateRegister.Id);
                tipoToUpdate.Descripcion = updateRegister.Descripcion;
                tipoToUpdate.Estado = updateRegister.Estado.Equals("Activo") ? Estado.Activo : Estado.Inactivo;
                db.SaveChanges();
                return tipoToUpdate.ToDTO();
            }
                
        }
    }
}
