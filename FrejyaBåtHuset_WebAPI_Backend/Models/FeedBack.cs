using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FrejyaBåtHuset_WebAPI_Backend.Models
{
    public class FeedBack
    {

            [Key]
            public int FeedbackId { get; set; }
            public int UserId { get; set; }
            public string OverallExperience { get; set; }
            public string BestExperience { get; set; }
            public string AnyAdditionalComments { get; set; }

        }
    }

