using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FrejyaBåtHuset_WebAPI_Backend.Models;

namespace FrejyaBåtHuset_WebAPI_Backend.Data
{
    public class FrejyaBåtHuset_WebAPI_BackendContext : DbContext
    {
        public FrejyaBåtHuset_WebAPI_BackendContext (DbContextOptions<FrejyaBåtHuset_WebAPI_BackendContext> options)
            : base(options)
        {
        }

        public DbSet<FrejyaBåtHuset_WebAPI_Backend.Models.BåtHusetBokning> BåtHusetBokning { get; set; }

        public DbSet<FrejyaBåtHuset_WebAPI_Backend.Models.Användare> Användare { get; set; }

        public DbSet<FrejyaBåtHuset_WebAPI_Backend.Models.Andraaktiviteter> Andraaktiviteter { get; set; }
    }
}
