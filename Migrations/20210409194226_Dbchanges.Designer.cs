// <auto-generated />
using System;
using DigginPharoh.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DigginPharoh.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210409194226_Dbchanges")]
    partial class Dbchanges
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("DigginPharoh.Models.BiologicalSamples", b =>
                {
                    b.Property<string>("Burial_id")
                        .HasColumnType("text");

                    b.Property<int?>("Cluster_num")
                        .HasColumnType("integer");

                    b.Property<string>("Container_Type")
                        .HasColumnType("text");

                    b.Property<string>("Container_num")
                        .HasColumnType("text");

                    b.Property<string>("Initials")
                        .HasColumnType("text");

                    b.Property<bool?>("Large_Item")
                        .HasColumnType("boolean");

                    b.Property<string>("Notes")
                        .HasColumnType("text");

                    b.Property<string>("Previously_Sampled")
                        .HasColumnType("text");

                    b.HasKey("Burial_id");

                    b.ToTable("BioSamples");
                });

            modelBuilder.Entity("DigginPharoh.Models.Burial", b =>
                {
                    b.Property<string>("Burial_Id")
                        .HasColumnType("text");

                    b.Property<string>("AGEMETHOD")
                        .HasColumnType("text");

                    b.Property<string>("Adult_Child")
                        .HasColumnType("text");

                    b.Property<int?>("Area_Hill_Burials")
                        .HasColumnType("integer");

                    b.Property<int?>("Body_Analysis_Year")
                        .HasColumnType("integer");

                    b.Property<string>("Burial_Situation")
                        .HasColumnType("text");

                    b.Property<bool?>("Button_Osteoma")
                        .HasColumnType("boolean");

                    b.Property<string>("Cluster")
                        .HasColumnType("text");

                    b.Property<bool?>("Cribra_Orbitala")
                        .HasColumnType("boolean");

                    b.Property<string>("Face_Bundle")
                        .HasColumnType("text");

                    b.Property<string>("Field_Book")
                        .HasColumnType("text");

                    b.Property<int?>("Field_Book_Page_Number")
                        .HasColumnType("integer");

                    b.Property<float?>("GE_function_total")
                        .HasColumnType("real");

                    b.Property<int?>("Gamous_Id")
                        .HasColumnType("integer");

                    b.Property<string>("Goods")
                        .HasColumnType("text");

                    b.Property<bool?>("Linear_Hypoplasia_Enamel")
                        .HasColumnType("boolean");

                    b.Property<bool?>("Metopic_Suture")
                        .HasColumnType("boolean");

                    b.Property<string>("Osteology_Unknown_Comment")
                        .HasColumnType("text");

                    b.Property<string>("Porotic_Hyperostosis")
                        .HasColumnType("text");

                    b.Property<string>("Porotic_Hyperostosis_Locations")
                        .HasColumnType("text");

                    b.Property<bool?>("Postcrania_At_Magazine")
                        .HasColumnType("boolean");

                    b.Property<bool?>("Postcrania_Trauma")
                        .HasColumnType("boolean");

                    b.Property<string>("Preservation")
                        .HasColumnType("text");

                    b.Property<string>("Rack_And_Shelf")
                        .HasColumnType("text");

                    b.Property<bool?>("SAMPLE")
                        .HasColumnType("boolean");

                    b.Property<string>("SEXMETHOD")
                        .HasColumnType("text");

                    b.Property<float?>("SOUTHTOFEET")
                        .HasColumnType("real");

                    b.Property<float?>("SOUTHTOHEAD")
                        .HasColumnType("real");

                    b.Property<string>("Sex_Gender_GE")
                        .HasColumnType("text");

                    b.Property<bool?>("Skull_At_Magazine")
                        .HasColumnType("boolean");

                    b.Property<bool?>("Skull_Trauma")
                        .HasColumnType("boolean");

                    b.Property<bool?>("Temporal_Mandibular_Joint_Osteoarthritis")
                        .HasColumnType("boolean");

                    b.Property<bool?>("To_Be_Confirmed")
                        .HasColumnType("boolean");

                    b.Property<int?>("Tomb")
                        .HasColumnType("integer");

                    b.Property<float?>("WESTTOFEET")
                        .HasColumnType("real");

                    b.Property<float?>("WESTTOHEAD")
                        .HasColumnType("real");

                    b.Property<bool?>("artifact_found")
                        .HasColumnType("boolean");

                    b.Property<string>("artifacts_description")
                        .HasColumnType("text");

                    b.Property<string>("basilar_suture")
                        .HasColumnType("text");

                    b.Property<float?>("basion_bregma_height")
                        .HasColumnType("real");

                    b.Property<float?>("basion_nasion")
                        .HasColumnType("real");

                    b.Property<float?>("basion_prosthion_length")
                        .HasColumnType("real");

                    b.Property<float?>("bizygomatic_diameter")
                        .HasColumnType("real");

                    b.Property<bool?>("bone_taken")
                        .HasColumnType("boolean");

                    b.Property<float?>("burial_depth")
                        .HasColumnType("real");

                    b.Property<string>("cranial_suture")
                        .HasColumnType("text");

                    b.Property<int?>("day_found")
                        .HasColumnType("integer");

                    b.Property<string>("description_of_taken")
                        .HasColumnType("text");

                    b.Property<int?>("dorsal_pitting")
                        .HasColumnType("integer");

                    b.Property<string>("epiphyseal_union")
                        .HasColumnType("text");

                    b.Property<string>("estimate_age")
                        .HasColumnType("text");

                    b.Property<float?>("estimate_living_stature")
                        .HasColumnType("real");

                    b.Property<float?>("femur_head")
                        .HasColumnType("real");

                    b.Property<float?>("femur_length")
                        .HasColumnType("real");

                    b.Property<string>("gender_body_col")
                        .HasColumnType("text");

                    b.Property<int?>("gonian")
                        .HasColumnType("integer");

                    b.Property<string>("hair_color")
                        .HasColumnType("text");

                    b.Property<bool?>("hair_taken")
                        .HasColumnType("boolean");

                    b.Property<string>("head_direction")
                        .HasColumnType("text");

                    b.Property<float?>("humerus_head")
                        .HasColumnType("real");

                    b.Property<float?>("humerus_length")
                        .HasColumnType("real");

                    b.Property<float?>("interorbital_breadth")
                        .HasColumnType("real");

                    b.Property<float?>("length_of_remains")
                        .HasColumnType("real");

                    b.Property<float?>("maximum_cranial_breadth")
                        .HasColumnType("real");

                    b.Property<float?>("maximum_cranial_length")
                        .HasColumnType("real");

                    b.Property<float?>("maximum_nasal_breadth")
                        .HasColumnType("real");

                    b.Property<int?>("medial_IP_ramus")
                        .HasColumnType("integer");

                    b.Property<string>("month_found")
                        .HasColumnType("text");

                    b.Property<float?>("nasion_prosthion")
                        .HasColumnType("real");

                    b.Property<int?>("nuchal_crest")
                        .HasColumnType("integer");

                    b.Property<int?>("orbit_edge")
                        .HasColumnType("integer");

                    b.Property<string>("osteophytosis")
                        .HasColumnType("text");

                    b.Property<int?>("parietal_bossing")
                        .HasColumnType("integer");

                    b.Property<string>("pathology_anomalies")
                        .HasColumnType("text");

                    b.Property<int?>("preaur_sulcus")
                        .HasColumnType("integer");

                    b.Property<int?>("pubic_bone")
                        .HasColumnType("integer");

                    b.Property<string>("pubic_symphysis")
                        .HasColumnType("text");

                    b.Property<int?>("robust")
                        .HasColumnType("integer");

                    b.Property<int?>("sample_number")
                        .HasColumnType("integer");

                    b.Property<int?>("sciatic_notch")
                        .HasColumnType("integer");

                    b.Property<bool?>("soft_tissue_taken")
                        .HasColumnType("boolean");

                    b.Property<int?>("subpubic_angle")
                        .HasColumnType("integer");

                    b.Property<int?>("supraorbital_ridges")
                        .HasColumnType("integer");

                    b.Property<bool?>("textile_taken")
                        .HasColumnType("boolean");

                    b.Property<float?>("tibia_length")
                        .HasColumnType("real");

                    b.Property<string>("tooth_attrition")
                        .HasColumnType("text");

                    b.Property<string>("tooth_eruption")
                        .HasColumnType("text");

                    b.Property<bool?>("tooth_taken")
                        .HasColumnType("boolean");

                    b.Property<int?>("ventral_arc")
                        .HasColumnType("integer");

                    b.Property<int?>("year_found")
                        .HasColumnType("integer");

                    b.Property<int?>("zygomatic_crest")
                        .HasColumnType("integer");

                    b.HasKey("Burial_Id");

                    b.ToTable("GamousBurials");
                });

            modelBuilder.Entity("DigginPharoh.Models.BurialIDInfo", b =>
                {
                    b.Property<string>("Burial_Id")
                        .HasColumnType("text");

                    b.Property<string>("BURIALNUM")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<char>("burial_location_EW")
                        .HasColumnType("character(1)");

                    b.Property<char>("burial_location_NS")
                        .HasColumnType("character(1)");

                    b.Property<string>("burial_subplot")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("high_pair_EW")
                        .HasColumnType("integer");

                    b.Property<int>("high_pair_NS")
                        .HasColumnType("integer");

                    b.Property<int>("low_pair_EW")
                        .HasColumnType("integer");

                    b.Property<int>("low_pair_NS")
                        .HasColumnType("integer");

                    b.HasKey("Burial_Id");

                    b.ToTable("BurialIdInfos");
                });

            modelBuilder.Entity("DigginPharoh.Models.Carbon_Dating", b =>
                {
                    b.Property<string>("Burial_Id")
                        .HasColumnType("text");

                    b.Property<int?>("AREA_Num")
                        .HasColumnType("integer");

                    b.Property<int?>("C14_Sample_2017")
                        .HasColumnType("integer");

                    b.Property<int?>("Calendar_Date_14C")
                        .HasColumnType("integer");

                    b.Property<int?>("Calibrated_95_Calendar_Date_AVG")
                        .HasColumnType("integer");

                    b.Property<int?>("Calibrated_95_Calendar_Date_MAX")
                        .HasColumnType("integer");

                    b.Property<int?>("Calibrated_95_Calendar_Date_MIN")
                        .HasColumnType("integer");

                    b.Property<int?>("Calibrated_95_Calendar_Date_SPAN")
                        .HasColumnType("integer");

                    b.Property<string>("Category")
                        .HasColumnType("text");

                    b.Property<int?>("Conventional_14C_Age_BP")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int?>("Foci")
                        .HasColumnType("integer");

                    b.Property<string>("Location")
                        .HasColumnType("text");

                    b.Property<string>("Notes")
                        .HasColumnType("text");

                    b.Property<string>("Question")
                        .HasColumnType("text");

                    b.Property<int?>("Rack_Num")
                        .HasColumnType("integer");

                    b.Property<int?>("Size_ml")
                        .HasColumnType("integer");

                    b.Property<int?>("TUBE_Num")
                        .HasColumnType("integer");

                    b.HasKey("Burial_Id");

                    b.ToTable("CarbonDates");
                });

            modelBuilder.Entity("DigginPharoh.Models.Cranial", b =>
                {
                    b.Property<string>("Burial_Id")
                        .HasColumnType("text");

                    b.Property<float?>("Basion_Bregma_Height")
                        .HasColumnType("real");

                    b.Property<float?>("Basion_Nasion")
                        .HasColumnType("real");

                    b.Property<float?>("Basion_Prosthion_Length")
                        .HasColumnType("real");

                    b.Property<float?>("Bizygomatic_Diameter")
                        .HasColumnType("real");

                    b.Property<string>("Body_Gender")
                        .HasColumnType("text");

                    b.Property<string>("Burial_Artifact_Description")
                        .HasColumnType("text");

                    b.Property<float?>("Burial_Depth")
                        .HasColumnType("real");

                    b.Property<bool?>("Buried_with_Artifacts")
                        .HasColumnType("boolean");

                    b.Property<string>("Giles_Gender")
                        .HasColumnType("text");

                    b.Property<float?>("Interorbital_Breadth")
                        .HasColumnType("real");

                    b.Property<float?>("Maximum_Cranial_Breadth")
                        .HasColumnType("real");

                    b.Property<float?>("Maximum_Cranial_Length")
                        .HasColumnType("real");

                    b.Property<float?>("Maximum_Nasal_Breadth")
                        .HasColumnType("real");

                    b.Property<float?>("Nasion_Prosthion")
                        .HasColumnType("real");

                    b.Property<int?>("Sample_Number")
                        .HasColumnType("integer");

                    b.HasKey("Burial_Id");

                    b.ToTable("Craniums");
                });

            modelBuilder.Entity("DigginPharoh.Models.Field_Note", b =>
                {
                    b.Property<string>("Burial_Id")
                        .HasColumnType("text");

                    b.Property<string>("Area_Hill_Burials")
                        .HasColumnType("text");

                    b.Property<int?>("Body_Analysis_Year")
                        .HasColumnType("integer");

                    b.Property<string>("Button_Osteoma")
                        .HasColumnType("text");

                    b.Property<string>("Cluster")
                        .HasColumnType("text");

                    b.Property<string>("Cribra_Orbitala")
                        .HasColumnType("text");

                    b.Property<string>("Face_Bundle")
                        .HasColumnType("text");

                    b.Property<string>("Field_Book")
                        .HasColumnType("text");

                    b.Property<string>("Field_Book_Page_Number")
                        .HasColumnType("text");

                    b.Property<int?>("Gamous_Id")
                        .HasColumnType("integer");

                    b.Property<string>("Goods")
                        .HasColumnType("text");

                    b.Property<string>("Linear_Hypoplasia_Enamel")
                        .HasColumnType("text");

                    b.Property<string>("Metopic_Suture")
                        .HasColumnType("text");

                    b.Property<string>("Osteology_Unknown_Comment")
                        .HasColumnType("text");

                    b.Property<string>("Porotic_Hyperostosis")
                        .HasColumnType("text");

                    b.Property<string>("Porotic_Hyperostosis_Locations")
                        .HasColumnType("text");

                    b.Property<string>("Postcrania_At_Magazine")
                        .HasColumnType("text");

                    b.Property<string>("Postcrania_Trauma")
                        .HasColumnType("text");

                    b.Property<string>("Rack_And_Shelf")
                        .HasColumnType("text");

                    b.Property<string>("Skull_At_Magazine")
                        .HasColumnType("text");

                    b.Property<string>("Skull_Trauma")
                        .HasColumnType("text");

                    b.Property<string>("Temporal_Mandibular_Joint_Osteoarthritis")
                        .HasColumnType("text");

                    b.Property<string>("To_Be_Confirmed")
                        .HasColumnType("text");

                    b.Property<string>("Tomb")
                        .HasColumnType("text");

                    b.HasKey("Burial_Id");

                    b.ToTable("FieldNotes");
                });

            modelBuilder.Entity("DigginPharoh.Models.Note", b =>
                {
                    b.Property<string>("Burial_Id")
                        .HasColumnType("text");

                    b.Property<string>("Msg")
                        .HasColumnType("text");

                    b.HasKey("Burial_Id");

                    b.ToTable("JustNotes");
                });

            modelBuilder.Entity("DigginPharoh.Models.ProjectRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("RoleName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ProjectRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("character varying(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("character varying(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("character varying(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("character varying(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
