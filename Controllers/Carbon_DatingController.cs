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
    public class Carbon_DatingController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Carbon_DatingController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Carbon_Dating
        public async Task<IActionResult> Index()
        {
            return View(await _context.CarbonDates.ToListAsync());
        }

        // GET: Carbon_Dating/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carbon_Dating = await _context.CarbonDates
                .FirstOrDefaultAsync(m => m.Burial_Id == id);
            if (carbon_Dating == null)
            {
                return NotFound();
            }

            return View(carbon_Dating);
        }

        // GET: Carbon_Dating/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Carbon_Dating/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Burial_Id,AREA_Num,Rack_Num,TUBE_Num,Description,Size_ml,Foci,C14_Sample_2017,Location,Question,Conventional_14C_Age_BP,Calendar_Date_14C,Calibrated_95_Calendar_Date_MAX,Calibrated_95_Calendar_Date_MIN,Calibrated_95_Calendar_Date_SPAN,Calibrated_95_Calendar_Date_AVG,Category,Notes")] Carbon_Dating carbon_Dating)
        {
            if (ModelState.IsValid)
            {
                _context.Add(carbon_Dating);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(carbon_Dating);
        }

        // GET: Carbon_Dating/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carbon_Dating = await _context.CarbonDates.FindAsync(id);
            if (carbon_Dating == null)
            {
                return NotFound();
            }
            return View(carbon_Dating);
        }

        // POST: Carbon_Dating/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Burial_Id,AREA_Num,Rack_Num,TUBE_Num,Description,Size_ml,Foci,C14_Sample_2017,Location,Question,Conventional_14C_Age_BP,Calendar_Date_14C,Calibrated_95_Calendar_Date_MAX,Calibrated_95_Calendar_Date_MIN,Calibrated_95_Calendar_Date_SPAN,Calibrated_95_Calendar_Date_AVG,Category,Notes")] Carbon_Dating carbon_Dating)
        {
            if (id != carbon_Dating.Burial_Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(carbon_Dating);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Carbon_DatingExists(carbon_Dating.Burial_Id))
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
            return View(carbon_Dating);
        }

        // GET: Carbon_Dating/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carbon_Dating = await _context.CarbonDates
                .FirstOrDefaultAsync(m => m.Burial_Id == id);
            if (carbon_Dating == null)
            {
                return NotFound();
            }

            return View(carbon_Dating);
        }

        // POST: Carbon_Dating/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var carbon_Dating = await _context.CarbonDates.FindAsync(id);
            _context.CarbonDates.Remove(carbon_Dating);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Carbon_DatingExists(string id)
        {
            return _context.CarbonDates.Any(e => e.Burial_Id == id);
        }
    }
}
