using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FrejaBåthuset_WebAPI_Backend.Models;

namespace FreyjaBåthuset_WebAPI_Backend.Data
{
    public class FreyjaBåthuset_WebAPI_BackendContext : DbContext
    {
        public FreyjaBåthuset_WebAPI_BackendContext (DbContextOptions<FreyjaBåthuset_WebAPI_BackendContext> options)
            : base(options)
        {
        }

        public DbSet<FrejaBåthuset_WebAPI_Backend.Models.BoatTripBooking> BoatTripBooking { get; set; }
    }
}
