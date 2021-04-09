using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
//Section 2 Group 1
//THis is for data in the Gamous_db table

namespace DigginPharoh.Models
{
    public class Burial
    {
        [Key]
        [Required]
        public string Burial_Id { get; set; }
        public int? Gamous_Id { get; set; }
        public float? burial_depth { get; set; }
        public float? WESTTOHEAD { get; set; }
        public float? WESTTOFEET { get; set; }
        public float? SOUTHTOHEAD { get; set; }
        public float? SOUTHTOFEET { get; set; }
        public string Preservation { get; set; }
        public string Burial_Situation { get; set; }
        public string head_direction { get; set; }
        public string Adult_Child { get; set; }
        public string estimate_age { get; set; }
        public string AGEMETHOD { get; set; }
        public string gender_body_col { get; set; }
        public string Sex_Gender_GE { get; set; }
        public string SEXMETHOD { get; set; }
        public float? GE_function_total { get; set; }
        public float? length_of_remains { get; set; }
        public int? sample_number { get; set; }
        public string basilar_suture { get; set; }
        public int? ventral_arc { get; set; }
        public int? subpubic_angle { get; set; }
        public int? sciatic_notch { get; set; }
        public int? pubic_bone { get; set; }
        public int? preaur_sulcus { get; set; }
        public int? medial_IP_ramus { get; set; }
        public int? dorsal_pitting { get; set; }
        public float? femur_head { get; set; }
        public float? humerus_head { get; set; }
        public string osteophytosis { get; set; }
        public string pubic_symphysis { get; set; }
        public float? femur_length { get; set; }
        public float? humerus_length { get; set; }
        public float? tibia_length { get; set; }
        public int? robust { get; set; }
        public int? supraorbital_ridges { get; set; }
        public int? orbit_edge { get; set; }
        public int? parietal_bossing { get; set; }
        public int? gonian { get; set; }
        public int? nuchal_crest { get; set; }
        public int? zygomatic_crest { get; set; }
        public string cranial_suture { get; set; }
        public float? maximum_cranial_length { get; set; }
        public float? maximum_cranial_breadth { get; set; }
        public float? basion_bregma_height { get; set; }
        public float? basion_nasion { get; set; }
        public float? basion_prosthion_length { get; set; }
        public float? bizygomatic_diameter { get; set; }
        public float? nasion_prosthion { get; set; }
        public float? maximum_nasal_breadth { get; set; }
        public float? interorbital_breadth { get; set; }
        public string artifacts_description { get; set; }
        public string hair_color { get; set; }
        public bool? hair_taken { get; set; }
        public bool? soft_tissue_taken { get; set; }
        public bool? bone_taken { get; set; }
        public bool? tooth_taken { get; set; }
        public bool? textile_taken { get; set; }
        public bool? SAMPLE { get; set; }
        public string description_of_taken { get; set; }
        public bool? artifact_found { get; set; }
        public float? estimate_living_stature { get; set; }
        public string tooth_attrition { get; set; }
        public string tooth_eruption { get; set; }
        public string pathology_anomalies { get; set; }
        public string epiphyseal_union { get; set; }
        public int? year_found { get; set; }
        public string month_found { get; set; }
        public int? day_found { get; set; }
        public string Field_Book { get; set; }
        public int? Field_Book_Page_Number { get; set; }
        public bool? Skull_At_Magazine { get; set; }
        public bool? Postcrania_At_Magazine { get; set; }
        public string Rack_And_Shelf { get; set; }
        public bool? To_Be_Confirmed { get; set; }
        public bool? Skull_Trauma { get; set; }
        public bool? Postcrania_Trauma { get; set; }
        public bool? Cribra_Orbitala { get; set; }
        public string Porotic_Hyperostosis { get; set; }
        public string Porotic_Hyperostosis_Locations { get; set; }
        public bool? Metopic_Suture { get; set; }
        public bool? Button_Osteoma { get; set; }
        public string Osteology_Unknown_Comment { get; set; }
        public bool? Temporal_Mandibular_Joint_Osteoarthritis { get; set; }
        public bool? Linear_Hypoplasia_Enamel { get; set; }
        public int? Area_Hill_Burials { get; set; }
        public int? Tomb { get; set; }
        public string Goods { get; set; }
        public string Cluster { get; set; }
        public string Face_Bundle { get; set; }
        public int? Body_Analysis_Year { get; set; }
    }
}