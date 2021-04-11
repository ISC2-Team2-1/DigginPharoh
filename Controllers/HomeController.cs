using DigginPharoh.Data;
using DigginPharoh.Models;
using DigginPharoh.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DigginPharoh.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ApplicationDbContext context { get; set; }
        public int PageSize = 15;
        

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext ctx)
        {
            _logger = logger;
            context = ctx;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EditForm(string editId)
        {
            Burial burialToEdit = context.GamousBurials.FirstOrDefault(s => s.Burial_Id == editId);
            ViewBag.burialToEdit = burialToEdit;
            return View("EditForm");
        }

        public IActionResult DetailEditForm(string editId)
        {
            Burial burialToEdit = context.GamousBurials.FirstOrDefault(s => s.Burial_Id == editId);
            ViewBag.burialToEdit = burialToEdit;
            return View("DetailEditForm");
        }

        public IActionResult BurialSummary(string id, string deletionId, int pageNum = 1, Burial? burialWithEdits = null) //pass in string id

        {
            var filters = new Filters(id);
            ViewBag.Filters = filters;
            ViewBag.GamousBurials = context.GamousBurials.ToList(); // To get head direction
            ViewBag.HeadDirFilterValues = Filters.HeadDirFilterValues;

            IQueryable<Burial> query = context.GamousBurials;

            //if (filters.HasDirection)
            //{
            //    query = query.Where(t => t.head_direction.ToLower() == filters.HeadDirection.ToLower()) ;
            //}
            //if (filters.HasDepth)
            //{
            //    query = query.Where(t => t.burial_depth == filters.Depth);
            //}
            //if (filters.HasSexGe)
            //{
            //    query = query.Where(t => t.Sex_Gender_GE == filters.SexGE.ToLower());
            //}
            //if (filters.HasGenderBodCol)
            //{
            //    query = query.Where(t => t.gender_body_col.ToLower() == filters.GenderBodCol.ToLower());
            //}
            //if (filters.HasPreservation)
            //{
            //    query = query.Where(t => t.Preservation.ToLower() == filters.Preservation.ToLower());
            //}

            //year is not in contex.GamousBurials query
            //if (filters.HasYear)
            //{
            //    query = query.Where(t => t.head_direction.ToLower() == filters.YearFound);
            //}


            //if people want to delete a record, the summary page will get deleteid
            //here, we will check if the deleteid and the burialid matches;then, we will delete the record from the database
            if (deletionId != null)
            {
                context.Remove(context.GamousBurials.FirstOrDefault(s => s.Burial_Id == deletionId));
                context.SaveChanges();
            }

            //if people want to edit a record, the summary page will get editid
            //here, we will check if the editid and the burialid matches;then, we will allow edit and updates of that record
            if (burialWithEdits.Burial_Id != null)
            {
                var burialToEdit = context.GamousBurials.FirstOrDefault(s => s.Burial_Id == burialWithEdits.Burial_Id);

                //Those lines are for summary and detail page columns data update
                burialToEdit.Gamous_Id = burialWithEdits.Gamous_Id;
                burialToEdit.burial_depth = burialWithEdits.burial_depth;
                burialToEdit.WESTTOHEAD = burialWithEdits.WESTTOHEAD;
                burialToEdit.WESTTOFEET = burialWithEdits.WESTTOFEET;
                burialToEdit.SOUTHTOHEAD = burialWithEdits.SOUTHTOHEAD;
                burialToEdit.SOUTHTOFEET = burialWithEdits.SOUTHTOFEET;
                burialToEdit.Preservation = burialWithEdits.Preservation;
                burialToEdit.Burial_Situation = burialWithEdits.Burial_Situation;
                burialToEdit.head_direction = burialWithEdits.head_direction;
                burialToEdit.Adult_Child = burialWithEdits.Adult_Child;
                burialToEdit.estimate_age = burialWithEdits.estimate_age;
                burialToEdit.AGEMETHOD = burialWithEdits.AGEMETHOD;
                burialToEdit.gender_body_col = burialWithEdits.gender_body_col;
                burialToEdit.Sex_Gender_GE = burialWithEdits.Sex_Gender_GE;
                burialToEdit.SEXMETHOD = burialWithEdits.SEXMETHOD;
                burialToEdit.GE_function_total = burialWithEdits.GE_function_total;
                burialToEdit.length_of_remains = burialWithEdits.length_of_remains;
                burialToEdit.Rack_And_Shelf = burialWithEdits.Rack_And_Shelf;
                burialToEdit.Button_Osteoma = burialWithEdits.Button_Osteoma;
                burialToEdit.Tomb = burialWithEdits.Tomb;
                burialToEdit.Goods = burialWithEdits.Goods;
                burialToEdit.Cluster = burialWithEdits.Cluster;
                burialToEdit.Face_Bundle = burialWithEdits.Face_Bundle;
                burialToEdit.Area_Hill_Burials = burialWithEdits.Area_Hill_Burials;
                burialToEdit.Linear_Hypoplasia_Enamel = burialWithEdits.Linear_Hypoplasia_Enamel;
                burialToEdit.Body_Analysis_Year = burialWithEdits.Body_Analysis_Year;
                burialToEdit.Temporal_Mandibular_Joint_Osteoarthritis = burialWithEdits.Temporal_Mandibular_Joint_Osteoarthritis;
                burialToEdit.Osteology_Unknown_Comment = burialWithEdits.Osteology_Unknown_Comment;
                burialToEdit.SAMPLE = burialWithEdits.SAMPLE;
                burialToEdit.basilar_suture = burialWithEdits.basilar_suture;
                burialToEdit.ventral_arc = burialWithEdits.ventral_arc;
                burialToEdit.subpubic_angle = burialWithEdits.subpubic_angle;
                burialToEdit.sciatic_notch = burialWithEdits.sciatic_notch;
                burialToEdit.pubic_bone = burialWithEdits.pubic_bone;
                burialToEdit.preaur_sulcus = burialWithEdits.preaur_sulcus;
                burialToEdit.medial_IP_ramus = burialWithEdits.medial_IP_ramus;
                burialToEdit.dorsal_pitting = burialWithEdits.dorsal_pitting;
                burialToEdit.femur_head = burialWithEdits.femur_head;
                burialToEdit.humerus_head = burialWithEdits.humerus_head;
                burialToEdit.osteophytosis = burialWithEdits.osteophytosis;
                burialToEdit.pubic_symphysis = burialWithEdits.pubic_symphysis;
                burialToEdit.femur_length = burialWithEdits.femur_length;
                burialToEdit.humerus_length = burialWithEdits.humerus_length;
                burialToEdit.tibia_length = burialWithEdits.tibia_length;
                burialToEdit.robust = burialWithEdits.robust;
                burialToEdit.supraorbital_ridges = burialWithEdits.supraorbital_ridges;
                burialToEdit.hair_color = burialWithEdits.hair_color;
                burialToEdit.hair_taken = burialWithEdits.hair_taken;
                burialToEdit.Postcrania_At_Magazine = burialWithEdits.Postcrania_At_Magazine;
                burialToEdit.Skull_Trauma = burialWithEdits.Skull_Trauma;
                burialToEdit.Postcrania_Trauma = burialWithEdits.Postcrania_Trauma;
                burialToEdit.Cribra_Orbitala = burialWithEdits.Cribra_Orbitala;
                burialToEdit.Porotic_Hyperostosis = burialWithEdits.Porotic_Hyperostosis;
                burialToEdit.Porotic_Hyperostosis_Locations = burialWithEdits.Porotic_Hyperostosis_Locations;
                burialToEdit.Metopic_Suture = burialWithEdits.Metopic_Suture;
                burialToEdit.artifacts_description = burialWithEdits.artifacts_description;
                burialToEdit.interorbital_breadth = burialWithEdits.interorbital_breadth;
                burialToEdit.maximum_nasal_breadth = burialWithEdits.maximum_nasal_breadth;
                burialToEdit.orbit_edge = burialWithEdits.orbit_edge;
                burialToEdit.soft_tissue_taken = burialWithEdits.soft_tissue_taken;
                burialToEdit.bone_taken = burialWithEdits.bone_taken;
                burialToEdit.tooth_taken = burialWithEdits.tooth_taken;
                burialToEdit.description_of_taken = burialWithEdits.description_of_taken;
                burialToEdit.artifact_found = burialWithEdits.artifact_found;
                burialToEdit.estimate_living_stature = burialWithEdits.estimate_living_stature;
                burialToEdit.tooth_attrition = burialWithEdits.tooth_attrition;
                burialToEdit.tooth_eruption = burialWithEdits.tooth_eruption;
                burialToEdit.pathology_anomalies = burialWithEdits.pathology_anomalies;
                burialToEdit.epiphyseal_union = burialWithEdits.epiphyseal_union;
                burialToEdit.year_found = burialWithEdits.year_found;
                burialToEdit.month_found = burialWithEdits.month_found;
                burialToEdit.day_found = burialWithEdits.day_found;
                burialToEdit.Field_Book = burialWithEdits.Field_Book;
                burialToEdit.Field_Book_Page_Number = burialWithEdits.Field_Book_Page_Number;
                burialToEdit.Skull_At_Magazine = burialWithEdits.Skull_At_Magazine;
                burialToEdit.nasion_prosthion = burialWithEdits.nasion_prosthion;
                burialToEdit.bizygomatic_diameter = burialWithEdits.bizygomatic_diameter;
                burialToEdit.basion_prosthion_length = burialWithEdits.basion_prosthion_length;
                burialToEdit.basion_nasion = burialWithEdits.basion_nasion;
                burialToEdit.basion_bregma_height = burialWithEdits.basion_bregma_height;
                burialToEdit.maximum_cranial_breadth = burialWithEdits.maximum_cranial_breadth;
                burialToEdit.maximum_cranial_length = burialWithEdits.maximum_cranial_length;
                burialToEdit.cranial_suture = burialWithEdits.cranial_suture;
                burialToEdit.zygomatic_crest = burialWithEdits.zygomatic_crest;
                burialToEdit.nuchal_crest = burialWithEdits.nuchal_crest;
                burialToEdit.gonian = burialWithEdits.gonian;
                burialToEdit.parietal_bossing = burialWithEdits.parietal_bossing;



                context.SaveChanges();
            }


            return View(new IndexViewModel 
            { 
                BurialList = query
                    .OrderBy(x => x.year_found)//we can probably add the functionality that allows research to filter by the nearest and furtherest year found of the gamous
                    .Skip((pageNum - 1) * PageSize)
                    .Take(PageSize),
                BurialIDInfoList = context.BurialIdInfos,
                BiologicalSampleList = context.BioSamples,
                CranialList = context.Craniums,
                NoteList = context.JustNotes,
                Carbon_DatingList = context.CarbonDates,

                PagingInfo = new PagingInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = PageSize,
                    TotalNumItems = query.Count()
                },
            });
        }

        //This is called when the form on the Burial Summary page is submitted
        [HttpPost]
        public IActionResult Filter(string[] filter)
        {
            string id = string.Join('-', filter);
            return RedirectToAction("BurialSummary", new { ID = id });
        }


        // GET: Burials/Create
        public IActionResult Create(string burialId)
        {
            ViewBag.BurialId = burialId;
            return View();
        }

        // POST: Burials/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Burial_Id,Gamous_Id,burial_depth,WESTTOHEAD,WESTTOFEET,SOUTHTOHEAD,SOUTHTOFEET,Preservation,Burial_Situation,head_direction,Adult_Child,estimate_age,AGEMETHOD,gender_body_col,Sex_Gender_GE,SEXMETHOD,GE_function_total,length_of_remains,sample_number,basilar_suture,ventral_arc,subpubic_angle,sciatic_notch,pubic_bone,preaur_sulcus,medial_IP_ramus,dorsal_pitting,femur_head,humerus_head,osteophytosis,pubic_symphysis,femur_length,humerus_length,tibia_length,robust,supraorbital_ridges,orbit_edge,parietal_bossing,gonian,nuchal_crest,zygomatic_crest,cranial_suture,maximum_cranial_length,maximum_cranial_breadth,basion_bregma_height,basion_nasion,basion_prosthion_length,bizygomatic_diameter,nasion_prosthion,maximum_nasal_breadth,interorbital_breadth,artifacts_description,hair_color,hair_taken,soft_tissue_taken,bone_taken,tooth_taken,textile_taken,SAMPLE,description_of_taken,artifact_found,estimate_living_stature,tooth_attrition,tooth_eruption,pathology_anomalies,epiphyseal_union,year_found,month_found,day_found,Field_Book,Field_Book_Page_Number,Skull_At_Magazine,Postcrania_At_Magazine,Rack_And_Shelf,To_Be_Confirmed,Skull_Trauma,Postcrania_Trauma,Cribra_Orbitala,Porotic_Hyperostosis,Porotic_Hyperostosis_Locations,Metopic_Suture,Button_Osteoma,Osteology_Unknown_Comment,Temporal_Mandibular_Joint_Osteoarthritis,Linear_Hypoplasia_Enamel,Area_Hill_Burials,Tomb,Goods,Cluster,Face_Bundle,Body_Analysis_Year")] Burial burial)
        {
            if (ModelState.IsValid)
            {
                context.Add(burial);
                await context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(burial);
        }

        // GET: Id/Create
        public IActionResult CreateId()
        {
            return View();
        }

        // POST: Id/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateId([Bind("Burial_Id,burial_location_NS,burial_location_EW,low_pair_NS,high_pair_NS,low_pair_EW,high_pair_EW,burial_subplot,BURIALNUM")] BurialIDInfo burialIDInfo)
        {
            if (ModelState.IsValid)
            {
                context.Add(burialIDInfo);
                await context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        public IActionResult BurialDetails(string detailId)
        {
            return View(new IndexViewModel
            {
                BurialList = context.GamousBurials
                 .Where(s => s.Burial_Id == detailId)
            });
        }

        public IActionResult FieldNotes(string Burial_Id)
        {
            return View(new IndexViewModel
            {
                BurialList = context.GamousBurials,
                BurialIDInfoList = context.BurialIdInfos,
                BiologicalSampleList = context.BioSamples,
                CranialList = context.Craniums,
                NoteList = context.JustNotes,
                Carbon_DatingList = context.CarbonDates,
            });
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
