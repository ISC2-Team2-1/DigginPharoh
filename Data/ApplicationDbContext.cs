using DigginPharoh.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

using DigginPharoh.Data;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Microsoft.AspNetCore.Identity;

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

        public DbSet<BiologicalSamples> BioSamples { get; set; }
        public DbSet<Burial> GamousBurials { get; set; }
        public DbSet<BurialIDInfo> BurialIdInfos { get; set; }
        public DbSet<Carbon_Dating> CarbonDates { get; set; }
        public DbSet<Cranial> Craniums { get; set; }
        public DbSet<Field_Note> FieldNotes { get; set; }
        public DbSet<Note> JustNotes { get; set; }
        public DbSet<DigginPharoh.Models.ProjectRole> ProjectRoles { get; set; }

    }
}
