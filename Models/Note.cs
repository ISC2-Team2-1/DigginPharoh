using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
//Notes on the burrial, as many as needed can be added

namespace DigginPharoh.Models
{
    public class Note
    {
        [Key]
        [Required]
        public string Burial_Id { get; set; }
        public string Msg { get; set; }
    }
}
