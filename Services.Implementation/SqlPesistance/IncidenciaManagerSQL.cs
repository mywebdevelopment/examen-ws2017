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
   public class IncidenciaManagerSQL : IIncidenciaManager
    {
        public RegistradoIncidencia Create(CrearIncidencia newRegister)
        {
            using (IncidenciaContext db = new IncidenciaContext())
            {
                Incidencia incidenciaEntity = newRegister.ToEntity();
                db.Incidencias.Add(incidenciaEntity);
                db.SaveChanges();
                return incidenciaEntity.ToDTO();
            }
        }

        public void Delete(int registerId)
        {
            using (IncidenciaContext db = new IncidenciaContext())
            {
                Incidencia incidenciaToDelete = db.Incidencias.Find(registerId);
                db.Entry(incidenciaToDelete).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public List<RegistradoIncidencia> List()
        {
            using (IncidenciaContext db = new IncidenciaContext())
            {

                return db.Incidencias.Include(b => b.Tipo).ToList().Select(x => x.ToDTO()).ToList();
            }
        }

        public RegistradoIncidencia Search(int registerId)
        {
             using (IncidenciaContext db = new IncidenciaContext())
            {
               // return db.Incidencias.Include(b => b.Tipo).Find(registerId).ToDTO();
                return db.Incidencias.Include(b => b.Tipo).Where(x => x.Id == registerId).First().ToDTO();
            }
        }

        public RegistradoIncidencia Update(ModificarIncidencia updateRegister)
        {
            using (IncidenciaContext db = new IncidenciaContext())
            {
                Incidencia  incidenciaToUpdate = db.Incidencias.Include(b => b.Tipo).Where(x => x.Id == updateRegister.Id).First();
                incidenciaToUpdate.Descripcion  = updateRegister.Descripcion;
                incidenciaToUpdate.Fecha  = updateRegister.Fecha;
                incidenciaToUpdate.Gravedad = updateRegister.Gravedad.Equals("Leve") ? Gravedad.Leve : Gravedad.Moderado;
                incidenciaToUpdate.TipoId = updateRegister.TipoId;
                incidenciaToUpdate.Estado = updateRegister.Estado.Equals("Activo") ? Estado.Activo : Estado.Inactivo;
                db.SaveChanges();
                return db.Incidencias.Include(b => b.Tipo).Where(x => x.Id == updateRegister.Id).First().ToDTO();
            }
        }
    }
}
