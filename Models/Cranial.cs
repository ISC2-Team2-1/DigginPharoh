using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DigginPharoh.Models
{
    public class Cranial
    {
        [Key]
        [Required]
        public int Burial_Id { get; set; }
        public float Burial_Depth { get; set; }
        public int Sample_Number { get; set; }
        public float Maximum_Cranial_Length { get; set; }
        public float Maximum_Cranial_Breadth { get; set; }
        public float Basion_Bregma_Height { get; set; }
        public float Basion_Nasion { get; set; }
        public float Basion_Prosthion_Length { get; set; }
        public float Bizygomatic_Diameter { get; set; }
        public float Nasion_Prosthion { get; set; }
        public float Maximum_Nasal_Breadth { get; set; }
        public float Interorbital_Breadth { get; set; }
        public string Burial_Artifact_Description { get; set; }
        public bool Buried_with_Artifacts { get; set; }
        public string Giles_Gender { get; set; }
        public string Body_Gender { get; set; }

    }

}
