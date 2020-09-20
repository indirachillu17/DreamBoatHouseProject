using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace FrejaBåthuset_WebAPI_Backend.Models
{
    public class BoatTripBooking
    {
      
        public int TripID { get; set; }

        public int DiscoverBoatHouse{ get; set; }

        public int DateTime { get; set; }

        public int OtherActivities { get; set; }


    }
}
