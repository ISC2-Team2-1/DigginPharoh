using DigginPharoh.Data;
using DigginPharoh.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigginPharoh.Controllers
{
    [Authorize(Roles ="Administrator")]
    public class AdminController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<IdentityUser> userManager;
        private ApplicationDbContext context { get; set; }

        public AdminController(RoleManager<IdentityRole> roleManager,
                                    UserManager<IdentityUser> userManager, 
                                    ApplicationDbContext ctx)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;

            context = ctx;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProjectRole role)
        {
            var roleExist = await roleManager.RoleExistsAsync(role.RoleName);
            if (!roleExist)
            {
                var result = await roleManager.CreateAsync(new IdentityRole(role.RoleName));
            }
            return View();
        }

        public IActionResult ManageUser()
        {
            var users = userManager.Users;
            var roles = roleManager.Roles;



            //Book book = repository.Books
            //.Where(b => b.BookId == bookid)
            //.FirstOrDefault();




            return View(users);
        }
    }
}
