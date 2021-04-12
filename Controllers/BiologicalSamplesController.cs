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
    public class BiologicalSamplesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BiologicalSamplesController(ApplicationDbContext context)
        {
            _context = context;
        }

       
        // GET: BiologicalSamples/Create
        public IActionResult CreateBioSample(string burialId)
        {
            ViewBag.BurialId = burialId;
            return View();
        }

        // POST: BiologicalSamples/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateBioSample([Bind("Burial_id,Container_Type,Container_num,Large_Item,Cluster_num,Previously_Sampled,Notes,Initials")] BiologicalSamples biologicalSamples)
        {
            if (ModelState.IsValid)
            {
                _context.Add(biologicalSamples);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(biologicalSamples);
        }

    }
}
