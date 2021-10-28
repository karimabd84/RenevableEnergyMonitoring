﻿using REM.Model.Entities;
using System.Data.Entity;

namespace REM.Data
{
    public class REMContext:DbContext
    {
        public REMContext():base("DefaultConnection")
        {

        }

        public DbSet<Meteo> Meteos { get; set; }
        public DbSet<Onduleur> Onduleurs { get; set; }
    }
}
