using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Use this controller for 
//
//  - Adding  info to database
//  - Editing info in database (field notes)
//  - Editing info in database (mummy stuff)

namespace DigginPharoh.Controllers
{
    [Authorize(Roles = "Researcher")]
    public class ResearchController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
