using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FrejyaBåtHuset_WebAPI_Backend.Models
{
    public class OtherActivities
    {
        [Key]
        public int AndraaktiviteterID { get; set; }
        public string NameOfactivity { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public string ActivitiesTime { get; set; }
        public string ActivityType { get; set; }
    }
}
