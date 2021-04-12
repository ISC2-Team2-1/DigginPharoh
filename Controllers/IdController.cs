using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DigginPharoh.Data;
using DigginPharoh.Models;
using DigginPharoh.Models.ViewModels;

namespace DigginPharoh.Controllers
{
    public class IdController : Controller
    {
        private readonly ApplicationDbContext _context;

        public string burialIdHolder;

        public IdController(ApplicationDbContext context)
        {
            _context = context;

        }

        //This is the source
        // POST: Id/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateId([Bind("Burial_Id,burial_location_NS,burial_location_EW,low_pair_NS,high_pair_NS,low_pair_EW,high_pair_EW,burial_subplot,BURIALNUM")] BurialIDInfo burialIDInfo)
        {
            if (ModelState.IsValid)
            {
                var NextPage = burialIDInfo.Burial_Id;
                burialIDInfo.high_pair_EW = burialIDInfo.low_pair_EW + 10;
                burialIDInfo.high_pair_NS = burialIDInfo.low_pair_NS + 10;
                burialIDInfo.Burial_Id = burialIDInfo.burial_location_NS + " " + burialIDInfo.low_pair_NS.ToString() + "/" + burialIDInfo.high_pair_NS.ToString() + " " + burialIDInfo.burial_location_EW + " " + burialIDInfo.low_pair_EW.ToString() + "/" + burialIDInfo.high_pair_EW.ToString() + " " + burialIDInfo.burial_subplot + " #" + burialIDInfo.BURIALNUM;

                burialIdHolder = burialIDInfo.Burial_Id;

                _context.Add(burialIDInfo);
                await _context.SaveChangesAsync();

                if (NextPage == "Burial")
                {
                    return RedirectToAction("IndexId", new { ID = burialIdHolder });
                }

                if (NextPage == "Biological Sample")
                {
                    return RedirectToAction("IndexId", new { ID = burialIdHolder });
                }

                if (NextPage == "Cranial")
                {
                    return RedirectToAction("IndexId", new { ID = burialIdHolder });
                }

                if (NextPage == "Carbon Dating")
                {
                    return RedirectToAction("IndexId", new { ID = burialIdHolder });
                }

                if (NextPage == "Note")
                {
                    return RedirectToAction("IndexId", new { ID = burialIdHolder });
                }
            }

            return View(burialIDInfo); // make error page
        }

        // GET: Id
        public IActionResult IndexId(string id) // This is the destination
        {
            ViewBag.BurialId = id;

            return View();
        }


        // GET: Id/Create
        public IActionResult CreateId()
        {
            return View();
        }


       
    }
}
