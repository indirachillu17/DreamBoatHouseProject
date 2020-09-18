using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_DreamVacationSpot_Backend_.Models
{
    public class TripBooking
    {
        public int TripBookingID { get; set; }

        public  DateTime DateTimeYearFormat { get; set; }
        
        public string TripName { get; set; }
        

        public  int NumberOfPeople { get; set; }

        public double TotalCost { get; set; }
        

    }
}
