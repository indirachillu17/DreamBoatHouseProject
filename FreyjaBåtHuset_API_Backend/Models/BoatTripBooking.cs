using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreyjaBåtHuset_API_Backend.Models
{
    public class BoatTripBooking
    {

        public int BoatTripBookingID { get; set; }

        public int DiscoverBoatHouse { get; set; }

        //public DateTime DateTime { get; set; }

        public string OtherActivities { get; set; }
    }
}
