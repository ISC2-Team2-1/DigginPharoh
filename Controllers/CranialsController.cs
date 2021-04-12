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
    public class CranialsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CranialsController(ApplicationDbContext context)
        {
            _context = context;
        }


        // GET: Cranials/Create
        public IActionResult CreateCranial(string burialId)
        {
            ViewBag.BurialId = burialId;
            return View();
        }

        // POST: Cranials/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateCranial([Bind("Burial_Id,Burial_Depth,Sample_Number,Maximum_Cranial_Length,Maximum_Cranial_Breadth,Basion_Bregma_Height,Basion_Nasion,Basion_Prosthion_Length,Bizygomatic_Diameter,Nasion_Prosthion,Maximum_Nasal_Breadth,Interorbital_Breadth,Burial_Artifact_Description,Buried_with_Artifacts,Giles_Gender,Body_Gender")] Cranial cranial)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cranial);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cranial);
        }

    }
}
