using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
//Section 2 Group 1
//This coresponds to the tab ID_Maker


namespace DigginPharoh.Models
{
    public class Burial_ID_Info
    {
        [Key]
        [Required]
        public string Burial_Id { get; set; }
        [Required]
        public char burial_location_NS { get; set; }
        [Required]
        public char burial_location_EW { get; set; }
        [Required]
        public int low_pair_NS { get; set; }
        [Required]
        public int high_pair_NS { get; set; }
        [Required]
        public int low_pair_EW { get; set; }
        [Required]
        public int high_pair_EW { get; set; }
        [Required]
        public string burial_subplot { get; set; }
        [Required]
        public string BURIALNUM { get; set; }
    }
}
