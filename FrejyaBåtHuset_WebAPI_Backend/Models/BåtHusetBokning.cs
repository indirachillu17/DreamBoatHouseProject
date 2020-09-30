using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrejyaBåtHuset_WebAPI_Backend.Models
{
    public class BåtHusetBokning
    {

        public int BåtHusetBokningID { get; set; }

        public int DiscoverBoatHouse { get; set; }

        public DateTime BoatStart { get; set; }
        public DateTime BoatEnd { get; set; }
       
        public string OtherActivities { get; set; }

        public string Restaurant { get; set; }
        public decimal PriceOfTicket { get; set; }
        public int NoOfPersons { get; set; }
    }
}
