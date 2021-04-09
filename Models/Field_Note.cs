using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

//We are not using this model

namespace DigginPharoh.Models
{
    public class Field_Note
    {
        [Key]
        [Required]
        public string Burial_Id { get; set; }
        public int? Gamous_Id { get; set; }
        public string Field_Book { get; set; }
        public string Field_Book_Page_Number{ get; set; }
        public string Skull_At_Magazine { get; set; }
        public string Postcrania_At_Magazine { get; set; }
        public string Rack_And_Shelf { get; set; }
        public string To_Be_Confirmed { get; set; }
        public string Skull_Trauma { get; set; }
        public string Postcrania_Trauma { get; set; }
        public string Cribra_Orbitala { get; set; }
        public string Porotic_Hyperostosis { get; set; }
        public string Porotic_Hyperostosis_Locations { get; set; }
        public string Metopic_Suture { get; set; }
        public string Button_Osteoma { get; set; }
        public string Osteology_Unknown_Comment { get; set; }
        public string Temporal_Mandibular_Joint_Osteoarthritis { get; set; }
        public string Linear_Hypoplasia_Enamel { get; set; }
        public string Area_Hill_Burials { get; set; }
        public string Tomb { get; set; }
        public string Goods { get; set; }
        public string Cluster { get; set; }
        public string Face_Bundle { get; set; }
        public int? Body_Analysis_Year { get; set; }

    }
}
