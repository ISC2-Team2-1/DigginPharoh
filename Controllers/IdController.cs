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
        //Saves correct value in one function but is null when I call it int the next function
        //public string burialIdHolder;

        public System.Collections.IDictionary dictionary;

        //Null reference error unless I pass it int the controller function, in which case it doesn not allow me to also pass context
        //I assume that I cannot add it to context because it is not in the database
        //public BurialIdVariable burialIdHolder;

        public IdController(ApplicationDbContext context)
        {
            _context = context;

        }

        //View callot load when I try to pass in both. I don't know why it works in the controller

        //public string burialIdHolder;

        //public IdController(string BurialIdVar, ApplicationDbContext context)
        //{
        //    _context = context;
        //    burialIdHolder = BurialIdVar;

        //}


        //This is the source
        // POST: Id/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Burial_Id,burial_location_NS,burial_location_EW,low_pair_NS,high_pair_NS,low_pair_EW,high_pair_EW,burial_subplot,BURIALNUM")] BurialIDInfo burialIDInfo)
        {
            if (ModelState.IsValid)
            {
                burialIDInfo.high_pair_EW = burialIDInfo.low_pair_EW + 10;
                burialIDInfo.high_pair_NS = burialIDInfo.low_pair_NS + 10;

                //dictionary.Set(burialIDInfo.Burial_Id);

                //Saves here but is null when called in other function
                //burialIdHolder = burialIDInfo.Burial_Id;

                //null reference error
                //burialIdHolder.BurialIdVar = burialIDInfo.Burial_Id;
                _context.Add(burialIDInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(burialIDInfo);
        }

        // GET: Id
        public IActionResult Index(string burialIdHolder) // This is the destination
        {
            //Burial Id holder value is not saved from when it is set in other function
            //ViewBag.BurialId = burialIdHolder;

            //ViewBag.BurialId = burialIdHolder.Key");

            //Never makes it here, null reference exception earlier
            //ViewBag.BurialId = burialIdHolder.BurialIdVar;

            //Cannot apply indexing with [] to this dbset
            //ViewBag.BurialId = _context.BurialIdInfos[-1]

            return View();
        }


        // GET: Id/Create
        public IActionResult Create()
        {
            return View();
        }


        // GET: Id/Details/5
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

        

        // GET: Id/Edit/5
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

        // POST: Id/Edit/5
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

        // GET: Id/Delete/5
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

        // POST: Id/Delete/5
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
