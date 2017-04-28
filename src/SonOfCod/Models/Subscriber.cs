using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SonOfCod.Models
{
    public class Subscriber
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Email { get; set; }

        public string Location { get; set; }

        public string Reason { get; set; }
    }
}
