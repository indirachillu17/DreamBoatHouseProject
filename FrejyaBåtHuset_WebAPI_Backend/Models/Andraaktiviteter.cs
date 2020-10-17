using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FrejyaBåtHuset_WebAPI_Backend.Models
{
    public class Andraaktiviteter
    {
        [Key]
        public int AndraaktiviteterID { get; set; }
        public string ActivityName { get; set; }
        
        public string ActivityTime { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
       
        //public string ActivityType { get; set; }
    }
}
