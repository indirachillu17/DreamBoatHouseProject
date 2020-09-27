using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FrejyaBåtHuset_WebAPI_Backend.Models
{
    public class User
    {

        public int Id { get; set; }
        public string UserName { get; set; }
        [DisplayName("Email")]
        [Required]
        public string EmailId { get; set; }
        [Required]
        public string Password { get; set; }
        public string UserType { get; set; }
    }
}
