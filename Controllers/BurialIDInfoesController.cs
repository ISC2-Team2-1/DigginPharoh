﻿using System;
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
    public class BurialIDInfoesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BurialIDInfoesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: BurialIDInfoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.BurialIdInfos.ToListAsync());
        }

        // GET: BurialIDInfoes/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var burialIDInfo = await _context.BurialIdInfos
                .FirstOrDefaultAsync(m => m.Burial_Id == id);
            if (burialIDInfo == null)
            {
                return NotFound();
            }

            return View(burialIDInfo);
        }

        // GET: BurialIDInfoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BurialIDInfoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Burial_Id,burial_location_NS,burial_location_EW,low_pair_NS,high_pair_NS,low_pair_EW,high_pair_EW,burial_subplot,BURIALNUM")] BurialIDInfo burialIDInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(burialIDInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(burialIDInfo);
        }

        // GET: BurialIDInfoes/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var burialIDInfo = await _context.BurialIdInfos.FindAsync(id);
            if (burialIDInfo == null)
            {
                return NotFound();
            }
            return View(burialIDInfo);
        }

        // POST: BurialIDInfoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Burial_Id,burial_location_NS,burial_location_EW,low_pair_NS,high_pair_NS,low_pair_EW,high_pair_EW,burial_subplot,BURIALNUM")] BurialIDInfo burialIDInfo)
        {
            if (id != burialIDInfo.Burial_Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(burialIDInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BurialIDInfoExists(burialIDInfo.Burial_Id))
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
            return View(burialIDInfo);
        }

        // GET: BurialIDInfoes/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var burialIDInfo = await _context.BurialIdInfos
                .FirstOrDefaultAsync(m => m.Burial_Id == id);
            if (burialIDInfo == null)
            {
                return NotFound();
            }

            return View(burialIDInfo);
        }

        // POST: BurialIDInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var burialIDInfo = await _context.BurialIdInfos.FindAsync(id);
            _context.BurialIdInfos.Remove(burialIDInfo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BurialIDInfoExists(string id)
        {
            return _context.BurialIdInfos.Any(e => e.Burial_Id == id);
        }
    }
}