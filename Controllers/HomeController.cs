﻿using DigginPharoh.Data;
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

        public IActionResult BurialSummary(int pageNum = 1, string? id = null) //pass in string id
        {
            var filters = new Filters(id);
            ViewBag.Filters = filters;
            //ViewBag.Categories = context.Categories.ToList();
            //ViewBag.Statuses = context.Statuses.ToList();
            //ViewBag.DueFilters = Filters.DueFilterValues;
            ViewBag.GamousBurials = context.GamousBurials.ToList(); // To get head direction

            IQueryable<Burial> query = context.GamousBurials
                .Include(t => t.head_direction);


            if (filters.HasDirection)
            {
                query = query.Where(t => t.head_direction == filters.HeadDirection);
            }


            return View(new IndexViewModel 
            { 
                BurialList = context.GamousBurials
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
                    TotalNumItems = context.GamousBurials.Count()
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
        public IActionResult Create()
        {
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



        public IActionResult BurialDetails(string detailId)
        {
            Burial burialToEdit = context.GamousBurials.FirstOrDefault(s => s.Burial_Id == detailId);
            return View("BurialDetails", context.GamousBurials);
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

        [HttpPost]
        public IActionResult EditForm(string editId)
        {
            Burial burialToEdit = context.GamousBurials.FirstOrDefault(s => s.Burial_Id == editId);
            ViewBag.burialToEdit = burialToEdit;
            return View("EditForm");
        }

        //Edit the database record
        //we got the movieToEdit from the previous EditFrom Method
        [HttpPost]
        public IActionResult Edit(Burial burialWithEdits)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.burialToEdit = burialWithEdits;
                return View("EditForm");
            }
            else
            {
                var burialToEdit = context.GamousBurials.FirstOrDefault(s => s.Burial_Id == burialWithEdits.Burial_Id);
                burialToEdit.Burial_Id = burialWithEdits.Burial_Id;
                burialToEdit.burial_depth = burialWithEdits.burial_depth;
                burialToEdit.Sex_Gender_GE = burialWithEdits.Sex_Gender_GE;
                burialToEdit.gender_body_col = burialWithEdits.gender_body_col;
                burialToEdit.head_direction = burialWithEdits.head_direction;
                burialToEdit.Preservation = burialWithEdits.Preservation;
                burialToEdit.year_found = burialWithEdits.year_found;
                context.SaveChanges();
                return View("BurialSummary", context.GamousBurials);
            }

        }

        //Delete records
        //By matching the deleteId we got from the input, we can delete the correct one that the user wants to delete
        [HttpPost]
        public IActionResult Delete(string deletionId)
        {
            context.Remove(context.GamousBurials.FirstOrDefault(s => s.Burial_Id == deletionId));
            context.SaveChanges();
            return View("BurialSummary", context.GamousBurials);
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
