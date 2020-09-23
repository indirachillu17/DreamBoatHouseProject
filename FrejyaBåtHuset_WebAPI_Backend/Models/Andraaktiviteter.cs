using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrejyaBåtHuset_WebAPI_Backend.Models
{
    public class Andraaktiviteter
    {
        public int AndraaktiviteterID { get; set; }
        public string OtherActivities { get; set; }
        public double Price { get; set; }
        public string  NumberOfPersons { get; set; }
    }
}
