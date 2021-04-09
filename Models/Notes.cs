using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
//Notes on the burrial, as many as needed can be added

namespace DigginPharoh.Models
{
    public class Notes
    {
        [Key]
        [Required]
        public int NoteId { get; set; }
        [Required]
        public string Burial_Id { get; set; }
        public string Note { get; set; }
    }
}
