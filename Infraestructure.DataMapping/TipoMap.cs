using Domain.Entities;
using Domain.Entities.Enum;
using Services.Interfaces.Requests;
using Services.Interfaces.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure.DataMapping
{
   public static class TipoMap
    {
        static public Tipo ToEntity(this CrearTipo crearTipo)
        {
           
            return new Tipo()
            {
                
                Descripcion  = crearTipo.Descripcion
            };
        }


        static public RegistradoTipo ToDTO(this Tipo tipo)
        {
            return new RegistradoTipo()
            {
                Id = tipo.Id,
                Descripcion = tipo.Descripcion,
                Estado = tipo.Estado.Equals(Estado.Activo) ? "Activo" : "Inactivo"
            };
        }

        private static bool isNotValidType(string type)
        {
            return !type.Equals("Activo") && !type.Equals("Inactivo");
        }
    }
}
