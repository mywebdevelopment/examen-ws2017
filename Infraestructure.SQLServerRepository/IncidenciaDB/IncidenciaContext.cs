using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Text;

namespace Infraestructure.SQLServerRepository.IncidenciaDB
{
   public class IncidenciaContext:DbContext
    {
        public DbSet<Tipo> Tipos { get; set; }
        public DbSet<Incidencia> Incidencias { get; set; }
        public IncidenciaContext() : base("IncidenciaDb")
        {

        }
      
    }
}
