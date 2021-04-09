using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DigginPharoh.Models
{
    public class BiologicalSamples
    {
        [Key]
        [Required]
        public string Burial_id {get;set;}
        public string Container_Type { get; set; }
        public string Container_num { get; set; }
        public bool? Large_Item { get; set; }
        public int? Cluster_num { get; set; }
        public string Previously_Sampled { get; set; }
        public string Notes { get; set; }
        public string Initials { get; set; }
    }
}