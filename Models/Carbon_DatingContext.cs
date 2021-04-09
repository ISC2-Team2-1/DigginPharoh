using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigginPharoh.Models
{
    public class Carbon_DatingContext : DbContext
    {
        public Carbon_DatingContext(DbContextOptions<Carbon_DatingContext> options) : base(options)
        {

        }

        public DbSet<Carbon_Dating> Carbon_DatingSet { get; set; }
    }
}
