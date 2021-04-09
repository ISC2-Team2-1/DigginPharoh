using Microsoft.EntityFrameworkCore.Migrations;

namespace DigginPharoh.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ProjectRole",
                table: "ProjectRole");

            migrationBuilder.RenameTable(
                name: "ProjectRole",
                newName: "ProjectRoles");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProjectRoles",
                table: "ProjectRoles",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "BioSamples",
                columns: table => new
                {
                    Burial_id = table.Column<string>(nullable: false),
                    Container_Type = table.Column<string>(nullable: true),
                    Container_num = table.Column<string>(nullable: true),
                    Large_Item = table.Column<bool>(nullable: true),
                    Cluster_num = table.Column<int>(nullable: true),
                    Previously_Sampled = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    Initials = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BioSamples", x => x.Burial_id);
                });

            migrationBuilder.CreateTable(
                name: "BurialIdInfos",
                columns: table => new
                {
                    Burial_Id = table.Column<string>(nullable: false),
                    burial_location_NS = table.Column<char>(nullable: false),
                    burial_location_EW = table.Column<char>(nullable: false),
                    low_pair_NS = table.Column<int>(nullable: false),
                    high_pair_NS = table.Column<int>(nullable: false),
                    low_pair_EW = table.Column<int>(nullable: false),
                    high_pair_EW = table.Column<int>(nullable: false),
                    burial_subplot = table.Column<string>(nullable: false),
                    BURIALNUM = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BurialIdInfos", x => x.Burial_Id);
                });

            migrationBuilder.CreateTable(
                name: "CarbonDates",
                columns: table => new
                {
                    Burial_Id = table.Column<string>(nullable: false),
                    AREA_Num = table.Column<int>(nullable: true),
                    Rack_Num = table.Column<int>(nullable: true),
                    TUBE_Num = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Size_ml = table.Column<int>(nullable: true),
                    Foci = table.Column<int>(nullable: true),
                    C14_Sample_2017 = table.Column<int>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    Question = table.Column<string>(nullable: true),
                    Conventional_14C_Age_BP = table.Column<int>(nullable: true),
                    Calendar_Date_14C = table.Column<int>(nullable: true),
                    Calibrated_95_Calendar_Date_MAX = table.Column<int>(nullable: true),
                    Calibrated_95_Calendar_Date_MIN = table.Column<int>(nullable: true),
                    Calibrated_95_Calendar_Date_SPAN = table.Column<int>(nullable: true),
                    Calibrated_95_Calendar_Date_AVG = table.Column<int>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarbonDates", x => x.Burial_Id);
                });

            migrationBuilder.CreateTable(
                name: "Craniums",
                columns: table => new
                {
                    Burial_Id = table.Column<string>(nullable: false),
                    Burial_Depth = table.Column<float>(nullable: true),
                    Sample_Number = table.Column<int>(nullable: true),
                    Maximum_Cranial_Length = table.Column<float>(nullable: true),
                    Maximum_Cranial_Breadth = table.Column<float>(nullable: true),
                    Basion_Bregma_Height = table.Column<float>(nullable: true),
                    Basion_Nasion = table.Column<float>(nullable: true),
                    Basion_Prosthion_Length = table.Column<float>(nullable: true),
                    Bizygomatic_Diameter = table.Column<float>(nullable: true),
                    Nasion_Prosthion = table.Column<float>(nullable: true),
                    Maximum_Nasal_Breadth = table.Column<float>(nullable: true),
                    Interorbital_Breadth = table.Column<float>(nullable: true),
                    Burial_Artifact_Description = table.Column<string>(nullable: true),
                    Buried_with_Artifacts = table.Column<bool>(nullable: true),
                    Giles_Gender = table.Column<string>(nullable: true),
                    Body_Gender = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Craniums", x => x.Burial_Id);
                });

            migrationBuilder.CreateTable(
                name: "FieldNotes",
                columns: table => new
                {
                    Burial_Id = table.Column<string>(nullable: false),
                    Gamous_Id = table.Column<int>(nullable: true),
                    Field_Book = table.Column<string>(nullable: true),
                    Field_Book_Page_Number = table.Column<string>(nullable: true),
                    Skull_At_Magazine = table.Column<string>(nullable: true),
                    Postcrania_At_Magazine = table.Column<string>(nullable: true),
                    Rack_And_Shelf = table.Column<string>(nullable: true),
                    To_Be_Confirmed = table.Column<string>(nullable: true),
                    Skull_Trauma = table.Column<string>(nullable: true),
                    Postcrania_Trauma = table.Column<string>(nullable: true),
                    Cribra_Orbitala = table.Column<string>(nullable: true),
                    Porotic_Hyperostosis = table.Column<string>(nullable: true),
                    Porotic_Hyperostosis_Locations = table.Column<string>(nullable: true),
                    Metopic_Suture = table.Column<string>(nullable: true),
                    Button_Osteoma = table.Column<string>(nullable: true),
                    Osteology_Unknown_Comment = table.Column<string>(nullable: true),
                    Temporal_Mandibular_Joint_Osteoarthritis = table.Column<string>(nullable: true),
                    Linear_Hypoplasia_Enamel = table.Column<string>(nullable: true),
                    Area_Hill_Burials = table.Column<string>(nullable: true),
                    Tomb = table.Column<string>(nullable: true),
                    Goods = table.Column<string>(nullable: true),
                    Cluster = table.Column<string>(nullable: true),
                    Face_Bundle = table.Column<string>(nullable: true),
                    Body_Analysis_Year = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FieldNotes", x => x.Burial_Id);
                });

            migrationBuilder.CreateTable(
                name: "GamousBurials",
                columns: table => new
                {
                    Burial_Id = table.Column<string>(nullable: false),
                    Gamous_Id = table.Column<int>(nullable: true),
                    burial_depth = table.Column<float>(nullable: true),
                    WESTTOHEAD = table.Column<float>(nullable: true),
                    WESTTOFEET = table.Column<float>(nullable: true),
                    SOUTHTOHEAD = table.Column<float>(nullable: true),
                    SOUTHTOFEET = table.Column<float>(nullable: true),
                    Preservation = table.Column<string>(nullable: true),
                    Burial_Situation = table.Column<string>(nullable: true),
                    head_direction = table.Column<string>(nullable: true),
                    Adult_Child = table.Column<string>(nullable: true),
                    estimate_age = table.Column<string>(nullable: true),
                    AGEMETHOD = table.Column<string>(nullable: true),
                    gender_body_col = table.Column<string>(nullable: true),
                    Sex_Gender_GE = table.Column<string>(nullable: true),
                    SEXMETHOD = table.Column<string>(nullable: true),
                    GE_function_total = table.Column<float>(nullable: true),
                    length_of_remains = table.Column<float>(nullable: true),
                    sample_number = table.Column<int>(nullable: true),
                    basilar_suture = table.Column<string>(nullable: true),
                    ventral_arc = table.Column<int>(nullable: true),
                    subpubic_angle = table.Column<int>(nullable: true),
                    sciatic_notch = table.Column<int>(nullable: true),
                    pubic_bone = table.Column<int>(nullable: true),
                    preaur_sulcus = table.Column<int>(nullable: true),
                    medial_IP_ramus = table.Column<int>(nullable: true),
                    dorsal_pitting = table.Column<int>(nullable: true),
                    femur_head = table.Column<float>(nullable: true),
                    humerus_head = table.Column<float>(nullable: true),
                    osteophytosis = table.Column<string>(nullable: true),
                    pubic_symphysis = table.Column<string>(nullable: true),
                    femur_length = table.Column<float>(nullable: true),
                    humerus_length = table.Column<float>(nullable: true),
                    tibia_length = table.Column<float>(nullable: true),
                    robust = table.Column<int>(nullable: true),
                    supraorbital_ridges = table.Column<int>(nullable: true),
                    orbit_edge = table.Column<int>(nullable: true),
                    parietal_bossing = table.Column<int>(nullable: true),
                    gonian = table.Column<int>(nullable: true),
                    nuchal_crest = table.Column<int>(nullable: true),
                    zygomatic_crest = table.Column<int>(nullable: true),
                    cranial_suture = table.Column<string>(nullable: true),
                    maximum_cranial_length = table.Column<float>(nullable: true),
                    maximum_cranial_breadth = table.Column<float>(nullable: true),
                    basion_bregma_height = table.Column<float>(nullable: true),
                    basion_nasion = table.Column<float>(nullable: true),
                    basion_prosthion_length = table.Column<float>(nullable: true),
                    bizygomatic_diameter = table.Column<float>(nullable: true),
                    nasion_prosthion = table.Column<float>(nullable: true),
                    maximum_nasal_breadth = table.Column<float>(nullable: true),
                    interorbital_breadth = table.Column<float>(nullable: true),
                    artifacts_description = table.Column<string>(nullable: true),
                    hair_color = table.Column<string>(nullable: true),
                    hair_taken = table.Column<bool>(nullable: true),
                    soft_tissue_taken = table.Column<bool>(nullable: true),
                    bone_taken = table.Column<bool>(nullable: true),
                    tooth_taken = table.Column<bool>(nullable: true),
                    textile_taken = table.Column<bool>(nullable: true),
                    SAMPLE = table.Column<bool>(nullable: true),
                    description_of_taken = table.Column<string>(nullable: true),
                    artifact_found = table.Column<bool>(nullable: true),
                    estimate_living_stature = table.Column<float>(nullable: true),
                    tooth_attrition = table.Column<string>(nullable: true),
                    tooth_eruption = table.Column<string>(nullable: true),
                    pathology_anomalies = table.Column<string>(nullable: true),
                    epiphyseal_union = table.Column<string>(nullable: true),
                    year_found = table.Column<int>(nullable: true),
                    month_found = table.Column<string>(nullable: true),
                    day_found = table.Column<int>(nullable: true),
                    Field_Book = table.Column<string>(nullable: true),
                    Field_Book_Page_Number = table.Column<int>(nullable: true),
                    Skull_At_Magazine = table.Column<bool>(nullable: true),
                    Postcrania_At_Magazine = table.Column<bool>(nullable: true),
                    Rack_And_Shelf = table.Column<string>(nullable: true),
                    To_Be_Confirmed = table.Column<bool>(nullable: true),
                    Skull_Trauma = table.Column<bool>(nullable: true),
                    Postcrania_Trauma = table.Column<bool>(nullable: true),
                    Cribra_Orbitala = table.Column<bool>(nullable: true),
                    Porotic_Hyperostosis = table.Column<string>(nullable: true),
                    Porotic_Hyperostosis_Locations = table.Column<string>(nullable: true),
                    Metopic_Suture = table.Column<bool>(nullable: true),
                    Button_Osteoma = table.Column<bool>(nullable: true),
                    Osteology_Unknown_Comment = table.Column<string>(nullable: true),
                    Temporal_Mandibular_Joint_Osteoarthritis = table.Column<bool>(nullable: true),
                    Linear_Hypoplasia_Enamel = table.Column<bool>(nullable: true),
                    Area_Hill_Burials = table.Column<int>(nullable: true),
                    Tomb = table.Column<int>(nullable: true),
                    Goods = table.Column<string>(nullable: true),
                    Cluster = table.Column<string>(nullable: true),
                    Face_Bundle = table.Column<string>(nullable: true),
                    Body_Analysis_Year = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GamousBurials", x => x.Burial_Id);
                });

            migrationBuilder.CreateTable(
                name: "JustNotes",
                columns: table => new
                {
                    Burial_Id = table.Column<string>(nullable: false),
                    Msg = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JustNotes", x => x.Burial_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BioSamples");

            migrationBuilder.DropTable(
                name: "BurialIdInfos");

            migrationBuilder.DropTable(
                name: "CarbonDates");

            migrationBuilder.DropTable(
                name: "Craniums");

            migrationBuilder.DropTable(
                name: "FieldNotes");

            migrationBuilder.DropTable(
                name: "GamousBurials");

            migrationBuilder.DropTable(
                name: "JustNotes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProjectRoles",
                table: "ProjectRoles");

            migrationBuilder.RenameTable(
                name: "ProjectRoles",
                newName: "ProjectRole");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProjectRole",
                table: "ProjectRole",
                column: "Id");
        }
    }
}
