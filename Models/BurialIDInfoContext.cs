using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigginPharoh.Models
{
    public class BurialIDInfoContext : DbContext
    {
        public BurialIDInfoContext(DbContextOptions<BurialIDInfoContext> options) : base(options)
        {

        }

        public DbSet<BurialIDInfo> BurialIDInfoSet { get; set; }
    }
}
