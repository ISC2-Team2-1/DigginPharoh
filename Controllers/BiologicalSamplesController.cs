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

        // GET: BiologicalSamples
        public async Task<IActionResult> Index()
        {
            return View(await _context.BioSamples.ToListAsync());
        }

        // GET: BiologicalSamples/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var biologicalSamples = await _context.BioSamples
                .FirstOrDefaultAsync(m => m.Burial_id == id);
            if (biologicalSamples == null)
            {
                return NotFound();
            }

            return View(biologicalSamples);
        }

        // GET: BiologicalSamples/Create
        public IActionResult Create(string burialId)
        {
            ViewBag.BurialId = burialId;
            return View();
        }

        // POST: BiologicalSamples/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Burial_id,Container_Type,Container_num,Large_Item,Cluster_num,Previously_Sampled,Notes,Initials")] BiologicalSamples biologicalSamples)
        {
            if (ModelState.IsValid)
            {
                _context.Add(biologicalSamples);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(biologicalSamples);
        }

        // GET: BiologicalSamples/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var biologicalSamples = await _context.BioSamples.FindAsync(id);
            if (biologicalSamples == null)
            {
                return NotFound();
            }
            return View(biologicalSamples);
        }

        // POST: BiologicalSamples/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Burial_id,Container_Type,Container_num,Large_Item,Cluster_num,Previously_Sampled,Notes,Initials")] BiologicalSamples biologicalSamples)
        {
            if (id != biologicalSamples.Burial_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(biologicalSamples);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BiologicalSamplesExists(biologicalSamples.Burial_id))
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
            return View(biologicalSamples);
        }

        // GET: BiologicalSamples/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var biologicalSamples = await _context.BioSamples
                .FirstOrDefaultAsync(m => m.Burial_id == id);
            if (biologicalSamples == null)
            {
                return NotFound();
            }

            return View(biologicalSamples);
        }

        // POST: BiologicalSamples/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var biologicalSamples = await _context.BioSamples.FindAsync(id);
            _context.BioSamples.Remove(biologicalSamples);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BiologicalSamplesExists(string id)
        {
            return _context.BioSamples.Any(e => e.Burial_id == id);
        }
    }
}
