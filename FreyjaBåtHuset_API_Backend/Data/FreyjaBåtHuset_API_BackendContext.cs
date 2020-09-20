using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FreyjaBåtHuset_API_Backend.Models;

namespace FreyjaBåtHuset_API_Backend.Data
{
    public class FreyjaBåtHuset_API_BackendContext : DbContext
    {
        public FreyjaBåtHuset_API_BackendContext (DbContextOptions<FreyjaBåtHuset_API_BackendContext> options)
            : base(options)
        {
        }

        public DbSet<FreyjaBåtHuset_API_Backend.Models.BoatTripBooking> BoatTripBooking { get; set; }
    }
}
