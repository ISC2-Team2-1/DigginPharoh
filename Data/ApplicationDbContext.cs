using DigginPharoh.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigginPharoh.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext()
        {

        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<BiologicalSamples> Samples { get; set; }
        public DbSet<Burial> Burials { get; set; }
        public DbSet<BurialIDInfo> Infos { get; set; }
        public DbSet<Carbon_Dating> Carbon_Dates { get; set; }
        public DbSet<Cranial> Cranials { get; set; }
        public DbSet<Field_Note> Field_Notes { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<DigginPharoh.Models.ProjectRole> ProjectRole { get; set; }
    }
}
