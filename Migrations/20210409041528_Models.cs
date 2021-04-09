using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DigginPharoh.Migrations
{
    public partial class Models : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.CreateTable(
                name: "Burials",
                columns: table => new
                {
                    Burial_Id = table.Column<string>(nullable: false),
                    Gamous_Id = table.Column<int>(nullable: false),
                    burial_depth = table.Column<float>(nullable: false),
                    WESTTOHEAD = table.Column<float>(nullable: false),
                    WESTTOFEET = table.Column<float>(nullable: false),
                    SOUTHTOHEAD = table.Column<float>(nullable: false),
                    SOUTHTOFEET = table.Column<float>(nullable: false),
                    Preservation = table.Column<string>(nullable: true),
                    Burial_Situation = table.Column<string>(nullable: true),
                    head_direction = table.Column<string>(nullable: true),
                    Adult_Child = table.Column<string>(nullable: true),
                    estimate_age = table.Column<string>(nullable: true),
                    AGEMETHOD = table.Column<string>(nullable: true),
                    gender_body_col = table.Column<string>(nullable: true),
                    Sex_Gender_GE = table.Column<string>(nullable: true),
                    SEXMETHOD = table.Column<string>(nullable: true),
                    GE_function_total = table.Column<float>(nullable: false),
                    length_of_remains = table.Column<int>(nullable: false),
                    sample_number = table.Column<int>(nullable: false),
                    basilar_suture = table.Column<string>(nullable: true),
                    ventral_arc = table.Column<int>(nullable: false),
                    subpubic_angle = table.Column<int>(nullable: false),
                    sciatic_notch = table.Column<int>(nullable: false),
                    pubic_bone = table.Column<int>(nullable: false),
                    preaur_sulcus = table.Column<int>(nullable: false),
                    medial_IP_ramus = table.Column<int>(nullable: false),
                    dorsal_pitting = table.Column<int>(nullable: false),
                    femur_head = table.Column<float>(nullable: false),
                    humerus_head = table.Column<float>(nullable: false),
                    osteophytosis = table.Column<string>(nullable: true),
                    pubic_symphysis = table.Column<string>(nullable: true),
                    femur_length = table.Column<float>(nullable: false),
                    humerus_length = table.Column<float>(nullable: false),
                    tibia_length = table.Column<float>(nullable: false),
                    robust = table.Column<int>(nullable: false),
                    supraorbital_ridges = table.Column<int>(nullable: false),
                    orbit_edge = table.Column<int>(nullable: false),
                    parietal_bossing = table.Column<int>(nullable: false),
                    gonian = table.Column<int>(nullable: false),
                    nuchal_crest = table.Column<int>(nullable: false),
                    zygomatic_crest = table.Column<int>(nullable: false),
                    cranial_suture = table.Column<string>(nullable: true),
                    maximum_cranial_length = table.Column<float>(nullable: false),
                    maximum_cranial_breadth = table.Column<float>(nullable: false),
                    basion_bregma_height = table.Column<float>(nullable: false),
                    basion_nasion = table.Column<float>(nullable: false),
                    basion_prosthion_length = table.Column<float>(nullable: false),
                    bizygomatic_diameter = table.Column<float>(nullable: false),
                    nasion_prosthion = table.Column<float>(nullable: false),
                    maximum_nasal_breadth = table.Column<float>(nullable: false),
                    interorbital_breadth = table.Column<float>(nullable: false),
                    artifacts_description = table.Column<string>(nullable: true),
                    hair_color = table.Column<string>(nullable: true),
                    hair_taken = table.Column<bool>(nullable: false),
                    soft_tissue_taken = table.Column<bool>(nullable: false),
                    bone_taken = table.Column<bool>(nullable: false),
                    tooth_taken = table.Column<bool>(nullable: false),
                    textile_taken = table.Column<bool>(nullable: false),
                    SAMPLE = table.Column<bool>(nullable: false),
                    description_of_taken = table.Column<string>(nullable: true),
                    artifact_found = table.Column<bool>(nullable: false),
                    estimate_living_stature = table.Column<float>(nullable: false),
                    tooth_attrition = table.Column<string>(nullable: true),
                    tooth_eruption = table.Column<string>(nullable: true),
                    pathology_anomalies = table.Column<string>(nullable: true),
                    epiphyseal_union = table.Column<string>(nullable: true),
                    year_found = table.Column<int>(nullable: false),
                    month_found = table.Column<string>(nullable: true),
                    day_found = table.Column<int>(nullable: false),
                    Field_Book = table.Column<string>(nullable: true),
                    Field_Book_Page_Number = table.Column<int>(nullable: false),
                    Skull_At_Magazine = table.Column<bool>(nullable: false),
                    Postcrania_At_Magazine = table.Column<bool>(nullable: false),
                    Rack_And_Shelf = table.Column<string>(nullable: true),
                    To_Be_Confirmed = table.Column<bool>(nullable: false),
                    Skull_Trauma = table.Column<bool>(nullable: false),
                    Postcrania_Trauma = table.Column<bool>(nullable: false),
                    Cribra_Orbitala = table.Column<bool>(nullable: false),
                    Porotic_Hyperostosis = table.Column<string>(nullable: true),
                    Porotic_Hyperostosis_Locations = table.Column<string>(nullable: true),
                    Metopic_Suture = table.Column<bool>(nullable: false),
                    Button_Osteoma = table.Column<bool>(nullable: false),
                    Osteology_Unknown_Comment = table.Column<string>(nullable: true),
                    Temporal_Mandibular_Joint_Osteoarthritis = table.Column<bool>(nullable: false),
                    Linear_Hypoplasia_Enamel = table.Column<bool>(nullable: false),
                    Area_Hill_Burials = table.Column<int>(nullable: false),
                    Tomb = table.Column<int>(nullable: false),
                    Goods = table.Column<string>(nullable: true),
                    Cluster = table.Column<string>(nullable: true),
                    Face_Bundle = table.Column<string>(nullable: true),
                    Body_Analysis_Year = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Burials", x => x.Burial_Id);
                });

            migrationBuilder.CreateTable(
                name: "Carbon_Dates",
                columns: table => new
                {
                    Carbon_Dating_Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Burial_Id = table.Column<string>(nullable: false),
                    AREA_Num = table.Column<int>(nullable: false),
                    Rack_Num = table.Column<int>(nullable: false),
                    TUBE_Num = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Size_ml = table.Column<int>(nullable: false),
                    Foci = table.Column<int>(nullable: false),
                    C14_Sample_2017 = table.Column<int>(nullable: false),
                    Location = table.Column<string>(nullable: true),
                    Question = table.Column<string>(nullable: true),
                    Conventional_14C_Age_BP = table.Column<int>(nullable: false),
                    Calendar_Date_14C = table.Column<int>(nullable: false),
                    Calibrated_95_Calendar_Date_MAX = table.Column<int>(nullable: false),
                    Calibrated_95_Calendar_Date_MIN = table.Column<int>(nullable: false),
                    Calibrated_95_Calendar_Date_SPAN = table.Column<int>(nullable: false),
                    Calibrated_95_Calendar_Date_AVG = table.Column<int>(nullable: false),
                    Category = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carbon_Dates", x => x.Carbon_Dating_Id);
                });

            migrationBuilder.CreateTable(
                name: "Cranials",
                columns: table => new
                {
                    Burial_Id = table.Column<string>(nullable: false),
                    Burial_Depth = table.Column<float>(nullable: false),
                    Sample_Number = table.Column<int>(nullable: false),
                    Maximum_Cranial_Length = table.Column<float>(nullable: false),
                    Maximum_Cranial_Breadth = table.Column<float>(nullable: false),
                    Basion_Bregma_Height = table.Column<float>(nullable: false),
                    Basion_Nasion = table.Column<float>(nullable: false),
                    Basion_Prosthion_Length = table.Column<float>(nullable: false),
                    Bizygomatic_Diameter = table.Column<float>(nullable: false),
                    Nasion_Prosthion = table.Column<float>(nullable: false),
                    Maximum_Nasal_Breadth = table.Column<float>(nullable: false),
                    Interorbital_Breadth = table.Column<float>(nullable: false),
                    Burial_Artifact_Description = table.Column<string>(nullable: true),
                    Buried_with_Artifacts = table.Column<bool>(nullable: false),
                    Giles_Gender = table.Column<string>(nullable: true),
                    Body_Gender = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cranials", x => x.Burial_Id);
                });

            migrationBuilder.CreateTable(
                name: "Infos",
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
                    table.PrimaryKey("PK_Infos", x => x.Burial_Id);
                });

            migrationBuilder.CreateTable(
                name: "Samples",
                columns: table => new
                {
                    Biological_Samples_Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Burial_id = table.Column<string>(nullable: false),
                    Container_Type = table.Column<string>(nullable: true),
                    Container_num = table.Column<string>(nullable: true),
                    Large_Item = table.Column<bool>(nullable: false),
                    Cluster_num = table.Column<int>(nullable: false),
                    Previously_Sampled = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    Initials = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Samples", x => x.Biological_Samples_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Burials");

            migrationBuilder.DropTable(
                name: "Carbon_Dates");

            migrationBuilder.DropTable(
                name: "Cranials");

            migrationBuilder.DropTable(
                name: "Infos");

            migrationBuilder.DropTable(
                name: "Samples");

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AuthorFName = table.Column<string>(type: "text", nullable: false),
                    AuthorLName = table.Column<string>(type: "text", nullable: false),
                    Category = table.Column<string>(type: "text", nullable: false),
                    Classification = table.Column<string>(type: "text", nullable: false),
                    ISBN = table.Column<string>(type: "text", nullable: false),
                    PageNum = table.Column<int>(type: "integer", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    Publisher = table.Column<string>(type: "text", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                });
        }
    }
}
