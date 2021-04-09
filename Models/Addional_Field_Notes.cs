using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DigginPharoh.Models
{
    public class Addional_Field_Notes
    {
        [Key]
        [Required]
        public int Additional_Field_Notes { get; set; }
        [Required]
        public string Burial_Id { get; set; }
        public int Gamous_Id { get; set; }
        public string Field_Book { get; set; }
        public int Field_Book_Page_Number{ get; set; }
        public bool Skull_At_Magazine { get; set; }
        public bool Postcrania_At_Magazine { get; set; }
        public string Rack_And_Shelf { get; set; }
        public bool To_Be_Confirmed { get; set; }
        public bool Skull_Trauma { get; set; }
        public bool Postcrania_Trauma { get; set; }
        public bool Cribra_Orbitala { get; set; }
        public string Porotic_Hyperostosis { get; set; }
        public string Porotic_Hyperostosis_Locations { get; set; }
        public bool Metopic_Suture { get; set; }
        public bool Button_Osteoma { get; set; }
        public string Osteology_Unknown_Comment { get; set; }
        public bool Temporal_Mandibular_Joint_Osteoarthritis { get; set; }
        public bool Linear_Hypoplasia_Enamel { get; set; }
        public int Area_Hill_Burials { get; set; }
        public int Tomb { get; set; }
        public string Goods { get; set; }
        public string Cluster { get; set; }
        public string Face_Bundle { get; set; }
        public int Body_Analysis_Year { get; set; }

    }
}
