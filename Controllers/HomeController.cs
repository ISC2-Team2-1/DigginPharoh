using DigginPharoh.Data;
using DigginPharoh.Models;
using DigginPharoh.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
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
        private ApplicationDbContext context;
        public int PageSize = 10;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext ctx)
        {
            _logger = logger;
            context = ctx;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BurialSummary(int pageNum = 1)
        {
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

        public IActionResult BurialDetails(string? Burial_Id)
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
