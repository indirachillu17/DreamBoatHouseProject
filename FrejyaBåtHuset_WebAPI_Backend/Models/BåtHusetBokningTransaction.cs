using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FrejyaBåtHuset_WebAPI_Backend.Models
{
    public class BåtHusetBokningTransaction
    {
        [Key]
        public int BåtHusetBokningTransactionID { get; set; }

        public int UserId { get; set; }
        //public string UserName { get; set; }
        
        public int DiscoverBoatHouse { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal BoatTripPrice { get; set; }
        public DateTime BoatTripDate { get; set; }
        public string BoatStartTime { get; set; }
        public string BoatEndTime { get; set; }

        public string OtherActivities { get; set; }

        public string Restaurant { get; set; }
        //public decimal PriceOfTicket { get; set; }

        public string Beverages { get; set; }
        public int NoOfPersons { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalPrice { get; set; }
        //public string Status { get; set; }

    }
}
