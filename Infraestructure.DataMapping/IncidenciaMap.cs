using Domain.Entities;
using Domain.Entities.Enum;
using Services.Interfaces.Requests;
using Services.Interfaces.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure.DataMapping
{
   public static class IncidenciaMap
    {
        static public Incidencia ToEntity(this CrearIncidencia crearIncidencia)
        {
            if (isNotValidType(crearIncidencia.Gravedad))
                throw new Exception("Client type is not recoignizeW");

            return new Incidencia()
            {
                Descripcion=crearIncidencia.Descripcion,
                Fecha=crearIncidencia.Fecha,
                Gravedad= crearIncidencia.Gravedad.Equals("Leve") ? Gravedad.Leve : Gravedad.Moderado,
                TipoId =crearIncidencia.TipoId
            };
        }

        private static bool isNotValidType(string type)
        {
            return !type.Equals("Leve") && !type.Equals("Moderado");
        }

        static public RegistradoIncidencia ToDTO(this Incidencia incidencia)
        {
            return new RegistradoIncidencia()
            {
                Id = incidencia.Id,
                Descripcion= incidencia.Descripcion,
                Fecha = incidencia.Fecha,
                TipoId = incidencia.TipoId,
                Tipo =incidencia.Tipo.Descripcion,
                Estado = incidencia.Estado.Equals(Estado.Activo) ? "Activo" : "Inactivo",
                Gravedad  = incidencia.Gravedad.Equals(Gravedad.Leve) ? "Leve" : "Moderado"
            };
        }
    }
}
