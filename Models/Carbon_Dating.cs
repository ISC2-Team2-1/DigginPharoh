using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DigginPharoh.Models
{
    public class Carbon_Dating
    {
        [Key]
        [Required]
        public string Burial_Id { get; set; }
        public int? AREA_Num { get; set; }
        public int? Rack_Num { get; set; }
        public int? TUBE_Num { get; set; }
        public string Description { get; set; }
        public int? Size_ml { get; set; }
        public int? Foci { get; set; }
        public int? C14_Sample_2017 { get; set; }
        public string Location { get; set; }
        public string Question { get; set; }
        public int? Conventional_14C_Age_BP { get; set; }
        public int? Calendar_Date_14C { get; set; }
        public int? Calibrated_95_Calendar_Date_MAX { get; set; }
        public int? Calibrated_95_Calendar_Date_MIN { get; set; }
        public int? Calibrated_95_Calendar_Date_SPAN { get; set; }
        public int? Calibrated_95_Calendar_Date_AVG { get; set; }
        public string Category { get; set; }
        public string Notes { get; set; }

    }
}
