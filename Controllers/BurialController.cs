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
    public class BurialController : Controller
    {
        private ApplicationDbContext _context { get; set; }

        public int PageSize = 20;

        public BurialController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Burial
        public async Task<IActionResult> Index(int pageNum = 1)
        {
            return View(new BurialListViewModel
            {
                Burials = _context.GamousBurials
                    .OrderBy(x => x.year_found)//we can probably add the functionality that allows research to filter by the nearest and furtherest year found of the gamous
                    .Skip((pageNum - 1) * PageSize)
                    .Take(PageSize),

                PagingInfo = new PagingInfo
                    {
                        CurrentPage = pageNum,
                        ItemsPerPage = PageSize,
                        TotalNumItems =  _context.GamousBurials.Count()
                    },

            });

            //return View(await _context.GamousBurials
            //    .OrderBy( x => x.year_found)//we can probably add the functionality that allows research to filter by the nearest and furtherest year found of the gamous
            //    .Skip((pageNum - 1) * pageSize)
            //    .Take(pageSize)
            //    .ToListAsync());
        }

        // GET: Burial/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var burial = await _context.GamousBurials
                .FirstOrDefaultAsync(m => m.Burial_Id == id);
            if (burial == null)
            {
                return NotFound();
            }

            return View(burial);
        }

        // GET: Burial/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Burial/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Burial_Id,Gamous_Id,burial_depth,WESTTOHEAD,WESTTOFEET,SOUTHTOHEAD,SOUTHTOFEET,Preservation,Burial_Situation,head_direction,Adult_Child,estimate_age,AGEMETHOD,gender_body_col,Sex_Gender_GE,SEXMETHOD,GE_function_total,length_of_remains,sample_number,basilar_suture,ventral_arc,subpubic_angle,sciatic_notch,pubic_bone,preaur_sulcus,medial_IP_ramus,dorsal_pitting,femur_head,humerus_head,osteophytosis,pubic_symphysis,femur_length,humerus_length,tibia_length,robust,supraorbital_ridges,orbit_edge,parietal_bossing,gonian,nuchal_crest,zygomatic_crest,cranial_suture,maximum_cranial_length,maximum_cranial_breadth,basion_bregma_height,basion_nasion,basion_prosthion_length,bizygomatic_diameter,nasion_prosthion,maximum_nasal_breadth,interorbital_breadth,artifacts_description,hair_color,hair_taken,soft_tissue_taken,bone_taken,tooth_taken,textile_taken,SAMPLE,description_of_taken,artifact_found,estimate_living_stature,tooth_attrition,tooth_eruption,pathology_anomalies,epiphyseal_union,year_found,month_found,day_found,Field_Book,Field_Book_Page_Number,Skull_At_Magazine,Postcrania_At_Magazine,Rack_And_Shelf,To_Be_Confirmed,Skull_Trauma,Postcrania_Trauma,Cribra_Orbitala,Porotic_Hyperostosis,Porotic_Hyperostosis_Locations,Metopic_Suture,Button_Osteoma,Osteology_Unknown_Comment,Temporal_Mandibular_Joint_Osteoarthritis,Linear_Hypoplasia_Enamel,Area_Hill_Burials,Tomb,Goods,Cluster,Face_Bundle,Body_Analysis_Year")] Burial burial)
        {
            if (ModelState.IsValid)
            {
                _context.Add(burial);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(burial);
        }

        // GET: Burial/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var burial = await _context.GamousBurials.FindAsync(id);
            if (burial == null)
            {
                return NotFound();
            }
            return View(burial);
        }

        // POST: Burial/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Burial_Id,Gamous_Id,burial_depth,WESTTOHEAD,WESTTOFEET,SOUTHTOHEAD,SOUTHTOFEET,Preservation,Burial_Situation,head_direction,Adult_Child,estimate_age,AGEMETHOD,gender_body_col,Sex_Gender_GE,SEXMETHOD,GE_function_total,length_of_remains,sample_number,basilar_suture,ventral_arc,subpubic_angle,sciatic_notch,pubic_bone,preaur_sulcus,medial_IP_ramus,dorsal_pitting,femur_head,humerus_head,osteophytosis,pubic_symphysis,femur_length,humerus_length,tibia_length,robust,supraorbital_ridges,orbit_edge,parietal_bossing,gonian,nuchal_crest,zygomatic_crest,cranial_suture,maximum_cranial_length,maximum_cranial_breadth,basion_bregma_height,basion_nasion,basion_prosthion_length,bizygomatic_diameter,nasion_prosthion,maximum_nasal_breadth,interorbital_breadth,artifacts_description,hair_color,hair_taken,soft_tissue_taken,bone_taken,tooth_taken,textile_taken,SAMPLE,description_of_taken,artifact_found,estimate_living_stature,tooth_attrition,tooth_eruption,pathology_anomalies,epiphyseal_union,year_found,month_found,day_found,Field_Book,Field_Book_Page_Number,Skull_At_Magazine,Postcrania_At_Magazine,Rack_And_Shelf,To_Be_Confirmed,Skull_Trauma,Postcrania_Trauma,Cribra_Orbitala,Porotic_Hyperostosis,Porotic_Hyperostosis_Locations,Metopic_Suture,Button_Osteoma,Osteology_Unknown_Comment,Temporal_Mandibular_Joint_Osteoarthritis,Linear_Hypoplasia_Enamel,Area_Hill_Burials,Tomb,Goods,Cluster,Face_Bundle,Body_Analysis_Year")] Burial burial)
        {
            if (id != burial.Burial_Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(burial);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BurialExists(burial.Burial_Id))
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
            return View(burial);
        }

        // GET: Burial/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var burial = await _context.GamousBurials
                .FirstOrDefaultAsync(m => m.Burial_Id == id);
            if (burial == null)
            {
                return NotFound();
            }

            return View(burial);
        }

        // POST: Burial/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var burial = await _context.GamousBurials.FindAsync(id);
            _context.GamousBurials.Remove(burial);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BurialExists(string id)
        {
            return _context.GamousBurials.Any(e => e.Burial_Id == id);
        }
    }
}
