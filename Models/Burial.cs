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
        public string Gamous_Id { get; set; }
        public string burial_depth { get; set; }
        public string WESTTOHEAD { get; set; }
        public string WESTTOFEET { get; set; }
        public string SOUTHTOHEAD { get; set; }
        public string SOUTHTOFEET { get; set; }
        public string Preservation { get; set; }
        public string Burial_Situation { get; set; }
        public string head_direction { get; set; }
        public string Adult_Child { get; set; }
        public string estimate_age { get; set; }
        public string AGEMETHOD { get; set; }
        public string gender_body_col { get; set; }
        public string Sex_Gender_GE { get; set; }
        public string SEXMETHOD { get; set; }
        public string GE_function_total { get; set; }
        public string length_of_remains { get; set; }
        public string sample_number { get; set; }
        public string basilar_suture { get; set; }
        public string ventral_arc { get; set; }
        public string subpubic_angle { get; set; }
        public string sciatic_notch { get; set; }
        public string pubic_bone { get; set; }
        public string preaur_sulcus { get; set; }
        public string medial_IP_ramus { get; set; }
        public string dorsal_pitting { get; set; }
        public string femur_head { get; set; }
        public string humerus_head { get; set; }
        public string osteophytosis { get; set; }
        public string pubic_symphysis { get; set; }
        public string femur_length { get; set; }
        public string humerus_length { get; set; }
        public string tibia_length { get; set; }
        public string robust { get; set; }
        public string supraorbital_ridges { get; set; }
        public string orbit_edge { get; set; }
        public string parietal_bossing { get; set; }
        public string gonian { get; set; }
        public string nuchal_crest { get; set; }
        public string zygomatic_crest { get; set; }
        public string cranial_suture { get; set; }
        public string maximum_cranial_length { get; set; }
        public string maximum_cranial_breadth { get; set; }
        public string basion_bregma_height { get; set; }
        public string basion_nasion { get; set; }
        public string basion_prosthion_length { get; set; }
        public string bizygomatic_diameter { get; set; }
        public string nasion_prosthion { get; set; }
        public string maximum_nasal_breadth { get; set; }
        public string interorbital_breadth { get; set; }
        public string artifacts_description { get; set; }
        public string hair_color { get; set; }
        public string hair_taken { get; set; }
        public string soft_tissue_taken { get; set; }
        public string bone_taken { get; set; }
        public string tooth_taken { get; set; }
        public string textile_taken { get; set; }
        public string SAMPLE { get; set; }
        public string description_of_taken { get; set; }
        public string artifact_found { get; set; }
        public string estimate_living_stature { get; set; }
        public string tooth_attrition { get; set; }
        public string tooth_eruption { get; set; }
        public string pathology_anomalies { get; set; }
        public string epiphyseal_union { get; set; }
        public string year_found { get; set; }
        public string month_found { get; set; }
        public string day_found { get; set; }
    }
}