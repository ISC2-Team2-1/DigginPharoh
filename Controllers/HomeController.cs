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
            return View(new IndexViewModel
            {
                BurialList = context.GamousBurials
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
