using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FrejyaBåtHuset_WebAPI_Backend.Models
{
    public class Payment
    {
        [DisplayName("Cardholder Name")]
        [Required]
        public string Name { get; set; }
        [Required]
        public string CardNo { get; set; }
        [DisplayName("Expiry (MM/YY)")]
        [Required]
        public string ExpiryDate { get; set; }
        [Required]
        public int CVVCode { get; set; }
    }
}
