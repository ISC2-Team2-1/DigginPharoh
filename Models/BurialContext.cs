using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigginPharoh.Models
{
    public class BurialContext : DbContext
    {
        public BurialContext(DbContextOptions<BurialContext> options) : base(options)
        {

        }

        public DbSet<Burial> BurialSet { get; set; }
    }
}
