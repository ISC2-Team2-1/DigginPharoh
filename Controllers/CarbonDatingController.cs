using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DigginPharoh.Data;
using DigginPharoh.Models;

namespace DigginPharoh.Controllers
{
    public class CarbonDatingController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CarbonDatingController(ApplicationDbContext context)
        {
            _context = context;
        }

      
        // GET: CarbonDating/Create
        public IActionResult CreateCarbonDating(string burialId)
        {
            ViewBag.BurialId = burialId;
            return View();
        }

        // POST: CarbonDating/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateCarbonDating([Bind("Burial_Id,AREA_Num,Rack_Num,TUBE_Num,Description,Size_ml,Foci,C14_Sample_2017,Location,Question,Conventional_14C_Age_BP,Calendar_Date_14C,Calibrated_95_Calendar_Date_MAX,Calibrated_95_Calendar_Date_MIN,Calibrated_95_Calendar_Date_SPAN,Calibrated_95_Calendar_Date_AVG,Category,Notes")] Carbon_Dating carbon_Dating)
        {
            if (ModelState.IsValid)
            {
                _context.Add(carbon_Dating);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(carbon_Dating);
        }

       
    }
}
