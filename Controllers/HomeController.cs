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

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext ctx)
        {
            _logger = logger;
            context = ctx;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BurialSummary()
        {
            return View(new IndexViewModel
            {
                BurialList = context.GamousBurials,
                BurialIDInfoList = context.BurialIdInfos
            });
        }


        //public IEnumerable<Burial> BurialList { get; set; }
        //public IEnumerable<BurialIDInfo> BurialIDInfoList { get; set; }
        //public IEnumerable<BiologicalSamples> BiologicalSampleList { get; set; }
        //public IEnumerable<Carbon_Dating> Carbon_DatingList { get; set; }
        //public IEnumerable<Cranial> CranialList { get; set; }
        //public IEnumerable<Note> NoteList { get; set; }

        //public DbSet<BiologicalSamples> BioSamples { get; set; }
        //public DbSet<Burial> GamousBurials { get; set; }
        //public DbSet<BurialIDInfo> BurialIdInfos { get; set; }
        //public DbSet<Carbon_Dating> CarbonDates { get; set; }
        //public DbSet<Cranial> Craniums { get; set; }
        //public DbSet<Field_Note> FieldNotes { get; set; }
        //public DbSet<Note> JustNotes { get; set; }
        //public DbSet<DigginPharoh.Models.ProjectRole> ProjectRoles { get; set; }
        //public IActionResult HomePage()
        //{
        //    return View();
        //}


=======
>>>>>>> f7d284c941e264f80709964ff92194b6d488ab65
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
