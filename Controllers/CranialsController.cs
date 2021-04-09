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

        // GET: Cranials
        public async Task<IActionResult> Index()
        {
            return View(await _context.Craniums.ToListAsync());
        }

        // GET: Cranials/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cranial = await _context.Craniums
                .FirstOrDefaultAsync(m => m.Burial_Id == id);
            if (cranial == null)
            {
                return NotFound();
            }

            return View(cranial);
        }

        // GET: Cranials/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cranials/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Burial_Id,Burial_Depth,Sample_Number,Maximum_Cranial_Length,Maximum_Cranial_Breadth,Basion_Bregma_Height,Basion_Nasion,Basion_Prosthion_Length,Bizygomatic_Diameter,Nasion_Prosthion,Maximum_Nasal_Breadth,Interorbital_Breadth,Burial_Artifact_Description,Buried_with_Artifacts,Giles_Gender,Body_Gender")] Cranial cranial)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cranial);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cranial);
        }

        // GET: Cranials/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cranial = await _context.Craniums.FindAsync(id);
            if (cranial == null)
            {
                return NotFound();
            }
            return View(cranial);
        }

        // POST: Cranials/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Burial_Id,Burial_Depth,Sample_Number,Maximum_Cranial_Length,Maximum_Cranial_Breadth,Basion_Bregma_Height,Basion_Nasion,Basion_Prosthion_Length,Bizygomatic_Diameter,Nasion_Prosthion,Maximum_Nasal_Breadth,Interorbital_Breadth,Burial_Artifact_Description,Buried_with_Artifacts,Giles_Gender,Body_Gender")] Cranial cranial)
        {
            if (id != cranial.Burial_Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cranial);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CranialExists(cranial.Burial_Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(cranial);
        }

        // GET: Cranials/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cranial = await _context.Craniums
                .FirstOrDefaultAsync(m => m.Burial_Id == id);
            if (cranial == null)
            {
                return NotFound();
            }

            return View(cranial);
        }

        // POST: Cranials/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var cranial = await _context.Craniums.FindAsync(id);
            _context.Craniums.Remove(cranial);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CranialExists(string id)
        {
            return _context.Craniums.Any(e => e.Burial_Id == id);
        }
    }
}
