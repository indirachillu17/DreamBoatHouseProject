using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrejyaBåtHuset_WebAPI_Backend.Models
{
    public class Payment
    {
        public int CardNo { get; set; }
        public string ExpiryDate { get; set; }
        public int SecretNum { get; set; }

    }
}
